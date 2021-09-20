using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AI_Forge_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAI_Forge_service" in both code and config file together.
    [ServiceContract]
    public interface IAI_Forge_service
    {
        [OperationContract]
        int Login(string Email, string Password);

        [OperationContract]
        bool Register(string Name, string Surname, string Email, string Contact, char Gender, DateTime dob, string Password);
     
        [OperationContract]
        bool UpdateInfo(string Name, string Surname, string Email, string Contact, char Gender, DateTime dob, string Address, string Password);

        [OperationContract]
        bool UpdateProduct(int id, string name, int price, string category, int height, int width, int depth, string imgPath, string description, int quantity);

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        User VerifyEmail(string Email);

        [OperationContract]
        bool AddProduct(string name, int price, string category, int height, int width, int depth, string imgPath, string description, int quantity);

        [OperationContract]
        bool DeleteProduct(int id);

        [OperationContract]
        List<Product> GetProductsOnSpecial();

        [OperationContract]
        List<Product> GetActiveProducts();

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        Sale GetSale(int id);

        [OperationContract]
        List<string> GetProductCatagories();
    }
}
