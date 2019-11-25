using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SREX
{
    public partial class Login : System.Web.UI.Page
    {
        string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void registerSubmit_Click(object sender, EventArgs e)
        {
            if (registerPassword.Text.Equals(confirmPassowrd.Text))
            {
                SqlConnection con = new SqlConnection(mainconn);
                string userRegister = "Insert into Users values('" + registerUsername.Text + "','" + registerPassword.Text + "','" + ddlGender.Text + "','" + passportId.Text + "','"
                    + dob.Text + "','" + emailAddress.Text + "','Normal')";
                SqlCommand com = new SqlCommand(userRegister, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                showInfo.Text = "Register Success! Please Login";
                showInfo.ForeColor = System.Drawing.Color.Green;
                registerUsername.Text = "";
                emailAddress.Text = "";
                ddlGender.SelectedValue = "Male";
                passportId.Text = "";
                dob.Text = "";
            }
            else
            {
                showInfo.Text = "Password and Confirm Password do not match.";
                showInfo.ForeColor = System.Drawing.Color.Red;
            }
            
        }
    }
}