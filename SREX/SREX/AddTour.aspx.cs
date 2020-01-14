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
            GuideTour Listing = new GuideTour(id, tbTourName.Text, FileTourPicture.FileName.ToString(), tbTourCaption.Text, tbDateOfTour.Text, DropDownListmeetTime.SelectedValue, tbLocation.Text, Convert.ToDecimal(tbAdultCost.Text), Convert.ToDecimal(tbChildCost.Text), Convert.ToDecimal(tbSeniorCost.Text));
            int result1 = Listing.CreateTour();
            if (result1 == 1)
            {
                string tourInfoId = "";
                GuideTour TimeActivity1 = new GuideTour(tourInfoId, DropDownListTime1.SelectedValue, tbActivity1.Text, id);
                int result2 = TimeActivity1.CreateTourInfo();
                if (result2 == 1)
                {
                    Response.Redirect("GuidedTour.aspx");
                }
            }
        }
    }
}