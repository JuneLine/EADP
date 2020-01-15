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
                    RequiredFieldValidatorEmail.Enabled = false;
                    RegularExpressionValidatorEmail.Enabled = false;
                    RequiredFieldValidatorCode.Enabled = true;

                    Cust.createOTP(UserId, tbEmail.Text);

                    emailbox.Style["display"] = "none";
                    codebox.Style["display"] = "block";
                }
            }
            else if (tbCode.Text != null && emailbox.Style["display"] == "none")
            {
                Customer Cust = new Customer();
                string UserId = Cust.getUserIdFromEmailReset(tbEmail.Text);
                Cust.redeemOTP(UserId, tbCode.Text, tbEmail.Text);
            }
        }
    }
}