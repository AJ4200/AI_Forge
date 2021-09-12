using AI_Forge_Web_App.ServiceReference;
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

        List<Item> itemsOnDisplay = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            itemsOnDisplay = client.GetActiveItems().ToList();
            generateProductHtml(itemsOnDisplay);
            populateDdlPriceRange();
            foreach (string c in client.GetItemCatagories())
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
            foreach (Item i in itemsOnDisplay)
            {
                if (i.SLE_ID == null)
                {
                    temp = i.ITM_Price;
                }
                else
                {
                    var sale = client.GetSale((int)i.SLE_ID);
                    temp = i.ITM_Price - i.ITM_Price * sale.SLE_Value;
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
            var range = Math.Ceiling((highest - lowest + 1)/15);
            for (int i = (int)lowest; i < highest-range;)
            {
                ddlPriceRange.Items.Add(i + "-" + (i + range));
            }
        }

        private void generateProductHtml(List<Item> items)
        {
            string html = "";
            foreach (Item i in items)
            {
                html += "<ul><li class='product-tile'>";
                html += "<div class='product-tile-container'>";
                html += "<div class='product-container-image'>";
                html += "<a href ='" + i.ITM_Name + ".aspx' class='container-link' title='" + i.ITM_Name + "'>";
                html += "<img class='container-image' src='" + i.ITM_Image_Path + "' alt='" + i.ITM_Name + "'/>";
                html += "</a>";
                html += "</div>";
                html += "< div class='product-container-details'>";
                html += "< a class='details-link' href='" + i.ITM_Name + ".aspx'>View Details</a>";
                html += "</div>";
                html += "</div>";
                html += "<div class='product-tile-summary'>";
                html += "<div class='product-links'>";
                html += "<asp:Label ID ='" + i.ITM_Name + "_Name' runat='server' Text='" + i.ITM_Name + "'></asp:Label>";
                html += "</div>";
                html += "<div class='product-tile-prices'>";
                if(i.SLE_ID != null)
                {
                    html += "<p><asp:Label ID='" + i.ITM_Name + "_Price' runat='server' style='text-decoration:line-through; font-size:6px;'" +
                        " Text='" + Math.Round(i.ITM_Price, 2) + "'></asp:Label></p>";
                    double salePrice = (double)(i.ITM_Price - i.ITM_Price * client.GetSale(Convert.ToInt32(i.SLE_ID)).SLE_Value);
                    html += "<p><asp:Label ID='" + i.ITM_Name + "_Sale_Price' runat='server' Text='" + Math.Round(salePrice, 2) + "'></asp:Label></p>";

                }
                else
                {
                    html += "<p><asp:Label ID='" + i.ITM_Name + "_Price' runat='server' Text='" + Math.Round(i.ITM_Price, 2) + "'></asp:Label></p>";
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
            if(ddlCategory.TabIndex != 0)
            {
                var fliteredCategoryItems = new List<Item>();
                foreach(Item i in itemsOnDisplay)
                {
                    if (i.ITM_Category.Equals(ddlCategory.SelectedValue))
                    {
                        fliteredCategoryItems.Add(i);
                    }
                }
                itemsOnDisplay = fliteredCategoryItems;
            }
        }

        protected void ddlPriceRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPriceRange.TabIndex != 0)
            {
                var fliteredPriceItems = new List<Item>();
                foreach (Item i in itemsOnDisplay)
                {
                    var token = ddlPriceRange.SelectedItem.ToString().IndexOf("-");
                    var min = Convert.ToInt32(ddlPriceRange.SelectedItem.ToString().Substring(0, token));
                    var max = Convert.ToInt32(ddlPriceRange.SelectedItem.ToString().Substring(token + 1, ddlPriceRange.SelectedItem.ToString().Length));
                    if (i.ITM_Price>=min && i.ITM_Price<=max)
                    {
                        fliteredPriceItems.Add(i);
                    }
                }
                itemsOnDisplay = fliteredPriceItems;
            }
        }

        protected void ddlSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSortOptions.SelectedValue.Equals("Name"))
            {
                itemsOnDisplay.Sort((a, b) => a.ITM_Name.CompareTo(b.ITM_Name));
            } 
            else if (ddlSortOptions.SelectedValue.Equals("Price"))
            {
                itemsOnDisplay.Sort((a, b) => a.ITM_Price.CompareTo(b.ITM_Price));
            }
            else if (ddlSortOptions.SelectedValue.Equals("Category"))
            {
                itemsOnDisplay.Sort((a, b) => a.ITM_Category.CompareTo(b.ITM_Category));
            }
        }
    }
}