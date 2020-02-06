using System;
using SREX.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;

namespace SREX
{
    public partial class Login : System.Web.UI.Page
    {
        Customer Cust = new Customer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["alertMessage"]!=null)
                {
                    showInfo.Text = Session["alertMessage"].ToString();
                    showInfo.ForeColor = System.Drawing.Color.Red;
                }
                
            }
        }

        protected void registerSubmit_Click(object sender, EventArgs e)
        {
            if (registerPassword.Text.Equals(confirmPassowrd.Text) && registerPassword.Text.Length != 0)
            {
                List<Customer> PeopleStuff = Cust.ValidateUser(passportId.Text, emailAddress.Text);
                if (!PeopleStuff.Any())
                {
                    Cust = new Customer(registerUsername.Text, registerPassword.Text, ddlGender.Text, passportId.Text, dob.Text, emailAddress.Text.ToLower());
                    int result = Cust.CreateUser();
                    if (result == 1)
                    {
                        showInfo.Text = "Register Success! Please check your email!";
                        showInfo.ForeColor = System.Drawing.Color.Green;
                        registerUsername.Text = "";
                        emailAddress.Text = "";
                        ddlGender.SelectedValue = "Male";
                        passportId.Text = "";
                        dob.Text = "";
                    }
                }
                else
                {
                    showInfo.Text = "Existing User!";
                    showInfo.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                showInfo.Text = "Password and Confirm Password do not match.";
                showInfo.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = Email.Text.ToLower();
            string password = loginPassword.Text;

            Customer CustomerData = Cust.LoginGetRole(email, password);

            if (CustomerData != null)
            {
                Session["Role"] = CustomerData.Role;
                Session["Email"] = CustomerData.Email;
                Session["Username"] = CustomerData.User;
                Session["UserId"] = CustomerData.Id;
                Response.Redirect("Default.aspx");
            }
            else
            {
                showInfo.Text = "Your email or password is wrong.";
                showInfo.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}