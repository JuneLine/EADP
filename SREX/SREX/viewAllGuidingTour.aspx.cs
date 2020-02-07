using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class viewAllGuidingTours : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<SelfPlan> List;
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals("Admin"))
                    {
                        string id = Session["UserId"].ToString();
                        SelfPlan plan = new SelfPlan();
                        List = plan.getAllPlansByGuideId(id);
                        DataListPlans.DataSource = List;
                        DataListPlans.DataBind();

                    }

                    else if (Session["role"].Equals("Guide"))
                    {

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


    }
}