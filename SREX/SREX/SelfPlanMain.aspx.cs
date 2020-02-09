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
            List<TouristAttractions> AttractionLists;
            TouristAttractions dest = new TouristAttractions();
            AttractionLists = dest.GetAll();
            DataList1.DataSource = AttractionLists;
            DataList1.DataBind();

            if (!IsPostBack)
            {
                if (Session["role"] != null)
                {

                    if (Session["role"].Equals("Admin"))
                    {
                        LabelNothing.Visible = false;
                    }

                    else
                    {
                        LabelNothing.Visible = false;
                    }
                }

                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Hiring = "Pending";
            string No = "N/A";
            if (Session["userId"] != null)
            {
                if (RadioButtonHire.SelectedIndex == 0)
                {
                    if (SelfPlanTitle.Text.ToString() == "")
                    {
                        if (SelfPlanDate.Text.ToString() == "")
                        {
                            LabeError.Text = "* Please choose a date";
                            LabeError.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            SelfPlan Hist = new SelfPlan(Session["userId"].ToString(), "Untitlted", SelfPlanDate.Text.ToString(), RadioButtonHire.SelectedItem.ToString(),
                             DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(), DropDownList4.SelectedValue.ToString()
                             , DropDownList5.SelectedValue.ToString(), DropDownList6.SelectedValue.ToString(), DropDownList7.SelectedValue.ToString(), DropDownList8.SelectedValue.ToString()
                             , DropDownList9.SelectedValue.ToString(), DropDownList10.SelectedValue.ToString(), Hiring, Session["UserName"].ToString());

                            int result = Hist.InsertHistory();

                            if (result == 1)
                            {
                                Response.Redirect("PlanningHistory.aspx");
                            }
                        }
                    }

                    else
                    {
                        if (SelfPlanDate.Text.ToString() == "")
                        {
                            LabeError.Text = "* Please choose a date";
                            LabeError.ForeColor = System.Drawing.Color.Red;

                        }

                        else
                        {
                            SelfPlan Hist = new SelfPlan(Session["userId"].ToString(), SelfPlanTitle.Text.ToString(), SelfPlanDate.Text.ToString(), RadioButtonHire.SelectedItem.ToString(),
                             DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(), DropDownList4.SelectedValue.ToString()
                             , DropDownList5.SelectedValue.ToString(), DropDownList6.SelectedValue.ToString(), DropDownList7.SelectedValue.ToString(), DropDownList8.SelectedValue.ToString()
                             , DropDownList9.SelectedValue.ToString(), DropDownList10.SelectedValue.ToString(), Hiring, Session["UserName"].ToString());

                            int result = Hist.InsertHistory();

                            if (result == 1)
                            {
                                Response.Redirect("PlanningHistory.aspx");
                            }
                        }
                    }
                } 
                else
                {
                    if (SelfPlanTitle.Text.ToString() == "")
                    {
                        if (SelfPlanDate.Text.ToString() == "")
                        {
                            LabeError.Text = "* Please choose a date";
                            LabeError.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            SelfPlan Hist = new SelfPlan(Session["userId"].ToString(), "Untitlted", SelfPlanDate.Text.ToString(), RadioButtonHire.SelectedItem.ToString(),
                             DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(), DropDownList4.SelectedValue.ToString()
                             , DropDownList5.SelectedValue.ToString(), DropDownList6.SelectedValue.ToString(), DropDownList7.SelectedValue.ToString(), DropDownList8.SelectedValue.ToString()
                             , DropDownList9.SelectedValue.ToString(), DropDownList10.SelectedValue.ToString(), No, Session["UserName"].ToString());

                            int result = Hist.InsertHistory();

                            if (result == 1)
                            {
                                Response.Redirect("PlanningHistory.aspx");
                            }
                        }
                    }

                    else
                    {
                        if (SelfPlanDate.Text.ToString() == "")
                        {
                            LabeError.Text = "* Please choose a date";
                            LabeError.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            SelfPlan Hist = new SelfPlan(Session["userId"].ToString(), SelfPlanTitle.Text.ToString(), SelfPlanDate.Text.ToString(), RadioButtonHire.SelectedItem.ToString(),
                             DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(), DropDownList4.SelectedValue.ToString()
                             , DropDownList5.SelectedValue.ToString(), DropDownList6.SelectedValue.ToString(), DropDownList7.SelectedValue.ToString(), DropDownList8.SelectedValue.ToString()
                             , DropDownList9.SelectedValue.ToString(), DropDownList10.SelectedValue.ToString(), No, Session["UserName"].ToString());

                            int result = Hist.InsertHistory();

                            if (result == 1)
                            {
                                Response.Redirect("PlanningHistory.aspx");
                            }
                        }
                    }
                }
            }

            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void ButtonSearchName_Click(object sender, EventArgs e)
        {
            List<TouristAttractions> searchDestination;
            TouristAttractions dest = new TouristAttractions();
            searchDestination = dest.searchDestination(TbSearch.Text.ToString());
            DataList1.DataSource = searchDestination;
            DataList1.DataBind();

            if (DataList1.Items.Count == 0)
            {
                LabelNothing.Text = "Oops, we cant seem to find what you are looking for";
                LabelNothing.ForeColor = System.Drawing.Color.Red;
                LabelNothing.Visible = true;
            }

            else
            {
                LabelNothing.Visible = false;
            }
        }

        protected void ButtonAll_Click(object sender, EventArgs e)
        {
            List<TouristAttractions> allDestinations;
            TouristAttractions dest = new TouristAttractions();
            allDestinations = dest.GetAllDestination();
            DataList1.DataSource = allDestinations;
            DataList1.DataBind();

            LabelNothing.Visible = false;
        }
    }
}