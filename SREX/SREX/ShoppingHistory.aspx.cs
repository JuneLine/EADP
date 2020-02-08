//using QRCoder;
//using QRCoder;
using QRCoder;
using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class ShoppingHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;

            if (!IsPostBack)
            {
                if (Session["userId"] != null)
                {
                    Purchase History = new Purchase();
                    List<Purchase> HistoryList;
                    HistoryList = History.getBuyHistory(Session["userId"].ToString());
                    DataListPurchase.Visible = true;
                    DataListPurchase.DataSource = HistoryList;
                    DataListPurchase.DataBind();
                }
            }
        }

        protected void GoToPage_ServerClick(object sender, EventArgs e)
        {
            HtmlButton btn = (HtmlButton)sender;
            string s = btn.Attributes["Value"];

            CartItem cart = new CartItem();
            List<CartItem> cartItemList;
            cartItemList = cart.getSoldItemFromOrderId(s);
            Panel1.Visible = true;
            DataListPurchaseHistory.DataSource = cartItemList;
            DataListPurchaseHistory.DataBind();
        }

        protected void openModalQR(object sender, EventArgs e)
        {
            HtmlButton btn = (HtmlButton)sender;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("http://localhost:50743/Collection?OrderId=" + btn.Attributes["Value"], QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
            imgBarCode.Height = 400;
            imgBarCode.Width = 400;
            using (Bitmap bitMap = qrCode.GetGraphic(20))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] byteImage = ms.ToArray();
                    imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                }
                QR.Controls.Add(imgBarCode);
            }

            QRDiv.Visible = true;
        }

        protected void closeModalQR(object sender, EventArgs e)
        {

        }
    }
}