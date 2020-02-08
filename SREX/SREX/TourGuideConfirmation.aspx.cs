using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
                if (Session["UserId"] != null)
                {
                    if (Session["role"].ToString() == null)
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else if (Session["role"].ToString() == "Guide")
                    {
                        int newId = int.Parse(Request.QueryString["PlanId"].ToString());

                        SelfPlan td = new SelfPlan();
                        td = td.getTDByUniqueId(newId);
                        LabelTitle.Text = td.Title.ToString();
                        LabelDate.Text = td.Date.ToString();
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
                        LabelUserName.Text = td.UserName.ToString();
                    }
                    else if (Session["role"].ToString() == "Admin")
                    {
                        int newId = int.Parse(Request.QueryString["PlanId"].ToString());

                        SelfPlan td = new SelfPlan();
                        td = td.getTDByUniqueId(newId);
                        LabelTitle.Text = td.Title.ToString();
                        LabelDate.Text = td.Date.ToString();
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
                        LabelUserName.Text = td.UserName.ToString();
                    }
                }

                else
                {

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
                    string userId = Session["UserId"].ToString();
                    string newStatus = "Confirmed";
                    string currStatus = (string)ViewState["CurrStatus"];
                    string tourguidename = Session["username"].ToString();
                    SelfPlan td = new SelfPlan();
                    SelfPlan tddd = new SelfPlan();
                    int newId = int.Parse(Request.QueryString["PlanId"].ToString());
                    SelfPlan tdd = new SelfPlan();
                    tddd = tddd.getTDByUniqueId(newId);
                    string clientId = tddd.Id.ToString();
                    tdd = tdd.getUserByUniqueId(clientId);

                    updCnt = td.UpdTDbyID(newStatus, int.Parse(Request.QueryString["PlanId"].ToString()), userId, tourguidename);

                   
                    if (updCnt == 1)
                    {
                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.EnableSsl = true;
                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new System.Net.NetworkCredential("OOADPProject1@gmail.com", "ILoveChickenRice");
                        MailMessage mailMessage = new MailMessage("OOADPPROJECT1@gmail.com", tdd.Email.ToString(), "Confirmation for request for a tour guide", "Your request for a personal tour guide has been approved!" + Environment.NewLine + Environment.NewLine + "Your tour guide will be: " + Session["Username"].ToString() +
                            Environment.NewLine + Environment.NewLine + "Date: " + tddd.Date.ToString() + Environment.NewLine + Environment.NewLine + "Location for meet up: " + tddd.Timing1.ToString() + " at 10am." + Environment.NewLine + Environment.NewLine + "If you have any enquiries, Please email your tour guide at: " + Environment.NewLine + Environment.NewLine + Session["Email"].ToString());

                        try
                        {
                            smtpClient.Send(mailMessage);
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex);
                        }

                        Response.Redirect("viewAllGuidingTours.aspx");
                    }
                }

                else if (Session["role"].Equals("Admin"))
                {
                    int updCnt;
                    string userId = Session["UserId"].ToString();
                    string newStatus = "Confirmed";
                    string currStatus = (string)ViewState["CurrStatus"];
                    string tourguidename = Session["username"].ToString();
                    SelfPlan td = new SelfPlan();
                    SelfPlan tddd = new SelfPlan();
                    int newId = int.Parse(Request.QueryString["PlanId"].ToString());
                    SelfPlan tdd = new SelfPlan();
                    tddd = tddd.getTDByUniqueId(newId);
                    string clientId = tddd.Id.ToString();
                    tdd = tdd.getUserByUniqueId(clientId);

                    updCnt = td.UpdTDbyID(newStatus, int.Parse(Request.QueryString["PlanId"].ToString()), userId, tourguidename);


                    if (updCnt == 1)
                    {
                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.EnableSsl = true;
                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new System.Net.NetworkCredential("OOADPProject1@gmail.com", "ILoveChickenRice");
                        MailMessage mailMessage = new MailMessage("OOADPPROJECT1@gmail.com", tdd.Email.ToString(), "Confirmation for request for a tour guide", "Your request for a personal tour guide has been approved!" + Environment.NewLine + Environment.NewLine + "Your tour guide will be: " + Session["Username"].ToString() +
                            Environment.NewLine + Environment.NewLine + "Date: " + tddd.Date.ToString() + Environment.NewLine + Environment.NewLine + "Location for meet up: " + tddd.Timing1.ToString() + " at 10am." + Environment.NewLine + Environment.NewLine + "If you have any enquiries, Please email your tour guide at: " + Environment.NewLine + Environment.NewLine + Session["Email"].ToString());

                        try
                        {
                            smtpClient.Send(mailMessage);
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex);
                        }

                        Response.Redirect("viewAllGuidingTours.aspx");
                    }
                }
            }
        }
    }
}