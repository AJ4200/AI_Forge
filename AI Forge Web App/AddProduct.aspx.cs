using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AI_Forge_Web_App.ServiceReference;

namespace AI_Forge_Web_App
{

    public partial class AddProduct : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string descrip = "to be added when product is edited";
            bool result = client.AddProduct(PName.Value, Convert.ToInt32(price.Value),"image/products/",description.Value, Int32.Parse(category.Value));
            if (result == true)
            {
                Response.Redirect("Admin.aspx?query=" + result);
            }
            else
            {
                Response.Redirect("Admin.aspx");
            }
        }
    }
}