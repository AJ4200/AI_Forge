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
        AI_Forge_serviceClient client = new AI_Forge_serviceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string descrip = "to be added when product is edited";
            int result = client.AddProduct(PName.Value, Convert.ToInt32(price.Value), description.Value, dimensions.Value, category.Value, Convert.ToInt32(quantity.Value), 0, 0, descrip);
            if (result == 1)
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