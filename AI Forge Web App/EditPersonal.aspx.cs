using AI_Forge_Web_App.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class EditPersonal : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdatePersonal_clicked(object sender, EventArgs e)
        {

            if(client.UpdatePersonalDetails(Convert.ToInt32(Session["ID"].ToString()), name.Value, Surname.Value, Email.Value, Number.Value, Gender.Value.ToCharArray()[0], Convert.ToDateTime(DOB.Value)))
            {
                Response.Redirect("Profile.aspx");
            }
            else
            {
                error.InnerHtml = "You have got a wrong input.";
            }
        }
    }
}