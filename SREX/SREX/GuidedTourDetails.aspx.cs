﻿using SREX.BLL;
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

            if (Request.QueryString["tourId"] != null)
            {
                int id = int.Parse(Request.QueryString["tourId"]);

                GuideTour tour = new GuideTour();
                OneTour = tour.GetOne(id);
                DataListNameOnly.DataSource = OneTour;
                DataListNameOnly.DataBind();

                GuideTour tourInfo = new GuideTour();
                OneTourInfo = tourInfo.GetOneInfo(id);
                DataListInfo.DataSource = OneTourInfo;
                DataListInfo.DataBind();

                foreach (GuideTour Items in OneTour)
                {
                    if (Items.Limit == 0)
                    {                        
                        BtnPurchaseTicks.Visible = false;
                        OutOfTickets.Visible = true;
                    }
                }

                if (Session["UserId"] != null)
                {
                    if (Session["role"].ToString() == "Admin")
                    {
                        EditTour.Visible = true;
                    }
                    else if (Session["role"].ToString() != "Admin")
                    {
                        EditTour.Visible = false;
                    }
                }
            }
            else
            {
                Response.Redirect("GuidedTour.aspx");
            }
        }

        protected void BtnPurchaseTicks_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["tourId"];
            Response.Redirect("GuidedPayment?tourId=" + id);
        }

        protected void EditTour_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["tourId"];
            Response.Redirect("EditTour?tourId=" + id);
        }
    }
}