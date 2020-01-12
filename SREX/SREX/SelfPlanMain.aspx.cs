using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class SelfPlanMain : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Destination> allDestinations;
            Destination dest = new Destination();
            allDestinations = dest.GetAllDestination();
            DataList1.DataSource = allDestinations;
            DataList1.DataBind();

            if (!IsPostBack)
            {
                if (Session["role"] != null)
                {

                    if (Session["role"].Equals("Admin"))
                    {
                        forAdminOnly.Visible = true;
                    }

                    else
                    {
                        forAdminOnly.Visible = false;
                    }
                }

                else
                {
                    forAdminOnly.Visible = false;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["userId"] != null)
            {
                SelfPlan Hist = new SelfPlan(Session["userId"].ToString(), SelfPlanTitle.Text.ToString(), SelfPlanDate.Text.ToString(), RadioButtonHire.SelectedItem.ToString(),
                 DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(), DropDownList4.SelectedValue.ToString()
                 , DropDownList5.SelectedValue.ToString(), DropDownList6.SelectedValue.ToString(), DropDownList7.SelectedValue.ToString(), DropDownList8.SelectedValue.ToString()
                 , DropDownList9.SelectedValue.ToString(), DropDownList10.SelectedValue.ToString());

                int result = Hist.InsertHistory();

                if (result == 1)
                {
                    Response.Redirect("PlanningHistory.aspx");
                }
            }

            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void ButtonSearchName_Click(object sender, EventArgs e)
        {
            List<Destination> searchDestination;
            Destination dest = new Destination();
            searchDestination = dest.searchDestination(TbSearch.Text.ToString());
            DataList1.DataSource = searchDestination;
            DataList1.DataBind();
        }

        protected void ButtonAll_Click(object sender, EventArgs e)
        {
            List<Destination> allDestinations;
            Destination dest = new Destination();
            allDestinations = dest.GetAllDestination();
            DataList1.DataSource = allDestinations;
            DataList1.DataBind();
        }
    }
}