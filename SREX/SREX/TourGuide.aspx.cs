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
                List<SelfPlan> List;
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals("Admin"))
                    {
                        SelfPlan plan = new SelfPlan();
                        List = plan.getTourGuided(yes);
                        DataListPlans.DataSource = List;
                        DataListPlans.DataBind();

                        if (DataListPlans.Items.Count == 0)
                        {
                            LabelNothing.Text = "There are currently no plans for you to guide, please check back in abit!";
                            LabelNothing.ForeColor = System.Drawing.Color.Red;
                        }

                        else
                        {
                            LabelNothing.Visible = false;
                        }
                    }

                    else if (Session["role"].Equals("Guide"))
                    {
                        SelfPlan plan = new SelfPlan();
                        List = plan.getTourGuided(yes);
                        DataListPlans.DataSource = List;
                        DataListPlans.DataBind();

                        if (DataListPlans.Items.Count == 0)
                        {
                            LabelNothing.Text = "There are currently no plans for you to guide, please check back in abit!";
                            LabelNothing.ForeColor = System.Drawing.Color.Red;
                        }

                        else
                        {
                            LabelNothing.Visible = false;
                        }
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

        protected void ButtonSearchName_Click(object sender, EventArgs e)
        {
            List<SelfPlan> List;
            SelfPlan plan = new SelfPlan();
            List = plan.searchByTitle(TbSearch.Text.ToString());
            DataListPlans.DataSource = List;
            DataListPlans.DataBind();

            if (DataListPlans.Items.Count == 0)
            {
                LabelNothing.Visible = true;
                LabelNothing.Text = "There are no matching searches for the title " + TbSearch.Text.ToString();
                LabelNothing.ForeColor = System.Drawing.Color.Red;
            }

            else
            {
                LabelNothing.Visible = false;
            }
        }

        protected void ButtonAll_Click(object sender, EventArgs e)
        {
            List<SelfPlan> List;
            SelfPlan plan = new SelfPlan();
            List = plan.searchAll();
            DataListPlans.DataSource = List;
            DataListPlans.DataBind();
            LabelNothing.Text = "";
        }

        //protected void GvTD_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    GridViewRow row = GvTD.SelectedRow;
        //    Session["UniqueId"] = row.Cells[0].Text;
        //    Session["Hire"] = row.Cells[3].Text;
        //    Response.Redirect("TourGuideConfirmation.aspx");
        //}
    }
}