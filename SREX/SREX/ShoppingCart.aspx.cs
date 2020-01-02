using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        public string FeesPayable;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<CartItem> cartItemList;
            if (!IsPostBack)
            {
                if (Session["userId"] != null)
                {
                    CartItem cart = new CartItem();
                    cartItemList = cart.GetCartItems(Session["userId"].ToString());
                    if (cartItemList.Count == 0)
                    {
                        CartMessage.Text = "Your shopping cart is empty!";
                        CartMessage.ForeColor = System.Drawing.Color.Red;
                        alertMessage.Attributes.Add("class", "alert text-center alert-warning");
                        DataList1.DataSource = cartItemList;
                        DataList1.DataBind();
                    }
                    else
                    {
                        if (Session["deleteMsg"] != null)
                        {
                            CartMessage.Text = Session["deleteMsg"].ToString();
                            CartMessage.ForeColor = System.Drawing.Color.Red;
                            alertMessage.Attributes.Add("class", "alert text-center alert-warning");
                            DataList1.DataSource = cartItemList;
                            DataList1.DataBind();
                        }

                        decimal totalPrice = cartItemList.Sum(item => item.Prod.Price);
                        LbTotal.Text = totalPrice.ToString();
                        FeesPayable = totalPrice.ToString();
                        DataList1.DataSource = cartItemList;
                        DataList1.DataBind();

                    }

                }
                else
                {
                    CartMessage.Text = "Please Login Before View your Shopping Cart";
                    CartMessage.ForeColor = System.Drawing.Color.Red;
                    alertMessage.Attributes.Add("class", "alert text-center alert-warning");
                }
            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void prodDelBtn_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)(sender);
            string productId = btn.CommandArgument;
            if (Session["UserId"] != null && productId !="")
            {
                CartItem cart = new CartItem();
                int result = cart.DeleteProductFromCart(productId, Session["UserId"].ToString());
                if (result == 1)
                {
                    Session["deleteMsg"] = "The item has been deleted.";
                    Response.Redirect("ShoppingCart.aspx");
                }
            }
        }

        [WebMethod]
        public static int Result(string Info, string Amount)
        {
            decimal paymentAmount = Convert.ToDecimal(Amount);
            Purchase Purchases = new Purchase();
            return Purchases.checkOut(HttpContext.Current.Session["UserId"].ToString(), Info, paymentAmount);
        }
    }
}