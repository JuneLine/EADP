using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
//using QRCoder;
using SREX.BLL;

namespace SREX
{
    public partial class GuidedPurchaseHist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (Session["UserId"] != null)
            {
                List<GuideTour> Hist;
                string Id = Session["UserId"].ToString();

                GuideTour rows = new GuideTour();
                Hist = rows.GetHist(Id);
                if (Hist.Count == 0)
                {
                    NoHist.Text = "Your History is empty!";
                    NoHist.ForeColor = System.Drawing.Color.Red;
                    alertMessage.Attributes.Add("class", "alert text-center alert-warning");
                    DataListHist.Visible = false;
                }
                else
                {
                    NoHist.Visible = false;
                    DataListHist.DataSource = Hist;
                    DataListHist.DataBind();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
                Response.Write("<script>alert('Please Login')</script>");
            }
        }

        protected void BtnBackToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuidedTour.aspx");
        }


        protected void showData_ServerClick(object sender, EventArgs e)
        {
            List<GuideTour> Listing1;
            List<GuideTour> Listing2;

            GuideDetails.Visible = true;

            HtmlButton btn = (HtmlButton)sender;
            int tourId = Int16.Parse(btn.Attributes["value"]);

            GuideTour row = new GuideTour();
            Listing1 = row.GetOne(tourId);
            Listing2 = row.GetOneInfo(tourId);
            DataListInfo.DataSource = Listing2;
            DataListInfo.DataBind();

            foreach (GuideTour items in Listing1)
            {
                lbltourname.Text = items.tourName.ToString();
                lbltourDate.Text = items.Date.ToString();
                lblMeetUp.Text = items.meetUpTime.ToString() + " @ " + items.meetUpLocation.ToString();
            }
        }

        protected void closeDetailPanel_ServerClick(object sender, EventArgs e)
        {
            GuideDetails.Visible = false;
        }
    }
}