using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class CommentEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            string id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                if(Session["UserId"] == null)
                {
                    Response.Redirect("Review.aspx");
                }
                else
                {
                    List<Reviews> one;
                    Reviews get = new Reviews();
                    one = get.GetOneComment(id);
                    foreach (Reviews item in one)
                    {
                        EditName.Text = item.username.ToString();
                        EditRating.Value = item.rating.ToString();
                        EditComment.Text = item.Comments.ToString();
                    }
                }
            }
        }

        public bool ValidateName()
        {
            bool valid = true;
            if (EditName.Text == "")
            {
                valid = false;
            }
            return valid;
        }

        public bool ValidateComment()
        {
            bool valid = true;
            if (EditComment.Text == "")
            {
                valid = false;
            }
            return valid;
        }

        public bool ValidateRating()
        {
            bool valid = true;
            if (EditRating.Value == "")
            {
                valid = false;
            }
            return valid;
        }

        protected void BackToReviews_Click(object sender, EventArgs e)
        {
            Response.Redirect("Review.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateName())
            {
                if (ValidateComment())
                {
                    if (ValidateRating())
                    {
                        string id = Request.QueryString["Id"];
                        Reviews Upd = new Reviews();
                        int result = Upd.EditComment(id, EditName.Text.ToString(), EditComment.Text.ToString(), Convert.ToDecimal(EditRating.Value.ToString()));
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
    }
}