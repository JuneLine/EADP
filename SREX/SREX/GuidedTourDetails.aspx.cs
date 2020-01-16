using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class GuidedTourDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            List<GuideTour> OneTour;
            List<GuideTour> OneTourInfo;

            string id = Request.QueryString["tourId"];

            GuideTour tour = new GuideTour();
            OneTour = tour.GetOne(id);
            DataListNameOnly.DataSource = OneTour;
            DataListNameOnly.DataBind();

            GuideTour tourInfo = new GuideTour();
            OneTourInfo = tourInfo.GetOneInfo(id);
            DataListInfo.DataSource = OneTourInfo;
            DataListInfo.DataBind();
        }

        protected void BtnPurchaseTicks_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["tourId"];
            Response.Redirect("GuidedPayment?tourId=" + id);
        }
    }
}