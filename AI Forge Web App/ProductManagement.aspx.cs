using AI_Forge_Web_App.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI_Forge_Web_App
{
    public partial class ProductManagement : System.Web.UI.Page
    {
        AI_Forge_ServiceClient client = new AI_Forge_ServiceClient();
        List<Product> toSearch;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserType"].ToString() == "MAN")
            //{
            //    Response.Redirect("home.aspx");
            //}
            //else
            //{
            if (Request.QueryString["type"] == null)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                switch (Request.QueryString["type"])
                {
                    case "add":
                        divSearch.Visible = false;
                        divEdit.Visible = false;
                        divDelete.Visible = false;
                        break;
                    case "edit":
                        divName.Visible = false;
                        divPrice.Visible = false;
                        divCategory.Visible = false;
                        divImage.Visible = false;
                        divDescription.Visible = false;
                        divAdd.Visible = false;
                        divEdit.Visible = false;
                        divDelete.Visible = false;
                        toSearch = client.GetProducts().ToList();
                        break;
                    case "delete":
                        divName.Visible = false;
                        divPrice.Visible = false;
                        divCategory.Visible = false;
                        divImage.Visible = false;
                        divDescription.Visible = false;
                        divEdit.Visible = false;
                        divAdd.Visible = false;
                        divDelete.Visible = false;
                        toSearch = client.GetProducts().ToList();
                        break;
                    default:
                        Response.Redirect("Home.aspx");
                        break;
                }
            }
            //}
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            string cat = getCategory();

            if (!cat.Equals(""))
            {
                bool added = client.AddProduct(name.Value, Convert.ToInt32(price.Value), imgPath.Value, description.Value, cat);
                if (added)
                {
                    Response.Redirect("");
                }
                else
                {
                    Response.Redirect("");
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string cat = getCategory();

            if (!cat.Equals(""))
            {
                int id = Convert.ToInt32(ddlProducts.Text.Substring(0, ddlProducts.Text.IndexOf(".")));
                bool edited = client.UpdateProduct(id, name.Value, Convert.ToInt32(price.Value), imgPath.Value, description.Value, cat);
                if (edited)
                {
                    Response.Redirect("");
                }
                else
                {
                    Response.Redirect("");
                }
            }
        }

        private string getCategory()
        {
            if (general.Checked)
            {
                return general.Value;
            }
            else if (kitchen.Checked)
            {
                return kitchen.Value;
            }
            else if (security.Checked)
            {
                return security.Value;
            }
            else if (bathroom.Checked)
            {
                return bathroom.Value;
            }
            else if (bedroom.Checked)
            {
                return bedroom.Value;
            }
            else if (living_room.Checked)
            {
                return living_room.Value;
            } 
            else
            {
                return "";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ddlProducts.Text.Substring(0, ddlProducts.Text.IndexOf(".")));
            bool deleted = client.DeleteProduct(id);
            if (deleted)
            {
                Response.Redirect("");
            }
            else
            {
                Response.Redirect("");
            }
        }

        protected void ddlProducts_TextChanged(object sender, EventArgs e)
        {
            List<Product> temp = new List<Product>();
            foreach (Product p in toSearch)
            {
                if (p.PROD_Name.ToUpper().StartsWith(ddlProducts.Text.ToUpper()))
                {
                    temp.Add(p);
                    ddlProducts.Items.Add(p.PROD_ID + ". " + p.PROD_Name);
                }
            }
            toSearch = temp;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            switch (Request.QueryString["ID"])
            {
                case "edit":
                    divName.Visible = true;
                    divPrice.Visible = true;
                    divCategory.Visible = true;
                    divImage.Visible = true;
                    divDescription.Visible = true;
                    divEdit.Visible = true;
                    toSearch = client.GetProducts().ToList();
                    break;
                case "delete":
                    divDelete.Visible = true;
                    toSearch = client.GetProducts().ToList();
                    break;
                default:
                    Response.Redirect("Home.aspx");
                    break;
            }
        }
    }
}