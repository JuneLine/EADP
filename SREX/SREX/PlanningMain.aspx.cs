using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class PlanningMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnZoo_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.wrs.com.sg/en/singapore-zoo.html");
        }

        protected void BtnNightSafari_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.wrs.com.sg/en/night-safari.html");
        }

        protected void BtnRiverSafari_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.wrs.com.sg/en/river-safari.html");
        }
    }
}