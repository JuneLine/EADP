using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
