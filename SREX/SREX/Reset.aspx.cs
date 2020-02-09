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
            if (tbEmail.Text != "" && codebox.Visible == false)
            {
                Customer Cust = new Customer();
                string UserId = Cust.getUserIdFromEmailReset(tbEmail.Text);
                if (UserId != null)
                {
                    RequiredFieldValidatorCode.Enabled = true;

                    Cust.createOTP(UserId, tbEmail.Text);

                    emailbox.Visible = false;
                    codebox.Visible = true;
                }
                else
                {
                    RegularExpressionValidatorEmail.IsValid = false;
                }
            }
            else if (tbEmail.Text != null && tbCode.Text != null && emailbox.Visible == false)
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
                    RequiredFieldValidatorCode.IsValid = false;
                }
            }
        }
    }
}