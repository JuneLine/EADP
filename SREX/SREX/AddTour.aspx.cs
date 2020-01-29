using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SREX.BLL;

namespace SREX
{
    public partial class AddTour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (Session["UserId"] != null)
            {
                if (Session["role"].ToString() != "Admin")
                {
                    Response.Redirect("GuideTour.aspx");
                }
            }
        }

        protected bool CheckValid()
        {
            bool valid = true;

            if (tbTourName.Text == "" || tbDateOfTour.Text == "" || FileTourPicture.HasFile == false || tbLocation.Text == "" || tbSeniorCost.Text == "" || tbAdultCost.Text == "" || tbChildCost.Text == "")
            {
                valid = false;
            }
            return valid;
        }

        protected void AddTourConfirmation_Click(object sender, EventArgs e)
        {
            bool valid = CheckValid();
            if (valid)
            {
                string id = "";
                string Picture;
                List<GuideTour> lookForID;
                if (Session["UserId"] != null)
                {
                    if (Session["role"].ToString() != "Admin")
                    {
                        Response.Redirect("GuideTour.aspx");
                    }
                    else
                    {
                        if (FileTourPicture.HasFile)
                        {
                            Picture = Path.GetFileName(FileTourPicture.FileName);
                            string ext = System.IO.Path.GetExtension(FileTourPicture.FileName);
                            if (ext == ".jpg" || ext == ".png" || ext == ".jfif")
                            {
                                string path = Server.MapPath("~/Pictures/");
                                FileTourPicture.SaveAs(path + FileTourPicture.FileName);

                                GuideTour Listing = new GuideTour(id, tbTourName.Text, FileTourPicture.FileName.ToString(), tbTourCaption.Text, tbDateOfTour.Text, DropDownListmeetTime.SelectedValue, tbLocation.Text, Convert.ToDecimal(tbAdultCost.Text), Convert.ToDecimal(tbChildCost.Text), Convert.ToDecimal(tbSeniorCost.Text));
                                int result1 = Listing.CreateTour();
                                if (result1 == 1)
                                {
                                    GuideTour row = new GuideTour();
                                    lookForID = row.GetOneID(tbTourName.Text, FileTourPicture.FileName.ToString(), tbTourCaption.Text);
                                    foreach (GuideTour item in lookForID)
                                    {
                                        string tourId = item.tourId.ToString();
                                        string tourInfoId = "";

                                        if (DropDownListTime1.SelectedValue == "-Select-" || tbActivity1.Text == null)
                                        {
                                            tbActivity1.Text = "NIL";
                                        }
                                        if (DropDownListTime2.SelectedValue == "-Select-" || tbActivity2.Text == null)
                                        {
                                            tbActivity2.Text = "NIL";
                                        }
                                        if (DropDownListTime3.SelectedValue == "-Select-" || tbActivity3.Text == null)
                                        {
                                            tbActivity3.Text = "NIL";
                                        }
                                        if (DropDownListTime4.SelectedValue == "-Select-" || tbActivity4.Text == null)
                                        {
                                            tbActivity4.Text = "NIL";
                                        }
                                        if (DropDownListTime5.SelectedValue == "-Select-" || tbActivity5.Text == null)
                                        {
                                            tbActivity5.Text = "NIL";
                                        }
                                        if (DropDownListTime6.SelectedValue == "-Select-" || tbActivity6.Text == null)
                                        {
                                            tbActivity6.Text = "NIL";
                                        }
                                        if (DropDownListTime7.SelectedValue == "-Select-" || tbActivity7.Text == null)
                                        {
                                            tbActivity7.Text = "NIL";
                                        }


                                        GuideTour TimeActivity = new GuideTour(tourInfoId, DropDownListTime1.Text.ToString(), tbActivity1.Text.ToString(), DropDownListTime2.SelectedValue.ToString(), tbActivity2.Text.ToString(), DropDownListTime3.SelectedValue.ToString(), tbActivity3.Text.ToString(), DropDownListTime4.SelectedValue.ToString(), tbActivity4.Text.ToString(), DropDownListTime5.SelectedValue.ToString(), tbActivity5.Text.ToString(), DropDownListTime6.SelectedValue.ToString(), tbActivity6.Text.ToString(), DropDownListTime7.SelectedValue.ToString(), tbActivity7.Text.ToString(), tourId);
                                        int result2 = TimeActivity.CreateTourInfo();
                                        if (result2 == 1)
                                        {
                                            Response.Redirect("GuidedTour.aspx");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Please Fill In The Fill')</script>");
            }                              
        }
    }
}