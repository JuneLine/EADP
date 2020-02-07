using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class AdminApplication : System.Web.UI.Page
    {
        string yes = "Applying";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["role"] != null)
                {
                    if (Session["role"].ToString() == "Admin")
                    {
                        LoadApplications();

                    }

                    else
                    {
                        Response.Redirect("PlanningMain.aspx");
                    }
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
            List<TourGuides> list = td.getApplications(yes);
            RefreshGridView(list);
        }

        protected void GvTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvTD.SelectedRow;
            confirmModal.Visible = true;
            LabelName.Text = row.Cells[1].Text;
            LabelUniqueId.Text = row.Cells[0].Text;
            LabelEmailAddr.Text = row.Cells[3].Text;
            LabelResumePath.Text = "~/Uploads/" + row.Cells[4].Text.ToString();
        }

        protected void Close_Click(object sender, EventArgs e)
        {
            confirmModal.Visible = false;
        }

        protected void ConfirmApplication_Click(object sender, EventArgs e)
        {
            GridViewRow row = GvTD.SelectedRow;
            int updCnt;
            string newRole = "Guide";
            string currRole = (string)ViewState["CurrRole"];

            TourGuides td = new TourGuides();
            updCnt = td.UpdTDbyID(newRole, row.Cells[0].Text);

            if (updCnt == 1)
            {
                Response.Redirect("existingTourGuides.aspx");
            }
            else
            {
                LabelConfirm.Text = "Error has occured";
            }
        }

        protected void downloadResume_Click(object sender, EventArgs e)
        {
            WebClient req = new WebClient();
            HttpResponse response = HttpContext.Current.Response;
            string filePath = LabelResumePath.Text;
            Response.ContentType = "doc/docx";
            Response.AddHeader("Content-Disposition", "attachment;filename=\"" + filePath + "\"");
            Response.TransmitFile(Server.MapPath(filePath));
            Response.End();
        }
    }
}
