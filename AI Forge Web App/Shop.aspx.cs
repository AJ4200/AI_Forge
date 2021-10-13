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

        List<Product> productsOnDisplay = null;
        List<string> appliedFilters = null;
        int priceIndex;

        protected void Page_Load(object sender, EventArgs e)
        {
            productsOnDisplay = new List<Product>();
            appliedFilters = new List<string>();
            productsOnDisplay = client.GetProducts().ToList();
            generateProductHtml();
        }

        private void generateProductHtml()
        {
            string html = "<ul>";
            foreach (Product p in productsOnDisplay)
            {
                html += "<li class='product-tile'>";
                html += "<div class='product-tile-container'>";
                html += "<div class='product-container-image'>";
                html += "<a href ='Product.aspx' class='container-link' title='" + p.PROD_Name + "'>";
                html += "<img class='container-image' src='AboutProduct.aspx?id=" + p.PROD_ID + "' alt='" + p.PROD_Name + "'/>";
                html += "</a>";
                html += "</div>";
                html += "<div class='product-container-details'>";
                html += "<a class='details-link' href='AboutProduct.aspx?id=" + p.PROD_ID + "'>View Details</a>";
                html += "</div>";
                html += "</div>";
                html += "<div class='product-tile-summary'>";
                html += "<div class='product-links'>";
                html += "<p class='product-name'>" + p.PROD_Name + "'></p>";
                html += "</div>";
                html += "<div class='product-tile__prices'>";
                if (p.SLE_ID != null)
                {
                    html += "<p class='discount-price-links'>R" + String.Format("{0:0.00}", p.PROD_Price) + "></p>";
                    decimal salePrice = p.PROD_Price - p.PROD_Price * client.GetSale(Convert.ToInt32(p.SLE_ID)).SLE_Value;
                    html += "<p class='price-links'>R" + String.Format("{0:0.00}", salePrice) + "></p>";

                }
                else
                {
                    html += "<p class='price-links'>R" + String.Format("{0:0.00}", p.PROD_Price) + "</p>";
                }
                html += "</div>";
                html += "</div>";
                html += "</li>";
            }
            products_on_display.InnerHtml = html + "</ul>";
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
            if (!min_price.Text.Equals("") && !max_price.Text.Equals(""))
            {
                var fltr = "Price: " + min_price.Text + "-" + max_price.Text;
                if (!priceIndex.Equals(null))
                {
                    appliedFilters[priceIndex] = fltr;
                }
                else
                {
                    appliedFilters.Add(fltr);
                    priceIndex = appliedFilters.Count - 1;
                }
            }

            foreach (ListItem lst in cblCategories.Items)
            {
                if (lst.Selected && !appliedFilters.Contains(lst.Text))
                {
                    appliedFilters.Add(lst.Text);
                }
                else if (!lst.Selected && appliedFilters.Contains(lst.Text))
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
            switch (rdlSort.SelectedValue)
            {
                case ">Name: A-Z":
                    productsOnDisplay.Sort((x, y) => x.PROD_Name.CompareTo(y.PROD_Name));
                    break;
                case "Name: Z-A":
                    productsOnDisplay.Sort((x, y) => x.PROD_Name.CompareTo(y.PROD_Name));
                    productsOnDisplay.Reverse();
                    break;
                case "Price: Ascending":
                    productsOnDisplay.Sort((x, y) => x.PROD_Price.CompareTo(y.PROD_Price));
                    break;
                case "Price: Descending":
                    productsOnDisplay.Sort((x, y) => x.PROD_Price.CompareTo(y.PROD_Price));
                    productsOnDisplay.Reverse();
                    break;
                case "Category: A-Z":
                    productsOnDisplay.Sort((x, y) => x.PROD_Category.CompareTo(y.PROD_Category));
                    break;
                case "Category: Z-A":
                    productsOnDisplay.Sort((x, y) => x.PROD_Category.CompareTo(y.PROD_Category));
                    productsOnDisplay.Reverse();
                    break;
                default:
                    break;
            }
            divSort.Visible = false;
        }
    }
}
