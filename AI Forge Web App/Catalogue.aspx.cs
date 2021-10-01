using AI_Forge_Web_App.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class Catalogue : System.Web.UI.Page
    {
        AI_Forge_serviceClient client = new AI_Forge_serviceClient();
        List<Product> productsOnDisplay = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            productsOnDisplay = new List<Product>();
            productsOnDisplay = client.GetActiveProducts().ToList();
            generateProductHtml(productsOnDisplay);
            populateDdlPriceRange();
            foreach (string c in client.GetProductCatagories())
            {
                ddlCategory.Items.Add(c);
            }
        }

        private void populateDdlPriceRange()
        {
            int count = 0;
            decimal highest = 0;
            decimal lowest = 0;
            decimal temp;
            foreach (Product p in productsOnDisplay)
            {
                if (p.SLE_ID == null)
                {
                    temp = p.PROD_Price;
                }
                else
                {
                    var sale = client.GetSale((int)p.SLE_ID);
                    temp = p.PROD_Price - p.PROD_Price * sale.SLE_Value;
                }
                if (count == 0)
                {
                    lowest = temp;
                    count++;
                }
                if (temp <= lowest)
                {
                    lowest = temp;
                }
                if (temp >= highest)
                {
                    highest = temp;
                }
            }
            var range = Math.Ceiling((highest - lowest + 1) / 15);
            for (int p = (int)lowest; p < highest - range;)
            {
                ddlPriceRange.Items.Add(p + "-" + (p + range));
            }
        }

        private void generateProductHtml(List<Product> products)
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

        protected void btnSortOptions_Click(object sender, EventArgs e)
        {
            if (divSortOptions.Visible)
            {
                divSortOptions.Visible = false;
            }
            else
            {
                divSortOptions.Visible = true;
            }
        }

        protected void btnFilterOptions_Click(object sender, EventArgs e)
        {
            if (divFilterOptions.Visible)
            {
                divFilterOptions.Visible = false;
            }
            else
            {
                divFilterOptions.Visible = true;
            }
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategory.TabIndex != 0)
            {
                var fliteredCategoryItems = new List<Product>();
                foreach (Product p in productsOnDisplay)
                {
                    if (p.PROD_Category.Equals(ddlCategory.SelectedValue))
                    {
                        fliteredCategoryItems.Add(p);
                    }
                }
                productsOnDisplay = fliteredCategoryItems;
            }
            else
            {
                productsOnDisplay = client.GetActiveProducts().ToList();
            }
            generateProductHtml(productsOnDisplay);
        }

        protected void ddlPriceRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPriceRange.TabIndex != 0)
            {
                var fliteredPriceProducts = new List<Product>();
                foreach (Product p in productsOnDisplay)
                {
                    var token = ddlPriceRange.SelectedItem.ToString().IndexOf("-");
                    var min = Convert.ToInt32(ddlPriceRange.SelectedItem.ToString().Substring(0, token));
                    var max = Convert.ToInt32(ddlPriceRange.SelectedItem.ToString().Substring(token + 1, ddlPriceRange.SelectedItem.ToString().Length));
                    if (p.PROD_Price >= min && p.PROD_Price <= max)
                    {
                        fliteredPriceProducts.Add(p);
                    }
                }
                productsOnDisplay = fliteredPriceProducts;
            }
        }

        protected void ddlSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSortOptions.SelectedValue.Equals("Name"))
            {
                productsOnDisplay.Sort((a, b) => a.PROD_Name.CompareTo(b.PROD_Name));
            }
            else if (ddlSortOptions.SelectedValue.Equals("Price"))
            {
                productsOnDisplay.Sort((a, b) => a.PROD_Price.CompareTo(b.PROD_Price));
            }
            else if (ddlSortOptions.SelectedValue.Equals("Category"))
            {
                productsOnDisplay.Sort((a, b) => a.PROD_Category.CompareTo(b.PROD_Category));
            }
        }
    }
}
