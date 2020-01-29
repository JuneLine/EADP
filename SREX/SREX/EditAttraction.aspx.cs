using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SREX.BLL;

namespace SREX
{
    public partial class EditAttraction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    if (Session["role"].ToString() != "Admin")
                    {
                        Response.Redirect("GuideTour.aspx");
                    }
                    else
                    {
                        string AttractionId = Request.QueryString["AttractionId"];
                        Session["AttractionId"] = AttractionId;
                        if (!string.IsNullOrEmpty(AttractionId))
                        {
                            TouristAttractions OneList = new TouristAttractions();
                            OneList = OneList.GetOne(AttractionId);
                            AttractionName.Text = OneList.AttractionName;
                            AttractionDescription.Text = OneList.Description;
                            AttractionsURL.Text = OneList.URL;
                            AttractionImage.ImageUrl = "~/Pictures/" + OneList.Picture;
                            AttractionTags.Text = OneList.Tags;
                            AttractionPrice.Text = OneList.Price;
                            Session["imageInfo"] = OneList.Picture;
                        }
                    }
                }
            }
        }

        protected void ChangePicture_Click(object sender, EventArgs e)
        {
            if (AttractionPicture.HasFile)
            {
                AttractionImage.ImageUrl = "Pictures/" + AttractionPicture.PostedFile.FileName.ToString();
                Session["imageInfo"] = AttractionPicture.FileName;
            }
        }

        protected void UpdateAttraction_Click(object sender, EventArgs e)
        {
            TouristAttractions Information = new TouristAttractions();
            string Attractid = Request.QueryString["AttractionId"];
            string AttractName = AttractionName.Text;
            string AttractURL = AttractionsURL.Text;
            string AttractDes = AttractionDescription.Text;
            string AttractTag = AttractionTags.Text;
            string AttractPrice = AttractionPrice.Text;
            int result = Information.UpdateAttractionInfo(Attractid, AttractName, Session["imageInfo"].ToString(), AttractURL, AttractDes, AttractTag, AttractPrice);
            if (result == 1)
            {
                Response.Redirect("PlanningMain.aspx");
            }
        }
    }
}