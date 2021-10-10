using AI_Forge_Web_App.ServiceReference;
using HashPass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();


            if (password.Value == re_password.Value)
            {
                var regUser = client.Register(name.Value,
                             surname.Value,
                             Email.Value,
                             phone.Value,
                             gender.Value.ToCharArray()[0],
                             Convert.ToDateTime(dob.Value),
                             Secrecy.HashPassword(password.Value));

                Response.Redirect("SignIn.aspx");
            }
            else
            {
                //Some error message
            }
        }
    }
}