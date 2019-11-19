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

        }

        protected void BtnPurchaseTicks_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:50744/GuidedPayment.aspx";
            Response.Redirect(url);
        }
    }
}