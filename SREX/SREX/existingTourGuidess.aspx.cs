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
    public partial class existingTourGuidess : System.Web.UI.Page
    {
        string roleGuide = "Guide";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["role"] != null)
                {
                    LabelConfirm.Visible = false;
                    if (Session["role"].ToString() == "Admin")
                    {
                        LoadApplications();



                        if (GvTD.Rows.Count == 0)
                        {
                            LabelConfirm.Text = "There are no existing tour guides";
                            LabelConfirm.ForeColor = System.Drawing.Color.Red;
                            LabelConfirm.Visible = true;
                        }
                    }

                    else
                    {
                        Response.Redirect("PlanningMain.aspx");
                    }
                }

                else
                {
                    Response.Redirect("Login.aspx");
                }
            }


        }

        private void RefreshGridView(List<TourGuides> list)
        {
            // using gridview to bind to the list of employee objects
            GvTD.DataSource = list;
            GvTD.DataBind();
        }

        protected void LoadApplications()
        {
            TourGuides td = new TourGuides();
            List<TourGuides> list = td.getTourGuide(roleGuide);
            RefreshGridView(list);
        }

        protected void GvTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvTD.SelectedRow;
            int updCnt;
            string newRole = "User";
            string currRole = (string)ViewState["CurrRole"];

            TourGuides td = new TourGuides();
            updCnt = td.UpdTdbyIDDenied(newRole, row.Cells[0].Text);

            if (updCnt == 1)
            {

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("OOADPProject1@gmail.com", "ILoveChickenRice");
                MailMessage mailMessage = new MailMessage("OOADPPROJECT1@gmail.com", row.Cells[3].Text, "Revoke of your tour guide role", "Unfortunately, we have choosen to revoke your role of tour guide due to reasons." + Environment.NewLine + Environment.NewLine + "If you have any further enquiries, please email us at OOADPProject1@gmail.com." + Environment.NewLine + Environment.NewLine + "With regards, The SreX team.");

                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
                Response.Redirect("existingTourGuidess.aspx");
            }
            else
            {
                LabelConfirm.Text = "Error has occured";
            }
        }
    }
}