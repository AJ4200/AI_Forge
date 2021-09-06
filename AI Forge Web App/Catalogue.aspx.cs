using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace AI_Forge_Web_App
{
    public partial class Catalogue : System.Web.UI.Page
    {
        private bool sortAscending;
        private enum sortValues { Name, Date, Price };
        private List<Product> products;

        protected void Page_Load(object sender, EventArgs e)
        {
            divOpenFilter.Visible = false;
            divSortOptions.Visible = false;
            sortAscending = true;
            products = new List<Product>();
            addProductContainer();
        }
        
        private void addProductContainer()
        {
            products.AddRange(GetAllProducts());
            sortProducts(sortValues.Name);

            HtmlGenericControl ul = new HtmlGenericControl();
            ul.TagName = "ul";
            ul.ID = "Catalog";

            foreach (Product p in products)
            {
                ul.Controls.Add(addProduct(p.Product_Name, p.Product_Price, p.Product_Image));
            }
        }

        private Control addProduct(string name, float price, Image image)
        {
            HtmlGenericControl liTile = new HtmlGenericControl();
            liTile.TagName = "li";
            liTile.ID = name + "_Container";
            liTile.Attributes.Add("class", "tile");

            HtmlGenericControl divProductContainer = new HtmlGenericControl();
            divProductContainer.TagName = "div";
            divProductContainer.ID = name;
            divProductContainer.Attributes.Add("class", "container");

            HtmlGenericControl divImage = new HtmlGenericControl();
            divImage.TagName = "div";
            divImage.ID = "Image-Container";
            divImage.Attributes.Add("class", "image");

            HtmlGenericControl divDetails = new HtmlGenericControl();
            divDetails.TagName = "div";
            divDetails.ID = "Details-Contailer";
            divDetails.Attributes.Add("class", "details");

            HtmlGenericControl divSummary = new HtmlGenericControl();
            divSummary.TagName = "div";
            divSummary.ID = "ProductName-Summary";
            divSummary.Attributes.Add("class", "summary");

            divImage.Controls.Add(new ImageButton { ID = "ibImage" });
            divSummary.Controls.Add(new Label { ID = "lblName" });
            divSummary.Controls.Add(new Label { ID = "lblPrice" });
            divProductContainer.Controls.Add(divImage);
            divProductContainer.Controls.Add(divDetails);
            liTile.Controls.Add(divProductContainer);
            liTile.Controls.Add(divSummary);

            return liTile;
        }

        private void sortProducts(sortValues name)
        {
            switch (name)
            {
                case sortValues.Name:
                    products.Sort((a, b) => a.Product_Name.CompareTo(b.Product_Name);
                    break;
                case sortValues.Date:
                    products.Sort((a, b) => a.Product_Date_Modified.CompareTo(b.Product_Date_Modified);
                    break;
                case sortValues.Price:
                    products.Sort((a, b) => a.Product_Price.CompareTo(b.Product_Price);
                    break;
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {

        }

        protected void ibtnSortDir_Click(object sender, ImageClickEventArgs e)
        {
            if (sortAscending)
            {
                //TODO
                sortAscending = false;
                ibtnSortDir.ImageUrl = "~/images/descending";
            }
            else
            {
                //TODO
                sortAscending = true;
                ibtnSortDir.ImageUrl = "~/images/ascending";
            }
        }

        protected void btnSortBy_Click(object sender, EventArgs e)
        {

        }

        protected void btnFilterOptions_Click(object sender, EventArgs e)
        {

        }

        protected void ddlPriceRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
        }

        protected void blSortOptions_TextChanged(object sender, EventArgs e)
        {
            //TODO
        }
    }
}