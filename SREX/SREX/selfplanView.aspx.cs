using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class selfplanView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UniqueId"] != null)
                {
                    int newId = int.Parse(Session["UniqueId"].ToString());

                    SelfPlan td = new SelfPlan();
                    td = td.getTDByUniqueId(newId);
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

                    if (td.Hire.ToString() == "Yes")
                    {
                        if (td.Status.ToString() == "Confirmed")
                        {
                            LabelGuidedBy.Text = "Guided by: " + td.TourGuideName.ToString();
                            LabelHire.Text = "Status: " + td.Status.ToString();
                            LabelInfo.Text = "Please refer to your email for more information";
                        }

                        else if (td.Status.ToString() == "Pending")
                        {
                            LabelGuidedBy.Text = "Your request is currently pending, please check your email for updates";
                            LabelHire.Text = "Status: " + td.Status.ToString();
                        }
                    }

                    else if (td.Hire.ToString() == "No")
                    {
                        LabelGuidedBy.Text = "You have not requested for a tourguide";
                        LabelHire.Visible = false;
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
            Response.Redirect("PlanningHistory.aspx");
        }
    }
}