using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AI_Forge_Web_App.ServiceReference;
using HashPass;

namespace AI_Forge_Web_App
{
    public partial class SignIn : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var loguser = client.Login(email.Value, Secrecy.HashPassword(password.Value));

            if (loguser != null)
            {
                Session["UserID"] = loguser.User_Type;
                Session["UserType"] = loguser.User_Type;
                Session["Name"] = loguser.User_Name;

                Response.Redirect("home.aspx");
            }
            //else
            //{
            //    error.Text = "Invalid username or password.";
            //}
        }
    }
}