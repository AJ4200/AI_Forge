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
        public int AddProduct(string Name, int Price, string Description, string Dimensions, string Category, int Quantity, int PTid, int Sale, int SalePrice, string SaleDescription)
        {
            Product temp_product = new Product()
            {
                Product_Name = Name,
                Product_Price = Price,
                Product_Description = Description,
                Product_Dimensions = Dimensions,
                Product_Category = Category,
                Product_Quantity = Quantity,
                ProductT_ID = PTid,
                Product_Sale = Sale,
                Product_SalePrice = SalePrice,
                Product_SaleDescription = SaleDescription,
                Product_Deleted = 0
            };
            db.Products.InsertOnSubmit(temp_product);
            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
        }

        public bool DeleteProduct(int id)
        {
            var product = GetProduct(id);
            if (product != null)
            {
           
                if (product.Product_Deleted == 0)
                    product.Product_Deleted = 1;

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
            {
                return false;
            }
        }

        public List<Product> GetAllProducts()
        {
            var Products = new List<Product>();
            var product = (from p in db.Products
                           where p.Product_Deleted.Equals(0)
                           select p);
            foreach (Product p in product)
            {
                Products.Add(p);
            }
            return Products;
        }

        public Product GetProduct(int id)
        {
            Product temp_product = null;
            var product = (from p in db.Products
                           where p.Product_Id.Equals(id) && p.Product_Deleted.Equals(0)
                           select p).FirstOrDefault();
            if (product == null)
            {
                return null;
            }
            else
            {
                temp_product = new Product()
                {
                    Product_Name = product.Product_Name,
                    Product_Price = product.Product_Price,
                    Product_Description = product.Product_Description,
                    Product_Dimensions = product.Product_Dimensions,
                    Product_Category = product.Product_Category,
                    Product_Quantity = product.Product_Quantity,
                    Product_Sale = product.Product_Sale,
                    Product_SalePrice = product.Product_SalePrice,
                    Product_SaleDescription = product.Product_SaleDescription
                };
            }
            return temp_product;
        }

        public List<Product> GetProductsOnSpecial()
        {
            List<Product> specials = new List<Product>();
            dynamic product = (from p in db.Products
                               where p.Product_Sale.Equals(1) && p.Product_Deleted.Equals(0)
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

            if (user == null)
            {
                return null;
            }
            else
            {
                return user;
            }
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

        public int Register(string Name, string Surname, string Email, decimal Contact, string Gender, DateTime dob, string Address, string Username, string Password)
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
                    User_Address = Address,
                    User_UserName = Username,
                    User_Password = Password,
                    User_Type = "Client",
                };
                db.Users.InsertOnSubmit(newUser);
                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return -2;
                }
            }
            else
            {
                return 0;
            }
        }

        public int UpdateInfo(string Name, string Surname, string Email, decimal Contact, string Gender, DateTime dob, string Address, string Username, string Password, int id)
        {
            var client = VerifyEmail(Email, id);

            if (client != null)
            {
                dynamic TempClient = GetUser(id);
                if (TempClient != null)
                {

                    TempClient.User_Name = Name;
                    TempClient.User_Surname = Surname;
                    TempClient.User_Email = Email;
                    TempClient.User_Contact = Contact;
                    TempClient.User_Gender = Gender;
                    TempClient.User_DOB = dob;
                    TempClient.User_Address = Address;
                    TempClient.User_UserName = Username;
                    TempClient.User_Password = Password;

                    try
                    {
                        db.SubmitChanges();
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        ex.GetBaseException();
                        return -1;
                    }
                }
                {
                    return 0;
                }
            }
            else
            {
                return -2;
            }
        }

        public int UpdateProduct(int id, string Name, int Price, string Description, string Dimensions, string Category, int Quantity, int PTid, int Sale, int SalePrice, string SaleDescription)
        {
            dynamic tempProduct = GetProduct(id);
            if (tempProduct != null)
            {
                tempProduct.Product_Name = Name;
                tempProduct.Product_Price = Price;
                tempProduct.Product_Description = Description;
                tempProduct.Product_Dimensions = Dimensions;
                tempProduct.Product_Category = Category;
                tempProduct.Product_Quantity = Quantity;
                tempProduct.ProductT_ID = PTid;
                tempProduct.Product_Sale = Sale;
                tempProduct.Product_SalePrice = SalePrice;
                tempProduct.Product_SaleDescription = SaleDescription;
                tempProduct.Product_Deleted = 0;
                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return 0;
            }
            

        }


        public User VerifyEmail(string Email, int id)
        {
            var client = (from u in db.Users
                          where u.User_Email.Equals(Email) && u.User_Id.Equals(id)
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

        public List<Item> GetActiveItems()
        {
            var items = (from i in db.Items
                         where i.ITM_Active
                         select i).ToList();
            return items;
        }

        public Item GetItem(int id)
        {
            Item item = null;
            var foundItem = (from i in db.Items where i.ITM_ID.Equals(id) select i).FirstOrDefault();
            if (foundItem != null)
            {
                item = new Item()
                {
                    //Not needed because all information is relavent
                };
            }

            return foundItem;
        }

        public Sale GetSale(int id)
        {
           var sale = (from s in db.Sales where s.SLE_ID.Equals(id) select s).FirstOrDefault();
            return sale;
        }

        List<string> IAI_Forge_service.GetItemCatagories()
        {
            var items = (from i in db.Items
                         where i.ITM_Active
                         select i.ITM_Category).Distinct().ToList();
            return items;
        }
    }
}

