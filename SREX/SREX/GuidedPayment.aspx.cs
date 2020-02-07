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
                List<GuideTour> Listing;

                string id = Request.QueryString["tourId"];

                GuideTour Tour = new GuideTour();
                Listing = Tour.GetOne(id);
                DataListTourInfo.DataSource = Listing;
                DataListTourInfo.DataBind();

                foreach (GuideTour item in Listing)
                {
                    AdultPerTicket.Text = item.AdultCost.ToString();
                    ChildPerTicket.Text = item.ChildCost.ToString();
                    SeniorPerTicket.Text = item.SeniorCost.ToString();
                }

                tbUserName.Text = Session["Username"].ToString();
                tbUserEmail.Text = Session["Email"].ToString();
                
            }
        }

        protected void btnBuyTicket_Click(object sender, EventArgs e)
        {
            string purchId = "";
            string userId = Session["userId"].ToString();
            string tourId = Request.QueryString["tourId"].ToString();
            string Date = DateTime.Now.ToShortDateString();
            GuideTour insertRecord = new GuideTour(purchId, Date, tbUserName.Text, tbUserEmail.Text, tbUserContact.Text, int.Parse(tbAdultQuantity.Text), int.Parse(tbChildQuantity.Text), int.Parse(tbSeniorQuantity.Text), Convert.ToDecimal(lblFinalAmount.Text), userId, tourId);
            int result = insertRecord.CreatePurchases();
            // add Marcus's PayPal Sandbox
            if (result == 1)
            {
                Response.Redirect("GuidedTour.aspx");
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
    }
}