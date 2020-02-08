using SREX.BLL;
using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class ControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Role"] != null)
                {
                    if (Session["Role"].ToString() == "Admin")
                    {
                        Product Prod = new Product();
                        List<Product> lowStockList;
                        lowStockList = Prod.getLowStock();
                        DataListStock.DataSource = lowStockList;
                        DataListStock.DataBind();
                    }
                    else
                    {
                        Response.Redirect("/Default");
                    }
                }
                else
                {
                    Response.Redirect("/login");
                }
            }
        }

        [WebMethod]
        public static List<object> getPieChartData()
        {
            CartItem cart = new CartItem();
            List<CartItem> cartItemList;
            cartItemList = cart.getPopularItems();
            List<object> chartData = new List<object>();
            chartData.Add(new object[] {
                "Name", "Quantity"
            });
            for (int i = 0; i < cartItemList.Count; i++)
            {
                chartData.Add(new object[]
                {
                    cartItemList[i].Prod.Name, cartItemList[i].Quantity
                });
            }
            return chartData;
        }

        [WebMethod]
        public static List<object> getBarChartData()
        {
            Purchase Pur = new Purchase();
            List<Purchase> MoneyEarnedList;
            MoneyEarnedList = Pur.getMoneyEarned();
            List<object> chartData = new List<object>();
            chartData.Add(new object[] {
                "Date", "Price"
            });
            for (int i = 0; i < MoneyEarnedList.Count; i++)
            {
                chartData.Add(new object[]
                {
                    MoneyEarnedList[i].DateOfPurchase, MoneyEarnedList[i].Price
                });
            }
            return chartData;
        }

        protected void ButtonToPage_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Attributes["Value"];
            Response.Redirect("ProductInfo?productId=" + s);
        }

        protected void ButtonToRestock_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Button btn = (Button)sender;
            string s = btn.Attributes["Stuff"];
            Product prod = new Product();
            Product Stuff = prod.GetProductDetail(s);
            Image.ImageUrl = "Pictures/" + Stuff.PictureName;
            LabelTitle.Text = Stuff.Name;
            LabelOverview.Text = Stuff.Description;
            LabelSold.Text = Stuff.Sold.ToString();
            LabelStock.Text = Stuff.InStock.ToString();
            ButtonSubmit.Attributes["Info"] = s;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Attributes["Info"];
            Product prod = new Product();
            prod.increaseProductStock(s, Convert.ToInt32(RestockAmount.Text));

            Product Stuff = prod.GetProductDetail(s);
            Image.ImageUrl = "Pictures/" + Stuff.PictureName;
            LabelTitle.Text = Stuff.Name;
            LabelOverview.Text = Stuff.Description;
            LabelSold.Text = Stuff.Sold.ToString();
            LabelStock.Text = Stuff.InStock.ToString();
            ButtonSubmit.Attributes["Info"] = s;

            Product Prod = new Product();
            List<Product> lowStockList;
            lowStockList = Prod.getLowStock();
            DataListStock.DataSource = lowStockList;
            DataListStock.DataBind();

            ClientScript.RegisterStartupScript(this.GetType(), "", "alert()", true);
        }
    }
}