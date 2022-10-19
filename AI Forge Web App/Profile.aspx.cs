using AI_Forge_Web_App.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class Profile : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {       
            if(Session["ID"] != null)
            {

                dynamic user = client.GetUser(Convert.ToInt32(Session["ID"].ToString()));

                string Display = " ";

                Display += "< h3 >" + user.User_Name + "  " + user.User_Surname + "</ h3 >";
                Display += "< h3 >" + user.User_Email + "</ h3 >";
                Display += "< h3 >" + user.User_Contact + "</ h3 >";
                Display += "< h3 >" + user.User_Gender + "</ h3 >";
                Display += "< h3 >" + user.User_DOB + "</ h3 >";
                Display += "< h3 >";

                String address = client.GetAddress(Convert.ToInt32(Session["ID"].ToString())).ADRS_Details;
                String[] words = address.Split(' ');

                foreach (String word in words)
                {
                    Display += word;
                    Display += "<br />";
                }
                Display += "</ h3 >";

                HardCode.InnerHtml = Display;

            }
           
        }
    }
}