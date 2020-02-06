using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class GuidedQRpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (Session["UserId"].ToString() != null)
            {
                if (Session["role"].ToString() == "Admin")
                {
                    string tourid;
                    List<GuideTour> Listing;
                    List<GuideTour> Listing2;
                    List<GuideTour> Listing3;

                    GuideTour rows = new GuideTour();
                    Listing = rows.GetOneHist(Request.QueryString["PurchaseId"].ToString(), Session["UserId"].ToString());

                    foreach (GuideTour item in Listing)
                    {
                        lblUserName.Text = item.UserName.ToString();
                        lblContact.Text = item.UserContact.ToString();
                        lblPayment.Text = item.PaymentAmount.ToString();
                        lblDatePurch.Text = item.Date.ToString();
                        lblAQuant.Text = item.AdultQuantity.ToString();
                        lblCQuant.Text = item.ChildQuantity.ToString();
                        lblSQuant.Text = item.SeniorQuantity.ToString();

                        tourid = item.tourId.ToString();
                        Listing2 = rows.GetOne(tourid);
                        DataListInfo1.DataSource = Listing2;
                        DataListInfo1.DataBind();
                        Listing3 = rows.GetOneInfo(tourid);
                        DataListInfo2.DataSource = Listing3;
                        DataListInfo2.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("GuidedPurchaseHist.aspx");
                    Response.Write("<script>alert('You Have No Access to This')</script>");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
                Response.Write("<script>alert('Please Login')</script>");
            }
        }
    }
}