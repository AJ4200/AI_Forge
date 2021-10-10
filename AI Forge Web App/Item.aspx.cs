using AI_Forge_Web_App.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace AI_Forge_Web_App
{
    public partial class Item : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] == null)
            {
                MessageBox.Show("Erroooooor");
                Response.Redirect("home.aspx");
            }
            var item = client.GetProduct(Convert.ToInt32(Request.QueryString["ID"]));

            imgdiv.InnerHtml = "< img src = " +item.PROD_Image_Path +"alt = '' >";
            itemname.InnerHtml = item.PROD_Name;
            price.InnerHtml = item.PROD_Price.ToString();
            decrip.InnerHtml = item.PROD_Description;
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}