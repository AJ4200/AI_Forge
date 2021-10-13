using AI_Forge_Web_App.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class Checkout : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            generateCartHtml();

            double total = 0;
            foreach (UserCart c in master.CartItems)
            {
                total += (c.quantity * c.price);
            }
            
            if (total > 450)
            {
                subtotal.InnerHtml = "R" + String.Format("{0:0.00}", total + 100);
                delivery.InnerHtml = "R100.00";
            } 
            else
            {
                vat.InnerHtml = "R" + String.Format("{0:0.00}", total * 0.14);
                delivery.InnerHtml = "R0.00";
            }
        }

        private void generateCartHtml()
        {
            string html = "";
            foreach (UserCart c in master.CartItems)
            {
                var p = client.GetProduct(c.id);
                html += "<li class='cart-product-container'>";
                //html += "<div class='product-container-info'>";
                html += "<div class='product-container-image'>";
                html += "<img class='container-image' src='" + p.PROD_Image_Path + "' alt='" + p.PROD_Name + "'/>";
                html += "</div>";
                html += "<div class='item-summary'>";
                html += "<p class='product-name'>" + p.PROD_Name + "</p>";
                html += "<div class='product-select'>";
                html += "<span class='select-less'><asp:Button ID='btnInc_" + p.PROD_Name + "' runat='server' Text='-' Width='18px'/></span>";
                html += "<span class='quantity-value'><p>" + c.quantity + "</p></span>";
                html += "<span class='select-more'><asp:Button ID='btnDec_" + p.PROD_Name + "' runat='server' Text='+' Width='18px'/></span>";
                html += "</div>";
                html += "</div>";
                //html += "</div>";
                html += "<div class='item-price'>";
                html += "<p class='price-heading'> Price </p>";
                //html += "<asp:Label ID ='" + p.PROD_Name + "_Name' runat='server' Text='" + p.PROD_Name + "'></asp:Label>";
                //html += "</div>";
                //html += "<div class='product-tile-prices'>";
                if (p.SLE_ID != null)
                {
                    double salePrice = (double)(p.PROD_Price - p.PROD_Price * client.GetSale(Convert.ToInt32(p.SLE_ID)).SLE_Value);
                    html += "<p class='price-value'> R" + String.Format("{0:0.00}", salePrice) + "</p>";

                }
                else
                {
                    html += "<p class='price-value'> R" + String.Format("{0:0.00}", p.PROD_Price) + "</p>";
                }
                html += "</div>";
                html += "</li>";
            }
            cart.InnerHtml = html;
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            var id = client.CreateInvoice(Convert.ToInt32(Session["UserID"].ToString()));
            if (id != 0)
            {
                foreach (UserCart c in master.CartItems)
                {
                    client.AddToInvoice(id, c.id, (decimal)c.price, c.quantity);
                }
                Response.Redirect("Checkout.aspx?id="+id);
            }
            else
            {
                Response.Redirect("Cart.aspx");
            }

        }
    }

}