using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class PlannedTour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnToGuideHist_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuidedPurchaseHist.aspx");
        }
    }
}