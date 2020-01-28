using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class Reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCfmEmail_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != "" && codebox.Style["display"] == "none")
            {
                Customer Cust = new Customer();
                string UserId = Cust.getUserIdFromEmailReset(tbEmail.Text);
                if (UserId != null)
                {
                    RequiredFieldValidatorCode.Enabled = true;

                    Cust.createOTP(UserId, tbEmail.Text);

                    emailbox.Style["display"] = "none";
                    codebox.Style["display"] = "block";

                    Status.Text = "";
                }
                else
                {
                    Status.Text = "Invalid Email!";
                    Status.ForeColor = System.Drawing.Color.Red;
                }
            }
            else if (tbEmail.Text != null && tbCode.Text != null && emailbox.Style["display"] == "none")
            {
                Customer Cust = new Customer();
                string UserId = Cust.getUserIdFromEmailReset(tbEmail.Text);
                int result = Cust.redeemOTP(UserId, tbCode.Text, tbEmail.Text);
                if (result == 1)
                {
                    Response.Redirect("/Login");
                }
                else
                {
                    Status.Text = "Invalid Code";
                    Status.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}