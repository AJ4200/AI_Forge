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

        public bool AddProduct(string name, int price, string imgPath, string description, int category)
        {
            Product temp_product = new Product()
            {
                PROD_Name = name,
                PROD_Price = price,
                PROD_Image_Path = imgPath,
                PROD_Description = description,
                PROD_Inventory = 0,
                CAT_ID = category,
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

        public bool DeleteProduct(int id)
        {
            var product = GetProduct(id);
            if (product != null)
            {

                if (product.Active == false)
                    product.Active = true;

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

        public List<string> GetCatagories()
        {
            var categories = (from c in db.Categories
                         select c.CAT_Name).ToList();
            return categories;
        }

        public string GetCategory(int id)
        {
            var category = (from c in db.Categories
                              select c.CAT_Name).FirstOrDefault();
            return category;
        }

        public bool GetInventoryOf(int prod_ID)
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoice(int id)
        {
            throw new NotImplementedException();
        }

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

            return summary;
        }

        public Product GetProduct(int id)
        {
            Product item = null;
            var foundItem = (from i in db.Products
                             where i.PROD_ID.Equals(id)
                             select i).FirstOrDefault();

            if (foundItem != null)
            {
                item = new Product()
                {
                    PROD_Name = foundItem.PROD_Name,
                    PROD_Price = foundItem.PROD_Price,
                    PROD_Height = foundItem.PROD_Height,
                    PROD_Width = foundItem.PROD_Width,
                    PROD_Depth = foundItem.PROD_Depth,
                    PROD_Image_Path = foundItem.PROD_Image_Path,
                    PROD_Description = null,
                    CAT_ID = foundItem.CAT_ID,
                    SLE_ID = foundItem.SLE_ID
                };
            }

            return item;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            var temp = (from i in db.Products
                        where i.Active
                        select i).ToList();

            foreach (Product p in temp)
            {
                products.Add(GetProduct(p.PROD_ID));
            }

            return products;
        }

        public List<Product> GetProductsOnSpecial()
        {
            List<Product> specials = new List<Product>();
            dynamic products = (from p in db.Products
                                where !p.SLE_ID.Equals(null) && p.Active.Equals(true)
                                select p).ToList();
            foreach (Product p in products)
            {
                var product = new Product()
                {
                    PROD_Name = products.PROD_Name,
                    PROD_Price = products.PROD_Price,
                    PROD_Image_Path = products.PROD_Image_Path,
                    PROD_Description = null,
                    PROD_Inventory = 0,
                    Active = products.Active,
                    CAT_ID = products.CAT_ID,
                    SLE_ID = products.SLE_ID
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

        public bool IsDeliveryFree(int inv_id)
        {
            throw new NotImplementedException();
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

                var domain = Email.Substring(Email.IndexOf("@"), Email.Length - Email.IndexOf("@"));
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

        public bool Transact(int user_id, List<int> products, List<int> quantities)
        {
            throw new NotImplementedException();
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

        public bool UpdateProduct(int id, string name, int price, string imgPath, string description, int category)
        {
            var tempProduct = (from i in db.Products
                               where i.PROD_ID.Equals(id)
                               select i).FirstOrDefault();

            if (tempProduct != null)
            {
                tempProduct.PROD_Name = name;
                tempProduct.PROD_Price = price;
                tempProduct.CAT_ID = category;
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
