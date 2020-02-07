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
    public partial class PlanningMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<TouristAttractions> AttractionList;

                if (Session["UserId"] == null)
                {
                    LabelConfirm.Visible = false;
                    forAdminApply.Visible = false;
                    forTourGuide.Visible = false;
                    AddNewAttraction.Visible = false;
                    btnAddPlace.Style["display"] = "none";
                }
                else if (Session["role"].ToString() == "Guide")
                {
                    LabelConfirm.Visible = false;
                    forAdminApply.Visible = false;
                    AddNewAttraction.Visible = false;
                    forTourGuide.Visible = true;
                }

                else if (Session["role"].ToString() == "Admin")
                {
                    LabelConfirm.Visible = false;
                    forAdminApply.Visible = true;
                    AddNewAttraction.Visible = true;
                    forTourGuide.Visible = true;
                    btnAddPlace.Style["display"] = "inline-block";
                }
                else
                {
                    AddNewAttraction.Visible = false;
                    LabelConfirm.Visible = false;
                    forAdminApply.Visible = false;
                    forTourGuide.Visible = false;
                    btnAddPlace.Style["display"] = "none";
                }

                TouristAttractions Attactions = new TouristAttractions();
                AttractionList = Attactions.GetAll();
                DataListAttractions.DataSource = AttractionList;
                DataListAttractions.DataBind();
            }
        }

        protected void AddNewAttraction_Click(object sender, EventArgs e)
        {
            string Picture;
            string Name = AttractionName.Text;
            string URL = AttractionsURL.Text;
            string Description = AttractionDescription.Text;
            string Tag = AttractionTags.Text;
            string Price = AttractionPrice.Text;

            if (AttractionPicture.HasFile)
            {
                Picture = Path.GetFileName(AttractionPicture.FileName);
                string ext = System.IO.Path.GetExtension(AttractionPicture.FileName);
                if (ext == ".jpg" || ext == ".png" || ext == ".jfif")
                {
                    string path = Server.MapPath("~/Pictures/");
                    AttractionPicture.SaveAs(path + AttractionPicture.FileName);

                    TouristAttractions Place = new TouristAttractions(Guid.NewGuid().ToString(), Name, Picture, URL, Description, Tag, Price);
                    int result = Place.CreateAttractions();

                    if (result == 1)
                    {
                        Response.Redirect("PlanningMain.aspx");
                    }
                }
            }
        }

        protected void EditAttraction_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["AttractionId"];
            Response.Redirect("EditAttraction?AttractionId =" + id);
        }

        protected void ApplyGuide_Click(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (FileUpload1.HasFile)
                {
                    string filename = Path.GetFileName(FileUpload1.FileName);
                    string ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                    if (ext == ".docx")
                    {
                        string path = Server.MapPath("~/Uploads/");
                        FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                        int updCnt;
                        string newStatus = "Applying";
                        string currStatus = (string)ViewState["CurrStatus"];

                        SelfPlan td = new SelfPlan();

                        updCnt = td.UpdTDbyUserId(newStatus, Session["UserId"].ToString(), filename);
                        
                        if (updCnt == 1)
                        {
                            LabelError.Text = "Your application is now under review";
                            LabelError.ForeColor = Color.Green;
                        }
                    }
                    else
                    {
                        LabelError.Text = "Please ensure that your resume is a .docx file";
                        LabelError.ForeColor = Color.Red;
                        LabelError2.Text = "Please ensure that your resume is a .docx file";
                        LabelError2.ForeColor = Color.Red;

                    }
                }

                else
                {

                    LabelError.Text = "Please upload your resume";
                    LabelError.ForeColor = Color.Red;
                    LabelError2.Text = "Please upload your resume";
                    LabelError2.ForeColor = Color.Red;
                }
            }
        }
    }
}