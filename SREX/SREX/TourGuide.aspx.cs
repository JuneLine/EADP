using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string yes = "Pending";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["role"] != null)
                {

                    if (Session["role"].Equals("Admin"))
                    {
                        LoadHistory();
                    }

                    else
                    {
                        Response.Redirect("PlanningMain.aspx");
                    }
                }

                else
                {
                    Response.Redirect("PlanningMain.aspx");
                }
            }
        }

        private void RefreshGridView(List<SelfPlan> list)
        {
            // using gridview to bind to the list of employee objects
            GvTD.DataSource = list;
            GvTD.DataBind();
        }

        protected void LoadHistory()
        {
            SelfPlan td = new SelfPlan();
            List<SelfPlan> list = td.getTourGuided(yes);
            RefreshGridView(list);
        }

        protected void GvTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvTD.SelectedRow;
            Session["UniqueId"] = row.Cells[0].Text;
            Session["Hire"] = row.Cells[3].Text;
            Response.Redirect("TourGuideConfirmation.aspx");
        }
    }
}