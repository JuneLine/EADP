﻿using System;
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

        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        protected void registerSubmit_Click(object sender, EventArgs e)
        {
            if (registerPassword.Text.Equals(confirmPassowrd.Text) && registerPassword.Text.Length != 0)
            {
                List<Customer> PeopleStuff = Cust.ValidateUser(passportId.Text, emailAddress.Text);
                if (!PeopleStuff.Any())
                {
                    string HashedPassW = MD5Hash(registerPassword.Text);

                    Cust = new Customer(registerUsername.Text, HashedPassW, ddlGender.Text, passportId.Text, dob.Text, emailAddress.Text.ToLower());
                    int result = Cust.CreateUser();
                    if (result == 1)
                    {
                        showInfo.Text = "Register Success! Please Login";
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

        protected void btnnLogin_Click(object sender, EventArgs e)
        {
            string email = Email.Text.ToLower();
            string password = MD5Hash(loginPassword.Text);

            Customer CustomerData = Cust.LoginGetRole(email, password);

            if (CustomerData != null)
            {
                Session["Role"] = CustomerData.Role;
                Session["Email"] = CustomerData.Email;
                Session["Username"] = CustomerData.User;
                Session["Id"] = CustomerData.Id;
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