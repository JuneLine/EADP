using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class Collection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Role"] != null)
                {
                    if (Session["Role"].ToString() == "Admin")
                    {
                        CartItem cart = new CartItem();
                        cart = cart.getUserDetailsFromOrderId(Request.QueryString["OrderId"]);
                        LabelName.Text = cart.Cust.User;
                        LabelPassport.Text = cart.Cust.Passnum;
                        LabelDOB.Text = cart.Cust.Dob;


                        List<CartItem> cartItemList;
                        cartItemList = cart.getSoldItemFromOrderId(Request.QueryString["OrderId"]);
                        for (int i = 0; i < cartItemList.Count; i++)
                        {
                            cartItemList[i].Prod.Price = cartItemList[i].Quantity * cartItemList[i].Prod.Price;
                        }
                        DataListPurchaseHistory.DataSource = cartItemList;
                        DataListPurchaseHistory.DataBind();
                        LabelOrderNum.Text = "#" + Request.QueryString["OrderId"].ToString();
                    }
                    else
                    {
                        Response.Redirect("/");
                    }
                }
                else
                {
                    Response.Redirect("/login");
                }
            }
        }
    }
}