using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class ProductInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string productId = Request.QueryString["productId"];
                Session["productId"] = productId;
                if (!string.IsNullOrEmpty(productId))
                {
                    Product prod = new Product();
                    prod = prod.GetProductDetail(productId);
                    lbName.Text = prod.Name;
                    lbPrice.Text = prod.Price.ToString();
                    lbDescription.Text = prod.Description;
                    productImage.ImageUrl = "Pictures/"+prod.PictureName;
                    if (prod.InStock == 0)
                    {
                        lbStock.Text = "Sold out";
                        lbStock.ForeColor = System.Drawing.Color.Red;
                        ButtonBuyNow.Visible= false;
                    }
                    else if (prod.InStock > 0)
                    {
                        lbStock.Text = "In Stock";
                        lbStock.ForeColor = System.Drawing.Color.Green;
                    }

                    if (Session["role"]!=null)
                    {
                        if (Session["role"].Equals("Admin"))
                        {
                            ButtonInfo.Style["display"] = "block";
                        }
                        else
                        {
                            ButtonInfo.Visible = false;
                        }
                    }
                }
            }
        }

        protected void BTAddToCart_Click(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                CartItem cartI = new CartItem();
                List<CartItem> items = cartI.ValidateItem(Session["productId"].ToString(), Session["UserId"].ToString());
                if (!items.Any())
                {
                    CartItem cart = new CartItem(Session["productId"].ToString(), Convert.ToInt16(quantityTb.Text), Session["UserId"].ToString());
                    int result = cart.AddProductToShoppingCart();
                    if (result == 1)
                    {
                        AddMessage.Text = "This new item have been added to your cart";
                        AddMessage.ForeColor = System.Drawing.Color.Green;
                        showMessage.Attributes.Add("class", "alert text-center alert-success");
                    }
                    else
                    {
                        AddMessage.Text = "ERROR. Adding fail.";
                        AddMessage.ForeColor = System.Drawing.Color.Red;
                        showMessage.Attributes.Add("class", "alert text-center alert-warning");
                    }
                }
                else
                {
                    AddMessage.Text = "This item is already in your cart.";
                    AddMessage.ForeColor = System.Drawing.Color.Red;
                    showMessage.Attributes.Add("class", "alert text-center alert-warning");
                }

                
            }
            else
            {
                string alertMessage = "Please Login before you make a purchase.";
                Session["alertMessage"] = alertMessage;
                Response.Redirect("Login.aspx");
            }
        }
        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                Response.Redirect("EditProductInfo?productId=" + Session["productId"]);
            }
            else
            {
                string alertMessage = "You don't have to right to Edit Product.";
                Session["alertMessage"] = alertMessage;
                Response.Redirect("Login.aspx");
            }
            
        }
    }
}