using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class ShoppingHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userId"] != null)
                {
                    Purchase History = new Purchase();
                    List<Purchase> HistoryList;
                    HistoryList = History.getBuyHistory(Session["userId"].ToString());
                    GridViewPurchase.Visible = true;
                    GridViewPurchase.DataSource = HistoryList;
                    GridViewPurchase.DataBind();
                }
            }
        }
    }
}