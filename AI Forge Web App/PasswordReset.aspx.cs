using AI_Forge_Web_App.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class PasswordReset : System.Web.UI.Page
    {
        AI_Forge_serviceClient client = new AI_Forge_serviceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ResetB_Clicked(object sender, EventArgs e)
        {
            if (NewPass == Repeat)
            {
                if (client.ChangePassword(1, OldPass, NewPass))
                {
                    Response.Redirect("Profile.aspx");
                }
                else
                {
                    PassError.InnerHtml = "<h1>Your password is incorrect</h1>";
                }
            } else
            {
                PassError.InnerHtml = "<h1>Your passwords don't match</h1>";
            }

        }


       
    }
}