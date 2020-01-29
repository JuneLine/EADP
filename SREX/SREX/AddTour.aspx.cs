using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SREX.BLL;

namespace SREX
{
    public partial class AddTour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (Session["UserId"] != null)
            {
                if (Session["role"].ToString() != "Admin")
                {
                    Response.Redirect("GuideTour.aspx");
                }
            }
        }

        

        protected void AddTourConfirmation_Click(object sender, EventArgs e)
        {
            string id = "";
            List<GuideTour> lookForID;
            GuideTour Listing = new GuideTour(id, tbTourName.Text, FileTourPicture.FileName.ToString(), tbTourCaption.Text, tbDateOfTour.Text, DropDownListmeetTime.SelectedValue, tbLocation.Text, Convert.ToDecimal(tbAdultCost.Text), Convert.ToDecimal(tbChildCost.Text), Convert.ToDecimal(tbSeniorCost.Text));
            int result1 = Listing.CreateTour();
            if (result1 == 1)
            {
                GuideTour row = new GuideTour();
                lookForID = row.GetOneID(tbTourName.Text, FileTourPicture.FileName.ToString(), tbTourCaption.Text);
                foreach (GuideTour item in lookForID)
                {
                    string tourId = item.tourId.ToString();
                    string tourInfoId = "";
                    GuideTour TimeActivity = new GuideTour(tourInfoId, DropDownListTime1.SelectedValue, tbActivity1.Text, DropDownListTime2.SelectedValue, tbActivity2.Text, DropDownListTime3.SelectedValue, tbActivity3.Text, DropDownListTime4.SelectedValue, tbActivity4.Text, DropDownListTime5.SelectedValue, tbActivity5.Text, DropDownListTime6.SelectedValue, tbActivity6.Text, DropDownListTime7.SelectedValue, tbActivity7.Text, tourId);
                    int result2 = TimeActivity.CreateTourInfo();
                    if (result2 == 1)
                    {
                        Response.Redirect("GuidedTour.aspx");
                    }
                }
            }
        }
    }
}