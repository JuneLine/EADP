using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SREX.BLL;

namespace SREX
{
    public partial class PlannedTour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            List<GuideTour> AllTours;
            if (!IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    if (Session["role"].ToString() == "Admin" || Session["role"].ToString() == "Guide")
                    {
                        BtnAddTours.Style["display"] = "inline-block";
                    }
                }
                else
                {
                    btnToGuideHist.Visible = false;
                }

                GuideTour tour = new GuideTour();
                AllTours = tour.GetAll();
                DataListTours.DataSource = AllTours;
                DataListTours.DataBind();
            }
        }

        protected void btnToGuideHist_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuidedPurchaseHist.aspx");
        }

        protected void BtnAddTours_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTour.aspx");
        }
    }
}