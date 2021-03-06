﻿using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class TourGuideViewPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["PlanId"] != null)
                {
                    int queryId = int.Parse(Request.QueryString["PlanId"].ToString());
                    SelfPlan td = new SelfPlan();
                    td = td.getTDByUniqueId(queryId);
                    LabelTitle.Text = td.Title.ToString();
                    LabelDate.Text = td.Date.ToString();
                    LabelHire.Text = td.Status.ToString();
                    LabelTiming1.Text = td.Timing1.ToString();
                    LabelTiming2.Text = td.Timing2.ToString();
                    LabelTiming3.Text = td.Timing3.ToString();
                    LabelTiming4.Text = td.Timing4.ToString();
                    LabelTiming5.Text = td.Timing5.ToString();
                    LabelTiming6.Text = td.Timing6.ToString();
                    LabelTiming7.Text = td.Timing7.ToString();
                    LabelTiming8.Text = td.Timing8.ToString();
                    LabelTiming9.Text = td.Timing9.ToString();
                    LabelTiming10.Text = td.Timing10.ToString();

                    if (td.Status.ToString() == "Confirmed")
                    {
                        LabelGuidedBy.Text = "Guided by: " + td.TourGuideName.ToString();
                    }
                }

                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewAllGuidingTours.aspx");
        }
    }
}