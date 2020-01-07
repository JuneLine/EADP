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
    public partial class ControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}