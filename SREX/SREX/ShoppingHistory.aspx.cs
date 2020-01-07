using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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
                    DataListPurchase.Visible = true;
                    DataListPurchase.DataSource = HistoryList;
                    DataListPurchase.DataBind();
                }
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            HtmlButton btn = (HtmlButton)sender;
            string s = btn.Attributes["Value"];
            Response.Redirect("Collection?OrderId=" + s);
        }
    }
}