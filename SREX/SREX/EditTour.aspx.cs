using SREX.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class EditTour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (!IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    if (Session["role"].ToString() == "Admin")
                    {
                        List<GuideTour> Info;
                        List<GuideTour> Details;
                        if(Request.QueryString["tourId"] != "")
                        {
                            int id = int.Parse(Request.QueryString["tourId"]);
                            GuideTour row = new GuideTour();
                            Info = row.GetOne(id);
                            Details = row.GetOneInfo(id);

                            foreach (GuideTour item in Info)
                            {
                                tbTourName.Text = item.tourName.ToString();
                                originalDate.Text = item.Date.ToString();
                                tbTourCaption.Text = item.tourCaption.ToString();
                                DropDownListmeetTime.SelectedValue = item.meetUpTime.ToString();
                                tbLocation.Text = item.meetUpLocation.ToString();
                                tbAdultCost.Text = item.AdultCost.ToString();
                                tbChildCost.Text = item.ChildCost.ToString();
                                tbSeniorCost.Text = item.SeniorCost.ToString();
                                HiddenPictureName.Text = item.tourPic.ToString();
                                Limit.Value = item.Limit.ToString();
                            }

                            foreach (GuideTour item in Details)
                            {
                                DropDownListTime1.SelectedValue = item.Time1.ToString();
                                DropDownListTime2.SelectedValue = item.Time2.ToString();
                                DropDownListTime3.SelectedValue = item.Time3.ToString();
                                DropDownListTime4.SelectedValue = item.Time4.ToString();
                                DropDownListTime5.SelectedValue = item.Time5.ToString();
                                DropDownListTime6.SelectedValue = item.Time6.ToString();
                                DropDownListTime7.SelectedValue = item.Time7.ToString();
                                tbActivity1.Text = item.Activity1.ToString();
                                tbActivity2.Text = item.Activity2.ToString();
                                tbActivity3.Text = item.Activity3.ToString();
                                tbActivity4.Text = item.Activity4.ToString();
                                tbActivity5.Text = item.Activity5.ToString();
                                tbActivity6.Text = item.Activity6.ToString();
                                tbActivity7.Text = item.Activity7.ToString();
                            }
                        }
                        else
                        {
                            Response.Redirect("GuideTour.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("GuideTour.aspx");
                        Response.Write("<script>alert('You Have No Permission To Change The Details')</script>");
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                    Response.Write("<script>alert('Please Login')</script>");
                }
            }
        }

        protected bool CheckValid()
        {
            bool valid = true;

            if (tbTourName.Text == "" || tbLocation.Text == "" || tbSeniorCost.Text == "" || tbAdultCost.Text == "" || tbChildCost.Text == "")
            {
                valid = false;
            }
            if (tbActivity1.Text == null && tbActivity2.Text == null && tbActivity3.Text == null && tbActivity4.Text == null && tbActivity5.Text == null && tbActivity6.Text == null && tbActivity7.Text == null)
            {
                valid = false;
            }
            if (DropDownListmeetTime.SelectedValue == "NIL")
            {
                valid = false;
            }

            return valid;
        }

        protected void EditConfirm_Click(object sender, EventArgs e)
        {
            bool valid = CheckValid();
            if (valid)
            {
                GuideTour Info1 = new GuideTour();
                GuideTour Info2 = new GuideTour();
                int id = int.Parse(Request.QueryString["tourId"]);

                string Picture;
                if (FileTourPicture.HasFile)
                {
                    Picture = Path.GetFileName(FileTourPicture.FileName);
                    string ext = System.IO.Path.GetExtension(FileTourPicture.FileName);
                    if (ext == ".jpg" || ext == ".png" || ext == ".jfif")
                    {
                        string path = Server.MapPath("~/Pictures/");
                        FileTourPicture.SaveAs(path + FileTourPicture.FileName);
                    }
                }
                else
                {
                    Picture = HiddenPictureName.Text.ToString();
                }

                string dateOfTour;
                if (tbDateOfTour.Text == ""){
                    dateOfTour = originalDate.Text;                    
                }
                else
                {
                    DateTime DDay = DateTime.ParseExact(tbDateOfTour.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    dateOfTour = DDay.ToString("dd/MM/yyyy");
                }

                int result1 = Info1.UpdateGuideTour(id, tbTourName.Text.ToString(), Picture, tbTourCaption.Text.ToString(), dateOfTour, DropDownListmeetTime.SelectedValue.ToString(), tbLocation.Text.ToString(), Convert.ToDecimal(tbAdultCost.Text), Convert.ToDecimal(tbChildCost.Text), Convert.ToDecimal(tbSeniorCost.Text), int.Parse(Limit.Value));

                if (DropDownListTime1.SelectedValue == "-Select-" || tbActivity1.Text == "")
                {
                    tbActivity1.Text = "NIL";
                }
                if (DropDownListTime2.SelectedValue == "-Select-" || tbActivity2.Text == "")
                {
                    tbActivity2.Text = "NIL";
                }
                if (DropDownListTime3.SelectedValue == "-Select-" || tbActivity3.Text == "")
                {
                    tbActivity3.Text = "NIL";
                }
                if (DropDownListTime4.SelectedValue == "-Select-" || tbActivity4.Text == "")
                {
                    tbActivity4.Text = "NIL";
                }
                if (DropDownListTime5.SelectedValue == "-Select-" || tbActivity5.Text == "")
                {
                    tbActivity5.Text = "NIL";
                }
                if (DropDownListTime6.SelectedValue == "-Select-" || tbActivity6.Text == "")
                {
                    tbActivity6.Text = "NIL";
                }
                if (DropDownListTime7.SelectedValue == "-Select-" || tbActivity7.Text == "")
                {
                    tbActivity7.Text = "NIL";
                }
                int result2 = Info2.UpdateGuideTourInfo(DropDownListTime1.SelectedValue.ToString(), tbActivity1.Text.ToString(), DropDownListTime2.SelectedValue.ToString(), tbActivity2.Text.ToString(), DropDownListTime3.SelectedValue.ToString(), tbActivity3.Text.ToString(), DropDownListTime4.SelectedValue.ToString(), tbActivity4.Text.ToString(), DropDownListTime5.SelectedValue.ToString(), tbActivity5.Text.ToString(), DropDownListTime6.SelectedValue.ToString(), tbActivity6.Text.ToString(), DropDownListTime7.SelectedValue.ToString(), tbActivity7.Text.ToString(), id);
                if (result1 == 1 && result2 == 1)
                {
                    Response.Redirect("GuidedTour.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Please Fill In The Field')</script>");
            }
        }
    }
}