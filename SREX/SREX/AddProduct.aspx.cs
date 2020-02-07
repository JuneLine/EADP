using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class AddProduct : System.Web.UI.Page
    {
        Product product = new Product();
        Category category = new Category();
        List<Category> categoriesList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categoriesList = category.GetAllCategories();
                for (int i = 0; i < categoriesList.Count; i++)
                {
                    ListItem item = new ListItem(categoriesList[i].Name.ToString());
                    ddlCategory.Items.Add(item);
                }
            }
        }

        protected void InsertProductButton_Click(object sender, EventArgs e)
        {
            if (Session["role"] != null)
            {
                if (Session["role"].Equals("Admin"))
                {
                    List<Product> ProductCheck = product.ValidateProduct(productNameTB.Text.ToString(), FileLocation.FileName);
                    if (!ProductCheck.Any())
                    {
                        Product prod = new Product(Guid.NewGuid().ToString(), productNameTB.Text.ToString(), Convert.ToDecimal(productPriceTB.Text), ddlCategory.SelectedItem.Text.ToString(), ProductDescTB.Text.ToString(), FileLocation.FileName, Convert.ToInt16(inStockTB.Text), 0);
                        int result = prod.InsertProduct();
                        if (result == 1)
                        {
                            insertMsg.Text = "This new product has been added";
                            insertMsg.ForeColor = System.Drawing.Color.Green;
                            insertMsg.Attributes.Add("class", "alert text-center alert-success");

                        }
                        else
                        {
                            insertMsg.Text = "Error";
                            insertMsg.ForeColor = System.Drawing.Color.Red;
                            insertMsg.Attributes.Add("class", "alert text-center alert-danger");
                        }
                        
                    }
                    else
                    {
                        insertMsg.Text = "Existing Product!";
                        insertMsg.ForeColor = System.Drawing.Color.Red;
                        insertMsg.Attributes.Add("class", "alert text-center alert-danger");
                    }

                }
                else
                {
                    insertMsg.Text = "This new product has not been added";
                    insertMsg.ForeColor = System.Drawing.Color.Red;
                    insertMsg.Attributes.Add("class", "alert text-center alert-danger");
                }
            }
            else
            {
                string alertMessage = "You don't have to right to Add a Product.";
                Session["alertMessage"] = alertMessage;
                Response.Redirect("Login.aspx");
            }
        }
    }
}