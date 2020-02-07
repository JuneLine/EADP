using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
//using QRCoder;
using SREX.BLL;

namespace SREX
{
    public partial class GuidedPurchaseHist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (Session["UserId"] != null)
            {
                List<GuideTour> Hist;
                string Id = Session["UserId"].ToString();

                GuideTour rows = new GuideTour();
                Hist = rows.GetHist(Id);
                DataListHist.DataSource = Hist;
                DataListHist.DataBind();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void BtnBackToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuidedTour.aspx");
        }


        protected void openModalQR(object sender, EventArgs e)
        {
            HtmlButton btn = (HtmlButton)sender;
            //QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode("http://localhost:50743/GuidedQRPage?PurchaseId=" + btn.Attributes["Value"], QRCodeGenerator.ECCLevel.Q);
            //QRCode qrCode = new QRCode(qrCodeData);
            System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
            imgBarCode.Height = 400;
            imgBarCode.Width = 400;
            //using (Bitmap bitMap = qrCode.GetGraphic(20))
            //{
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //        byte[] byteImage = ms.ToArray();
            //        imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
            //    }
            //    QRPanel.Controls.Add(imgBarCode);
            //    QRDiv.Visible = true;
            //}
        }

        protected void closePanel_ServerClick(object sender, EventArgs e)
        {
            ////QRDiv.Visible = false;
        }

        protected void showData_ServerClick(object sender, EventArgs e)
        {
            List<GuideTour> Listing1;
            List<GuideTour> Listing2;

            GuideDetails.Visible = true;

            HtmlButton btn = (HtmlButton)sender;
            string tourId = btn.Attributes["value"].ToString();

            GuideTour row = new GuideTour();
            Listing1 = row.GetOne(tourId);
            Listing2 = row.GetOneInfo(tourId);
            DataListInfo.DataSource = Listing2;
            DataListInfo.DataBind();

            foreach (GuideTour items in Listing1)
            {
                lbltourname.Text = items.tourName.ToString();
                lbltourDate.Text = items.Date.ToString();
                lblMeetUp.Text = items.meetUpTime.ToString() + " @ " + items.meetUpLocation.ToString();
            }

        }

        protected void closeDetailPanel_ServerClick(object sender, EventArgs e)
        {
            GuideDetails.Visible = false;
        }
    }
}