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
                int updCnt;
                string newStatus = "Applying";
                string currStatus = (string)ViewState["CurrStatus"];

                SelfPlan td = new SelfPlan();
                updCnt = td.UpdTDbyUserId(newStatus, Session["UserId"].ToString());
                if (updCnt == 1)
                {
                    LabelConfirm.Visible = true;
                    LabelConfirm.Text = "Your application is now under review !";
                }
                else
                {
                    LabelConfirm.Visible = true;
                    LabelConfirm.Text = "Failed to apply for tour guide";
                }
            }
        }
    }
}