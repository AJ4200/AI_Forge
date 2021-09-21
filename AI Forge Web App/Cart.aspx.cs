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
        AI_Forge_serviceClient client = new AI_Forge_serviceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            //change param to session variable
            generateProductHtml(new List<Product>());
        }

        private void generateProductHtml(List<Product> products)
        {
            string html = "";
            foreach (Product p in products)
            {
                html += "<li class='cart-product-container'>";
                html += "<div class='product-container-info'>";
                html += "<div class='product-container-image'>";
                html += "<img class='container-image' src='" + p.PROD_Image_Path + "' alt='" + p.PROD_Name + "'/>";
                html += "</div>";
                html += "<div class='item-summary'>";
                html += "<p class='product-name'>" + p.PROD_Name + "</p>";
                html += "<div class='product-select'>";
                html += "<span class='select-less'><asp:Button ID='btnInc_" + p.PROD_Name + "' runat='server' Text='-' Width='18px'/></span>";
                html += "<span class='quantity-value'><asp:Label ID='lbl" + p.PROD_Name + " runat='server' Text='1'></asp:Label></span>";
                html += "<span class='select-more'><asp:Button ID='btnDec_" + p.PROD_Name + "' runat='server' Text='+' Width='18px'/></span>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "<div class='item-price'>";
                html += "<p class='price-heading'> Price </p>";
                html += "<asp:Label ID ='" + p.PROD_Name + "_Name' runat='server' Text='" + p.PROD_Name + "'></asp:Label>";
                html += "</div>";
                html += "<div class='product-tile-prices'>";
                if (p.SLE_ID != null)
                {
                    double salePrice = (double)(p.PROD_Price - p.PROD_Price * client.GetSale(Convert.ToInt32(p.SLE_ID)).SLE_Value);
                    html += "<p class='price-value'> R" + Math.Round(salePrice, 2) + "' </p>";

                }
                else
                {
                    html += "<p class='price-value'> R" + Math.Round(p.PROD_Price, 2) + "' </p>";
                }
                html += "</div>";
                html += "</li>";
            }
            cart.InnerHtml = html;
        }

    }

}