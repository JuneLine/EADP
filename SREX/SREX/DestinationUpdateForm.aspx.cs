using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;

namespace SREX
{
    public partial class DestinationUpdateForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["uniqueId"] != null)
                {
                    // Assign session variables for customer id, name and account labels
                    LbDestination.Text = Session["uniqueId"].ToString();

                    int newId = int.Parse(Session["UniqueId"].ToString());
                    Destination td = new Destination();
                    td = td.GetTDByUniqueId(newId);

                    LbDestination.Text = td.DestinationName.ToString();
                    TbDescription.Text = td.Description.ToString();
                    TbPrice.Text = td.Price.ToString();
                    TbTag.Text = td.Tag.ToString();

                    ViewState["currDescription"] = td.Description.ToString(); 
                }
                else
                {
                    Response.Redirect("AdminDestination.aspx");
                }
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            int updCnt;
            string newPictureName = "";
            string currPictureName = (string)ViewState["CurrPicture"];
            string newDescription = "";
            string currDescription = (string)ViewState["currDescription"];
            string newPrice = "";
            string currPrice = (string)ViewState["currPrice"];
            string newTag = "";
            string currTag = (string)ViewState["currTag"];

            if (TbDescription.Text != "")
            {
                newDescription = TbDescription.Text.ToString();
                newPrice = TbPrice.Text.ToString();
                newTag = TbTag.Text.ToString();
                if (FileLocation.HasFile)
                {
                    string filename = Path.GetFileName(FileLocation.FileName);
                    string ext = System.IO.Path.GetExtension(FileLocation.FileName);

                    if (ext == ".jpg" || ext == ".png")
                    {
                        string path = Server.MapPath("~/Pictures/");
                        FileLocation.SaveAs(Server.MapPath("~/Pictures/" + FileLocation.FileName));

                        Destination td = new Destination();
                        updCnt = td.UpdTDbyDestination(TbDescription.Text.ToString(), filename, int.Parse(Session["UniqueId"].ToString()), TbPrice.Text.ToString(), TbTag.Text.ToString());

                        if (updCnt == 1)
                        {
                            LblResult.Text = "Updated!";
                            LblResult.ForeColor = Color.Green;
                        }
                        else
                        {
                            LblResult.Text = "Unable to update";
                            LblResult.ForeColor = Color.Red;

                        }
                    }

                    else
                    {
                        LabelError.Text = "Please upload only png and jpg files";
                        LabelError.ForeColor = Color.Red;
                    }
                }

                else
                {
                    Destination td = new Destination();
                    updCnt = td.UpdTDbyDestination(TbDescription.Text.ToString(), Session["PictureName"].ToString() , int.Parse(Session["UniqueId"].ToString()), TbPrice.Text.ToString(), TbTag.Text.ToString());

                    if (updCnt == 1)
                    {
                        LblResult.Text = "Description updated!";
                        LblResult.ForeColor = Color.Green;
                    }
                    else
                    {
                        LblResult.Text = "Unable to update";
                        LblResult.ForeColor = Color.Red;

                    }
                }
            }

            else
            {
                LblResult.Text = "Please enter a description";
                LblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDestination.aspx");
        }
    }
}