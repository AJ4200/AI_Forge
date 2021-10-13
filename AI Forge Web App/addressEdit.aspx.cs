using AI_Forge_Web_App.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class addressEdit : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateAddress_Clicked(object sender, EventArgs e)
        {
            string address = StrAddress.Value + " " + suburb.Value + " " + CityTown.Value + " " + Province.Value + " " + PostalCode.Value;

            if (client.UpdateAddress(Convert.ToInt32(Session["ID"].ToString()), address))
            {
                Response.Redirect("Profile.aspx");
            }
            else
            {
                PassError.InnerHtml = "<h1>Couldn't update your address.</h1>";
            }
        }
    }
}