using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AI_Forge_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AI_Forge_Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AI_Forge_Service.svc or AI_Forge_Service.svc.cs at the Solution Explorer and start debugging.
    public class AI_Forge_Service : IAI_Forge_Service
    {
        AI_ForgeDataContext db = new AI_ForgeDataContext();

        public bool AddAddress(int user_id, string address)
        {
            var inactive_addr = (from a in db.Address_Books
                                 where a.User_Id.Equals(user_id) && a.Active.Equals(false)
                                 select a).FirstOrDefault();
            
            if (inactive_addr.Equals(null))
            {
                Address_Book addr = new Address_Book()
                {
                    User_Id = user_id,
                    ADRS_Details = address,
                    Active = true
                };

                db.Address_Books.InsertOnSubmit(addr);
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                inactive_addr.ADRS_Details = address;
                inactive_addr.Active = true;

                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
        }
            
        public bool AddProduct(string name, int price, string imgPath, string description, string category)
        {
            Product temp_product = new Product()
            {
                PROD_Name = name,
                PROD_Price = price,
                PROD_Image_Path = imgPath,
                PROD_Description = description,
                PROD_Inventory = 0,
                PROD_Category = category,
                Active = true
            };
            
            db.Products.InsertOnSubmit(temp_product);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public bool AddToInvoice(int id, int prod_id, decimal price, int quantity)
        {
            var inv = (from i in db.Invoices
                       where i.Invoice_Id.Equals(id)
                       select i).FirstOrDefault();

            var invL = new Invoice_Line()
            {
                Invoice_Id = inv.Invoice_Id,
                PROD_Id = prod_id,
                InvoiceL_Quantity = (short)quantity,
                InvoiceL_Price_Each = price
            };

            db.Invoice_Lines.InsertOnSubmit(invL);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public bool AddVoucher(int value, string code)
        {
            Voucher vchr = new Voucher()
            {
                VCHR_Value = value,
                VCHR_Code = code,
                Redeemed = false
            };

            db.Vouchers.InsertOnSubmit(vchr);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public bool ChangePassword(int id, string oldPassword, string newPassword)
        {
            var client = (from u in db.Users
                          where u.User_Id.Equals(id)
                          select u).FirstOrDefault();

            if (client != null)
            {
                if (client.User_Password.Equals(oldPassword))
                {
                    client.User_Password = newPassword;
                }

                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int CreateInvoice(int user_id)
        {
            var inv = new Invoice()
            {
                User_Id = user_id,
                Invoice_Date = DateTime.Today
            };

            db.Invoices.InsertOnSubmit(inv);
            try
            {
                db.SubmitChanges();
                return inv.Invoice_Id;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return 0;
            }
        }

        public bool DeleteProduct(int id)
        {
            var product = (from i in db.Products
                           where i.PROD_ID.Equals(id)
                           select i).FirstOrDefault();

            if (product != null)
            {
                product.Active = false;

                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Address_Book GetAddress(int id)
        {
            var addr = (from a in db.Address_Books
                       where a.ADRS_ID.Equals(id)
                       select a).FirstOrDefault();

            if (addr != null)
            {
                Address_Book address = new Address_Book()
                {
                    ADRS_ID = addr.ADRS_ID,
                    ADRS_Details = addr.ADRS_Details
                };

                return address;
            }
            else
            {
                return null;
            }
        }

        public List<string> GetCatagories()
        {
            var categories = (from p in db.Products
                         select p.PROD_Category).Distinct().ToList();
            
            return categories;
        }

        public int GetInventoryOf(int prod_ID)
        {
            var inventory = (from i in db.Products
                        where i.PROD_ID.Equals(prod_ID)
                        select i.PROD_Inventory).FirstOrDefault();

            return inventory;
        }

        public Invoice GetInvoice(int id)
        {
            var inv = (from i in db.Invoices
                       where i.Invoice_Id.Equals(id)
                       select i).FirstOrDefault();

            return inv;
        }

        //returns the subtotal and the vat
        public List<double> GetInvoiceSummary(int id)
        {
            var lines = (from i in db.Invoice_Lines
                            where i.Invoice_Id.Equals(id)
                            select i).ToList();

            decimal subtotal = 0;
            foreach(Invoice_Line l in lines)
            {
                subtotal += GetProduct(l.PROD_Id).PROD_Price * l.InvoiceL_Quantity;
            }
            List<double> summary = new List<double>();
            summary.Add((double)subtotal);
            summary.Add((double)subtotal * 0.14);
            if(subtotal > 450)
            {
                summary.Add(0);
            } else
            {
                summary.Add(100);
            }

            return summary;
        }

        public Product GetProduct(int id)
        {
            var foundItem = (from i in db.Products
                             where i.PROD_ID.Equals(id)
                             select i).FirstOrDefault();

            if (foundItem != null)
            {
                Product item = new Product()
                {
                    PROD_Name = foundItem.PROD_Name,
                    PROD_Price = foundItem.PROD_Price,
                    PROD_Image_Path = foundItem.PROD_Image_Path,
                    PROD_Description = foundItem.PROD_Description,
                    PROD_Category = foundItem.PROD_Category,
                    SLE_ID = foundItem.SLE_ID
                };

                return item;
            }
            else
            {
                return null;
            }
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            var temp = (from i in db.Products
                        where i.Active
                        select i).ToList();

            foreach (Product p in temp)
            {
                var item = new Product()
                {
                    PROD_ID = p.PROD_ID,
                    PROD_Name = p.PROD_Name,
                    PROD_Price = p.PROD_Price,
                    PROD_Image_Path = p.PROD_Image_Path,
                    PROD_Description = p.PROD_Description,
                    PROD_Category = p.PROD_Category,
                    SLE_ID = p.SLE_ID
                };

                products.Add(item);
            }

            return products;
        }

        public List<Product> GetProductsOnSpecial()
        {
            List<Product> specials = new List<Product>();

            dynamic products = (from p in db.Products
                                where !p.SLE_ID.Equals(null) && p.Active.Equals(true)
                                select p).DefaultIfEmpty();

            foreach (Product p in products)
            {
                var product = new Product()
                {
                    PROD_ID = p.PROD_ID,
                    PROD_Name = p.PROD_Name,
                    PROD_Price = p.PROD_Price,
                    PROD_Image_Path = p.PROD_Image_Path,
                    PROD_Category = p.PROD_Category,
                    SLE_ID = p.SLE_ID
                };
                specials.Add(product);
            }


            return specials;
        }

        public Sale GetSale(int id)
        {
            var sale = (from s in db.Sales 
                        where s.SLE_ID.Equals(id) 
                        select s).FirstOrDefault();
            return sale;
        }

        public User GetUser(int id)
        {
            var temp = (from u in db.Users
                        where u.User_Id.Equals(id)
                        select u).FirstOrDefault();

            var user = new User
            {
                User_Name = temp.User_Name,
                User_Email = temp.User_Email,
            };

            return user;
        }

        public bool IncreaseInventoryBy(int prod_ID, int quantity)
        {
            var product = (from i in db.Products
                           where i.PROD_ID.Equals(prod_ID)
                           select i).FirstOrDefault();

            if (product != null)
            {
                product.PROD_Inventory += (short)quantity;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public User Login(string Email, string Password)
        {
            var user = (from u in db.Users
                        where u.User_Email.Equals(Email) &&
                        u.User_Password.Equals(Password)
                        select u).FirstOrDefault();

            if (user != null)
            {
                var LoginUser = new User
                {
                    User_Id = user.User_Id,
                    User_Name = user.User_Name,
                    User_Type = user.User_Type
                };

                return LoginUser;
            }
            else
            {
                return null;
            }
        }

        public bool Register(string Name, string Surname, string Email, string Contact, char Gender, DateTime dob, string Password)
        {
            var vetUser = (from u in db.Users
                           where u.User_Email.Equals(Email)
                           select u).FirstOrDefault();

            if (vetUser == null)
            {
                var newUser = new User
                {
                    User_Name = Name,
                    User_Surname = Surname,
                    User_Email = Email,
                    User_Contact = Contact,
                    User_Gender = Gender,
                    User_DOB = dob,
                    User_Password = Password,
                };

                var domain = Email.Substring(Email.IndexOf("@") + 1, Email.Length - Email.IndexOf("@") - 1);
                if (domain.Equals("aiforge.com"))
                {
                    newUser.User_Type = "EMP";
                }
                else
                {
                    newUser.User_Type = "CUS";
                }

                db.Users.InsertOnSubmit(newUser);
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool RemoveAddress(int id)
        {
            var addr = (from a in db.Address_Books
                        where a.ADRS_ID.Equals(id)
                        select a).FirstOrDefault();

            if (addr != null)
            {
                addr.Active = false;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Transact(int id, int vchr_id)
        {
            var inv = (from i in db.Invoices
                       where i.Invoice_Id.Equals(id)
                       select i).FirstOrDefault();

            if (inv != null)
            {
                inv.VCHR_ID = vchr_id;
                try
                {
                    db.SubmitChanges();
                    addForgePoints(inv);
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }

            return false;
        }

        private void addForgePoints(Invoice inv)
        {
            var invL = (from i in db.Invoice_Lines
                        where i.Invoice_Id.Equals(inv.Invoice_Id)
                        select i).FirstOrDefault();

            decimal points = 0;
            
            if(invL != null)
            {
                points += (invL.InvoiceL_Quantity * invL.InvoiceL_Price_Each)/10;
            }

            var usr = (from u in db.Users
                       where u.User_Id.Equals(inv.User_Id)
                       select u).FirstOrDefault();

            if (usr != null)
            {
                usr.Forge_Points += points;
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                }
            }
        }

        public bool UpdatePersonalDetails(int id, string Name, string Surname, string Email, string Contact, char Gender, DateTime dob)
        {
            var client = (from u in db.Users
                          where u.User_Id.Equals(id)
                          select u).FirstOrDefault();

            if (client != null)
            {
                client.User_Name = Name;
                client.User_Surname = Surname;
                client.User_Name = Email;
                client.User_Contact = Contact;
                client.User_Gender = Gender;
                client.User_DOB = dob;

                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UpdateAddress(int id, string address)
        {
            var addr = (from a in db.Address_Books
                        where a.ADRS_ID.Equals(id)
                        select a).FirstOrDefault();

            if (addr != null)
            {
                addr.ADRS_Details = address;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProduct(int id, string name, int price, string imgPath, string description, string category)
        {
            var tempProduct = (from i in db.Products
                               where i.PROD_ID.Equals(id)
                               select i).FirstOrDefault();

            if (tempProduct != null)
            {
                tempProduct.PROD_Name = name;
                tempProduct.PROD_Price = price;
                tempProduct.PROD_Category = category;
                tempProduct.PROD_Image_Path = imgPath;
                tempProduct.PROD_Description = description;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public User VerifyEmail(string Email)
        {
            var client = (from u in db.Users
                          where u.User_Email.Equals(Email)
                          select u).FirstOrDefault();
            if (client == null)
            {
                return null;
            }
            else
            {
                return client;
            }
        }
    }
}
