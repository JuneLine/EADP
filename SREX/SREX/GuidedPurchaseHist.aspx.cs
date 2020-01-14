using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SREX.BLL;

namespace SREX
{
    public partial class GuidedPurchaseHist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                List<GuideTour> Hist;
                string Id = Session["UserId"].ToString();

                GuideTour rows = new GuideTour();
                Hist = rows.GetHist(Id);
                DataListHist.DataSource = Hist;
                DataListHist.DataBind();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void BtnBackToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuidedTour.aspx");
        }
    }
}