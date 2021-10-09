using AI_Forge_Web_App.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class Checkout1 : System.Web.UI.Page
    {
        AI_Forge_serviceClient client = new AI_Forge_serviceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            getTotal(List<Product>);
        }

        private void getTotal(List<Product> products)
        {
            double total = 0;
            string display = "";
            int delivery = 0;
            foreach (Product p in products)
            {
                if (p.SLE_ID != null)
                {
                    double salePrice = (double)(p.PROD_Price - p.PROD_Price * client.GetSale(Convert.ToInt32(p.SLE_ID)).SLE_Value);
                    total += Math.Round(salePrice, 2);

                }
                else
                {
                    total += Math.Round(p.PROD_Price, 2);
                }
            }

            if (total >= 500)
            {
                delivery = 0;
            }
            else
            {
                delivery = 15;
            }
            double ToPay = total + delivery;

            display += "< h3 >" + total + "</ h3 >";
            display += "< h3 >" + delivery + "</ h3 >";
            display += "< h3 >" + ToPay + "</ h3 >";

            Totals.InnerHtml = display;

        }
    }
}