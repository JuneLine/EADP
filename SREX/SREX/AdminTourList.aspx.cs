using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class AdminTourList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (!IsPostBack)
            {
                if(Session["UserId"] != null)
                {
                    if (Session["role"].ToString() == "Admin")
                    {
                        List<GuideTour> All;
                        GuideTour getrows = new GuideTour();
                        All = getrows.GetListTour();
                        dlListofTour.DataSource = All;
                        dlListofTour.DataBind();
                    }
                    else
                    {
                        Response.Redirect("Default.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void ButtonSearchName_Click(object sender, EventArgs e)
        {
            List<GuideTour> List;

            GuideTour Search = new GuideTour();
            List = Search.GetSearchList(SearchTour.Text);            
            dlListofTour.DataSource = List;
            dlListofTour.DataBind();
        }
    }
}