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
                    btnAddPlace.Style["display"] = "none";
                }
                else
                {
                    if (Session["role"].ToString() == "Admin")
                    {
                        btnAddPlace.Style["display"] = "inline-block";
                    }
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
            if (AttractionPicture.HasFile)
            {
                Picture = Path.GetFileName(AttractionPicture.FileName);
                string ext = System.IO.Path.GetExtension(AttractionPicture.FileName);
                if (ext == ".jpg" || ext == ".png" || ext == ".jfif")
                {
                    string path = Server.MapPath("~/Pictures/");
                    AttractionPicture.SaveAs(path + AttractionPicture.FileName);

                    TouristAttractions Place = new TouristAttractions(Guid.NewGuid().ToString(), Name, Picture, URL, Description);
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
    }
}