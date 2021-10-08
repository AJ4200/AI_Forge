using AI_Forge_Frontend.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Frontend
{
    public partial class Shop : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            generateHtml(client.GetProducts().ToList());
        }

        private void generateHtml(List<Product> products)
        {
            string html = "";
            foreach (Product p in products)
            {
                html += "<ul><li class='product-tile'>";
                html += "<div class='product-tile-container'>";
                html += "<div class='product-container-image'>";
                html += "<a href ='Product.aspx' class='container-link' title='" + p.PROD_Name + "'>";
                html += "<img class='container-image' src='" + p.PROD_Image_Path + "' alt='" + p.PROD_Name + "'/>";
                html += "</a>";
                html += "</div>";
                html += "< div class='product-container-details'>";
                html += "< a class='details-link' href='" + p.PROD_Name + ".aspx'>View Details</a>";
                html += "</div>";
                html += "</div>";
                html += "<div class='product-tile-summary'>";
                html += "<div class='product-links'>";
                html += "<asp:Label ID ='" + p.PROD_Name + "_Name' runat='server' Text='" + p.PROD_Name + "'></asp:Label>";
                html += "</div>";
                html += "<div class='product-tile-prices'>";
                if (p.SLE_ID != null)
                {
                    html += "<p><asp:Label ID='" + p.PROD_Name + "_Price' runat='server' style='text-decoration:line-through; font-size:6px;'" +
                        " Text='" + Math.Round(p.PROD_Price, 2) + "'></asp:Label></p>";
                    double salePrice = (double)(p.PROD_Price - p.PROD_Price * client.GetSale(Convert.ToInt32(p.SLE_ID)).SLE_Value);
                    html += "<p><asp:Label ID='" + p.PROD_Name + "_Sale_Price' runat='server' Text='" + Math.Round(salePrice, 2) + "'></asp:Label></p>";

                }
                else
                {
                    html += "<p><asp:Label ID='" + p.PROD_Name + "_Price' runat='server' Text='" + Math.Round(p.PROD_Price, 2) + "'></asp:Label></p>";
                }
                html += "</div>";
                html += "</div>";
                html += "</li></ul>";
            }
            active_products.InnerHtml = html;
        }
    }
}