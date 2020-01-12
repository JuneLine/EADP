using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class AdminDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] != null)
            {
                if (Session["role"].Equals("Admin"))
                {
                    LoadDestinations();
                }

                else
                {
                    Response.Redirect("SelfPlanMain.aspx");
                }
            }

            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void LoadDestinations()
        {
            Destination td = new Destination();
            List<Destination> list = td.GetAllDestination();
            RefreshGridView(list);
        }

        private void RefreshGridView(List<Destination> list)
        {
            // using gridview to bind to the list of employee objects
            GvTD.DataSource = list;
            GvTD.DataBind();
        }

        protected void BtnInsertDestination_Click(object sender, EventArgs e)
        {
            if (Session["role"] != null)
            {
                if (Session["role"].Equals("Admin"))
                {
                    if (FileLocation.HasFile)
                    {
                        string filename = Path.GetFileName(FileLocation.FileName);
                        string ext = System.IO.Path.GetExtension(FileLocation.FileName);
                        if (ext == ".jpg" || ext ==".png")
                        {
                            string path = Server.MapPath("~/Pictures/");
                            FileLocation.SaveAs(Server.MapPath("~/Pictures/" + FileLocation.FileName));

                            Destination dest = new Destination(TbDestination.Text.ToString(), filename, TbDescription.Text.ToString(), TbPrice.Text.ToString(), TbTag.Text.ToString());

                            int result = dest.InsertDestination();

                            if (result == 1)
                            {
                                Response.Redirect("SelfPlanMain.aspx");
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
                        LabelError.Text = "Please choose a picture";
                        LabelError.ForeColor = Color.Red;
                    }
                }

                else
                {
                    Response.Redirect("SelfPlanMain.aspx");   
                }
            }

            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void GvTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvTD.SelectedRow;
            Session["UniqueId"] = row.Cells[0].Text;
            Session["PictureName"] = row.Cells[2].Text;
            Response.Redirect("DestinationUpdateForm.aspx");
        }
    }
}