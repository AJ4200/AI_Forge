using AI_Forge_Web_App.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class Shop : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();

        CheckBoxList chkCategories = new CheckBoxList();
        List<Product> productsOnDisplay = null;
        List<string> appliedFilters = null;
        int priceIndex;

        protected void Page_Load(object sender, EventArgs e)
        {
            productsOnDisplay = new List<Product>();
            appliedFilters = new List<string>();
            productsOnDisplay = client.GetProducts().ToList();
            foreach (string c in client.GetCatagories().ToList())
            {
                cblCategories.Items.Add(c);
            }

            generateProductHtml();
        }

        private void generateProductHtml()
        {
            string html = "";
            foreach (Product p in productsOnDisplay)
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
            products_on_display.InnerHtml = html;
        }

        protected void btnShowFilters_Click(object sender, EventArgs e)
        {
            divFilters.Visible = true;
            if (divSort.Visible)
            {
                divSort.Visible = false;
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            if(!min_price.Text.Equals(null) && !max_price.Text.Equals(null))
            {
                var fltr = "Price: " + min_price.Text + "-" + max_price.Text;
                if (!priceIndex.Equals(null))
                {
                    appliedFilters[priceIndex] = fltr;
                } else
                {
                    appliedFilters.Add(fltr);
                    priceIndex = appliedFilters.Count - 1;
                }
            }

            foreach(ListItem lst in cblCategories.Items)
            {
                if (lst.Selected && !appliedFilters.Contains(lst.Text))
                {
                    appliedFilters.Add(lst.Text);
                } 
                else if(!lst.Selected && appliedFilters.Contains(lst.Text))
                {
                    appliedFilters.Remove(lst.Text);
                }
            }
            divFilters.Visible = false;
        }

        protected void btnShowSort_Click(object sender, EventArgs e)
        {
            divSort.Visible = true;
            if (divFilters.Visible)
            {
                divFilters.Visible = false;
            }
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {

            divSort.Visible = false;
        }
    }
}
