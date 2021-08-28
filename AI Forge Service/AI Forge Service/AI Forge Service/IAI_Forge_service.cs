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
        int Register(string Name, string Surname, string Email, decimal Contact, string Gender, DateTime dob, string Address, string Username, string Password);
     
        [OperationContract]
        int UpdateInfo(string Name, string Surname, string Email, decimal Contact, string Gender, DateTime dob, string Address, string Username, string Password,int id);

        [OperationContract]
        int UpdateProduct(int id, string Name, int Price, string Description, string Dimensions, string Category, int Quantity, int PTid, int Sale, int SalePrice, string SaleDescription);

        [OperationContract]
        User GetUser(int id);
        [OperationContract]
        User VerifyEmail(string Email, int id);

        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        int AddProduct(string Name, int Price, string Description, string Dimensions, string Category, int Quantity, int PTid, int Sale, int SalePrice, string SaleDescription);

        [OperationContract]
        bool DeleteProduct(int id);

        [OperationContract]
        List<Product> GetProductsOnSpecial();
    }
}
