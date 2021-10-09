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
        AI_Forge_serviceClient client = new AI_Forge_serviceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdatePersonal_clicked(object sender, EventArgs e)
        {

            if(client.UpdatePersonalDetails(1, name, Surname, Email, Number, Gender, DOB))
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