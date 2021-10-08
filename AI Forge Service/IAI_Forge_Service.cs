using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AI_Forge_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAI_Forge_Service" in both code and config file together.
    [ServiceContract]
    public interface IAI_Forge_Service
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        bool IncreaseInventoryBy(int prod_ID, int quantity);

        [OperationContract]
        bool GetInventoryOf(int prod_ID);

        [OperationContract]
        List<Product> GetProductsOnSpecial();

        [OperationContract]
        Sale GetSale(int id);

        [OperationContract]
        List<string> GetCatagories();

        [OperationContract]
        string GetCategory(int id);

        [OperationContract]
        User Login(string Email, string Password);

        [OperationContract]
        bool Register(string Name, string Surname, string Email, string Contact, char Gender, DateTime dob, string Password);

        [OperationContract]
        bool UpdatePersonalDetails(int id, string Name, string Surname, string Email, string Contact, char Gender, DateTime dob);

        [OperationContract]
        bool ChangePassword(int id, string oldPassword, string newPassword);

        [OperationContract]
        bool UpdateProduct(int id, string name, int price, string imgPath, string description, int category);

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        User VerifyEmail(string Email);

        [OperationContract]
        bool AddProduct(string name, int price, string imgPath, string description, int category);

        [OperationContract]
        bool DeleteProduct(int id);

        [OperationContract]
        bool Transact(int user_id, List<int> products, List<int> quantities);

        [OperationContract]
        Invoice GetInvoice(int id);

        [OperationContract]
        List<double> GetInvoiceSummary(int id);

        [OperationContract]
        bool IsDeliveryFree(int inv_id);
    }

}
