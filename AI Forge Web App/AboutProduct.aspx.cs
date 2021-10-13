using AI_Forge_Web_App.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class AboutProduct : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();
        double purchasePrice;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("home.aspx");
            } 
            else
            {
                var item = client.GetProduct(Convert.ToInt32(Request.QueryString["ID"]));

                imgdiv.InnerHtml = "<img src ='" + item.PROD_Image_Path + "' alt ='" + item.PROD_Name + "'>";
                itemname.InnerHtml = item.PROD_Name;
                decrip.InnerHtml = item.PROD_Description;

                if (item.SLE_ID != null)
                {
                    var discPrice = (double)(item.PROD_Price - item.PROD_Price * client.GetSale(Convert.ToInt32(item.SLE_ID)).SLE_Value);
                    price.InnerHtml = "R" + String.Format("{0:0.00}", discPrice);
                    purchasePrice = discPrice;
                }
                else
                {
                    price.InnerHtml = "R" + String.Format("{0:0.00}", item.PROD_Price);
                    purchasePrice = (double)item.PROD_Price;
                }

                if (Session["UserType"] != null)
                {
                    cart.Visible = true;
                }
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            var prod = new UserCart(Convert.ToInt32(Request.QueryString["id"].ToString()), 1, purchasePrice);
            master.CartItems.Add(prod);
        }
    }
}