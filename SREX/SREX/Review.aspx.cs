using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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

        public bool ValidateName()
        {
            bool valid = true;
            if(tbName.Text == "")
            {
                valid = false;
            }
            return valid;
        }

        public bool ValidateComment()
        {
            bool valid = true;
            if (tbComment.Text == "")
            {
                valid = false;
            }
            return valid;
        }

        public bool ValidateRating()
        {
            bool valid = true;
            if (rating.Value == "")
            {
                valid = false;
            }
            return valid;
        }

        protected void btnComment_Click(object sender, EventArgs e)
        {                                    
            if (ValidateName())
            {
                if (ValidateComment())
                {
                    if (ValidateRating())
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
                    else
                    {
                        Response.Write("<script>alert('Please Fill In Your Ratings :)')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Please Fill In Your Comment :)')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please Fill In Your Name :)')</script>");
            }
        }

        protected void btnOpenEditPanel_Click(object sender, EventArgs e)
        {
            HtmlButton btn = (HtmlButton)sender;
            string id = btn.Attributes["value"];
            Response.Redirect("CommentEdit?Id=" + id);
        }
    }
}