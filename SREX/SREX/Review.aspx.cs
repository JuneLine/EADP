using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class Review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (!IsPostBack)
            {
                List<Reviews> AllComments;
                string user;
                if (Session["UserId"] == null)
                {
                    user = "";
                    promptlogin.Style["display"] = "block";
                    btnAddComment.Visible = false;

                    Reviews get = new Reviews();
                    AllComments = get.GetAllComments(user);
                    dlComments.DataSource = AllComments;
                    dlComments.DataBind();
                }
                else
                {
                    promptlogin.Style["display"] = "none";
                    btnAddComment.Visible = true;
                    tbName.Text = Session["Username"].ToString();

                    user = Session["UserId"].ToString();
                    Reviews get = new Reviews();
                    AllComments = get.GetAllComments(user);
                    dlComments.DataSource = AllComments;
                    dlComments.DataBind();

                }
            }
        }

        protected void btnComment_Click(object sender, EventArgs e)
        {
            string id = "";
            string now = DateTime.Now.ToString("d");
            Reviews Comment = new Reviews(id, Session["UserId"].ToString(), tbName.Text.ToString(), tbComment.Text.ToString(), now, Convert.ToDecimal(rating.Value.ToString()));
            int result = Comment.CreateComment();
            if (result == 1)
            {
                Response.Redirect("Review.aspx");
            }
        }
    }
}