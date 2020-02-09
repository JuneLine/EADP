using SREX.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SREX
{
    public partial class GuidedPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["deleteMsg"] = null;
            if (!IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    List<GuideTour> Listing;

                    if (Request.QueryString["tourId"] != null)
                    {
                        int id = int.Parse(Request.QueryString["tourId"]);

                        GuideTour Tour = new GuideTour();
                        Listing = Tour.GetOne(id);
                        DataListTourInfo.DataSource = Listing;
                        DataListTourInfo.DataBind();

                        foreach (GuideTour item in Listing)
                        {
                            lbltourname.Text = item.tourName.ToString();
                            AdultPerTicket.Text = item.AdultCost.ToString();
                            ChildPerTicket.Text = item.ChildCost.ToString();
                            SeniorPerTicket.Text = item.SeniorCost.ToString();
                        }

                        tbUserName.Text = Session["Username"].ToString();
                        tbUserEmail.Text = Session["Email"].ToString();
                    }
                    else
                    {
                        Response.Redirect("GuidedTour.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                    Response.Write("<script>alert('Please Login')</script>");
                }
            }
        }

        protected void btnBuyTicket_Click(object sender, EventArgs e)
        {
            if (lblFinalAmount.Text != "0")
            {
                int purchId = 0;
                string userId = Session["userId"].ToString();
                int tourId = Int16.Parse(Request.QueryString["tourId"]);
                string Date = DateTime.Now.ToShortDateString();
                GuideTour insertRecord = new GuideTour(purchId, Date, tbUserName.Text, tbUserEmail.Text, tbUserContact.Text, int.Parse(tbAdultQuantity.Text), int.Parse(tbChildQuantity.Text), int.Parse(tbSeniorQuantity.Text), Convert.ToDecimal(lblFinalAmount.Text), userId, lbltourname.Text.ToString() ,tourId);
                int result = insertRecord.CreatePurchases();
                if (result == 1)
                {                    
                    Response.Redirect("GuidedPurchaseHist.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Please Fill In your Quantity')</script>");
            }

        }

        protected void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            GuideTour cal = new GuideTour();

            decimal adultcost = Convert.ToDecimal(AdultPerTicket.Text);
            int QuantityAdult = int.Parse(tbAdultQuantity.Text);
            decimal resultAdult = cal.CalculateCost(adultcost, QuantityAdult);

            lblAdultTotal.Text = resultAdult.ToString();

            decimal childcost = Convert.ToDecimal(ChildPerTicket.Text);
            int QuantityChild = int.Parse(tbChildQuantity.Text);
            decimal resultChild = cal.CalculateCost(childcost, QuantityChild);

            lblChildTotal.Text = resultChild.ToString();

            decimal seniorcost = Convert.ToDecimal(SeniorPerTicket.Text);
            int QuantitySenior = int.Parse(tbSeniorQuantity.Text);
            decimal resultSenior = cal.CalculateCost(seniorcost, QuantitySenior);

            lblSeniorTotal.Text = resultSenior.ToString();

            lblTotalAmount.Text = Math.Round((Convert.ToDecimal(lblAdultTotal.Text) + Convert.ToDecimal(lblChildTotal.Text) + Convert.ToDecimal(lblSeniorTotal.Text)), 2).ToString();

            decimal resultGST = Math.Round(cal.CalculateGST(Convert.ToDecimal(lblTotalAmount.Text)), 2);
            lblGST.Text = resultGST.ToString();
            decimal resultService = Math.Round(cal.CalculateService(Convert.ToDecimal(lblTotalAmount.Text)), 2);
            lblService.Text = resultService.ToString();

            lblFinalAmount.Text = Math.Round((Convert.ToDecimal(lblTotalAmount.Text) + Convert.ToDecimal(lblGST.Text) + Convert.ToDecimal(lblService.Text)), 2).ToString();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            tbAdultQuantity.Text = "0";
            tbChildQuantity.Text = "0";
            tbSeniorQuantity.Text = "0";

            lblAdultTotal.Text = "0";
            lblChildTotal.Text = "0";
            lblSeniorTotal.Text = "0";

            lblTotalAmount.Text = "0";
            lblService.Text = "0";
            lblGST.Text = "0";
            lblFinalAmount.Text = "0";
        }
    }
}