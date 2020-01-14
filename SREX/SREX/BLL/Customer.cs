using System;
using SREX.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.Net.Mail;

namespace SREX.BLL
{
    public class Customer
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public string Gender { get; set; }
        public string Passnum { get; set; }
        public string Dob { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Id { get; set; }

        public Customer()
        {

        }

        public Customer(string User, string Pass, string Gender, string Passnum, string DOB, string Email)
        {
            this.User = User;
            this.Pass = MD5Hash(Pass);
            this.Gender = Gender;
            this.Passnum = Passnum;
            this.Dob = DOB;
            this.Email = Email;
            this.Id = Guid.NewGuid().ToString();
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

        public int CreateUser()
        {
            CustomerDAO Cust = new CustomerDAO();
            int result = Cust.InsertUser(this);
            return result;
        }

        public List<Customer> ValidateUser(string NRIC, string Email)
        {
            CustomerDAO Cust = new CustomerDAO();
            List<Customer> Custer = Cust.ValidateExisitingUser(NRIC, Email);
            return Custer;
        }

        public Customer LoginGetRole(string Email, string Password)
        {
            CustomerDAO Cust = new CustomerDAO();
            Customer CustomerStuff = Cust.UserLoginData(Email, MD5Hash(Password));
            return CustomerStuff;
        }

        public Customer getLoggedInData(string id)
        {
            CustomerDAO Cust = new CustomerDAO();
            Customer CustomerStuff = Cust.getLoggedInDetails(id);
            return CustomerStuff;
        }

        public List<string> statusChangedPW(string userId, string email, string oldPw, string newPw)
        {
            List<string> Status = new List<string>();
            CustomerDAO Cust = new CustomerDAO();
            int result = Cust.changeLoggedInPW(userId, MD5Hash(oldPw), MD5Hash(newPw));
            if (result == 1)
            {
                Status.Add("Password changed successfully!");
                Status.Add("green");

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("OOADPProject1@gmail.com", "ILoveChickenRice");

                MailMessage mailMessage = new MailMessage("OOADPProject1@gmail.com", email, "Request Of Change Of Password", "This Email Is Sent For Verification That Somebody Has Requested A Password Change Using This Email,"+Environment.NewLine+"If You Have Not Done So Please Contact Us Immediately."+Environment.NewLine+"Do Not Reply To This Email");

                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
            else
            {
                Status.Add("Password entered incorrect!");
                Status.Add("red");
            }
            return Status;
        }
    }
}