using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AI_Forge_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AI_Forge_service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AI_Forge_service.svc or AI_Forge_service.svc.cs at the Solution Explorer and start debugging.
    public class AI_Forge_service : IAI_Forge_service
    {
        AI_Forge_DataClassesDataContext db = new AI_Forge_DataClassesDataContext();
        public bool AddProduct(string name, int price, string category, int height, int width, int depth, string imgPath, string description, int quantity)
        {
            Product temp_product = new Product()
            {
                PROD_Name = name,
                PROD_Price = price,
                PROD_Category = category,
                PROD_Height = (byte)height,
                PROD_Width = (byte)width,
                PROD_Depth = (byte)depth,
                PROD_Image_Path = imgPath,
                PROD_Description = description,
                PROD_Inventory = (byte)quantity,
                PROD_Active = true
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

        public bool DeleteProduct(int id)
        {
            var product = GetProduct(id);
            if (product != null)
            {
           
                if (product.PROD_Active == false)
                    product.PROD_Active = true;

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

        public List<Product> GetProductsOnSpecial()
        {
            List<Product> specials = new List<Product>();
            dynamic product = (from p in db.Products
                               where !p.SLE_ID.Equals(null) && p.PROD_Active.Equals(true)
                               select p).ToList();
            foreach (Product p in product)
            {
                specials.Add(product);
            }
            return specials;
        }

        public User GetUser(int id)
        {
            var user = (from u in db.Users
                        where u.User_Id.Equals(id)
                        select u).FirstOrDefault();

            return user;
        }

        public int Login(string Email, string Password)
        {
            var Client = (from u in db.Users
                          where u.User_Email.Equals(Email) && u.User_Password.Equals(Password) && u.User_Active.Equals(1)
                          select u).FirstOrDefault();
            if (Client != null)
            {
                return Client.User_Id;
            }
            else
            {
                return 0;
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

        public bool UpdateInfo(string Name, string Surname, string Email, string Contact, char Gender, DateTime dob, string Address, string Password)
        {
            User client = VerifyEmail(Email);

            if (client != null)
            {
                client.User_Name = Name;
                client.User_Surname = Surname;
                client.User_Email = Email;
                client.User_Contact = Contact;
                client.User_Gender = Gender;
                client.User_DOB = dob;
                client.User_Address = Address;
                client.User_Password = Password;

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

        public bool UpdateProduct(int id, string name, int price, string category, int height, int width, int depth, string imgPath, string description, int quantity)
        {
            dynamic tempProduct = GetProduct(id);
            if (tempProduct != null)
            {
                tempProduct.PROD_Name = name;
                tempProduct.PROD_Price = price;
                tempProduct.PROD_Category = category;
                tempProduct.PROD_Height = (byte)height;
                tempProduct.PROD_Width = (byte)width;
                tempProduct.PROD_Depth = (byte)depth;
                tempProduct.PROD_Image_Path = imgPath;
                tempProduct.PROD_Description = description;
                tempProduct.PROD_Inventory = quantity;
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

        public List<Product> GetActiveProducts()
        {
            var items = (from i in db.Products
                         where i.PROD_Active
                         select i).ToList();
            return items;
        }

        public Product GetProduct(int id)
        {
            Product item = null;
            var foundItem = (from i in db.Products where i.PROD_ID.Equals(id) select i).FirstOrDefault();
            if (foundItem != null)
            {
                item = new Product()
                {
                    //TODO
                };
            }

            return foundItem;
        }

        public Sale GetSale(int id)
        {
           var sale = (from s in db.Sales where s.SLE_ID.Equals(id) select s).FirstOrDefault();
            return sale;
        }

        public List<string> GetProductCatagories()
        {
            var items = (from i in db.Products
                         where i.PROD_Active
                         select i.PROD_Category).Distinct().ToList();
            return items;
        }
    }
}

