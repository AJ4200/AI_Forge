using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class master : System.Web.UI.MasterPage
    {
        public static List<UserCart> CartItems = new List<UserCart>();
        protected void Page_Load(object sender, EventArgs e)
        {
            signout.Visible = false;
            admin.Visible = false;

            if (Session["UserType"] != null)
            {
                signup.Visible = false;
                signin.Visible = false;
                signout.Visible = true;

                if (Session["UserType"].ToString() == "MAN")
                {
                    admin.Visible = true;
                    sb.Visible = false;
                }
            }
        }
    }
}