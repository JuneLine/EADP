using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class TourGuideConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UniqueId"] != null)
                {
                    if (Session["UserId"] == null)
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else if (Session["role"].ToString() == "Guide")
                    {

                    }
                    else
                    {
                        if (Session["role"].ToString() == "Admin")
                        {

                        }
                    }
                    int newId = int.Parse(Session["UniqueId"].ToString());

                    SelfPlan td = new SelfPlan();
                    td = td.getTDByUniqueId(newId);
                    LabelTitle.Text = td.Title.ToString();
                    LabelDate.Text = td.Date.ToString();
                    LabelHire.Text = td.Hire.ToString();
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

                }

                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void BtnBack_Click1(object sender, EventArgs e)
        {
            Response.Redirect("TourGuide.aspx");
        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Session["role"] != null)
            {
                if (Session["role"].Equals("Guide"))
                {
                    int updCnt;
                    string newStatus = "Confirmed";
                    string currStatus = (string)ViewState["CurrStatus"];

                    SelfPlan td = new SelfPlan();
                    updCnt = td.UpdTDbyID(newStatus, int.Parse(Session["UniqueId"].ToString()));

                    if (updCnt == 1)
                    {
                        Response.Redirect("TourGuide.aspx");
                    }
                }

                else if(Session["role"].Equals("Admin"))
                {
                    int updCnt;
                    string newStatus = "Confirmed";
                    string currStatus = (string)ViewState["CurrStatus"];

                    SelfPlan td = new SelfPlan();
                    updCnt = td.UpdTDbyID(newStatus, int.Parse(Session["UniqueId"].ToString()));

                    if (updCnt == 1)
                    {
                        Response.Redirect("TourGuide.aspx");
                    }
                }
            }
        }
    }
}