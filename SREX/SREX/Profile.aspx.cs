using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class Profile : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userId"] != null)
                {
                    Customer CustDetails = null;
                    Customer Cust = new Customer();
                    CustDetails = Cust.getLoggedInData(Session["UserId"].ToString());
                    Gender.Src = "/Pictures/" + CustDetails.Gender + ".png";
                    LabelName.Text = CustDetails.User;
                    LabelEmail.Text = CustDetails.Email;
                    LabelDOB.Text = CustDetails.Dob;
                    LabelPassN.Text = CustDetails.Passnum;
                }
                else
                {
                    Response.Redirect("/Login");
                }
            }
        }

        protected void ButtonSavePW_Click(object sender, EventArgs e)
        {
            Customer Cust = new Customer();
            List<string> StatusStuff = new List<string>();
            StatusStuff = Cust.statusChangedPW(Session["UserId"].ToString(), Session["Email"].ToString(), tbOldPW.Text, tbNewPW.Text);

            System.Diagnostics.Debug.WriteLine(StatusStuff[0]);

            LabelStatus.Text = StatusStuff[0];

            if (StatusStuff[1] == "red")
            {
                LabelStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if (StatusStuff[1] == "green")
            {
                LabelStatus.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}