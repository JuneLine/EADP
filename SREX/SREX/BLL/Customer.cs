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
        public string VerifyCode { get; set; }

        public string Code { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }

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
            this.VerifyCode = RandomString(50);
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

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public int CreateUser()
        {
            CustomerDAO Cust = new CustomerDAO();
            int result = Cust.InsertUser(this);
            if (result == 1)
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("OOADPProject1@gmail.com", "ILoveChickenRice");

                MailMessage mailMessage = new MailMessage("OOADPProject1@gmail.com", this.Email, "Registration", "Thanks for registering on SreX Offical Website." + Environment.NewLine + Environment.NewLine + "Click here to activiate your account!" + Environment.NewLine + "http://localhost:50743/Verify?id=" + this.Code);

                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
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

        public string getUserIdFromEmailReset(string email)
        {
            CustomerDAO Cust = new CustomerDAO();
            string custId = Cust.checkEmailExist(email);
            return custId;
        }

        public int createOTP(string userId, string email)
        {
            int resultCode = 200;
            int SixPinNum = 0;

            Random r = new Random();
            string num = (r.Next(000000, 1000000)).ToString("D6");

            CustomerDAO Cust = new CustomerDAO();
            string foundCode = Cust.returnOTPCodeIfFound(userId);
            if (foundCode != null)
            {
                SixPinNum = Convert.ToInt32(foundCode);
            }
            else
            {
                resultCode = 1;
                SixPinNum = Convert.ToInt32(num);
            }

            if (resultCode != 200)
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("OOADPProject1@gmail.com", "ILoveChickenRice");

                MailMessage mailMessage = new MailMessage("OOADPProject1@gmail.com", email, "Password Change", "The Code To Change Your Password Is"+Environment.NewLine+SixPinNum);

                try
                {
                    smtpClient.Send(mailMessage);
                    resultCode = Cust.createOTPCode(userId, num);

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
            return resultCode;
        }

        public int redeemOTP(string userId, string code, string email)
        {
            CustomerDAO Cust = new CustomerDAO();
            string Id = Cust.checkOTPCode(userId, code);
            if (Id != "")
            {
                string newPw = RandomString(20);
                Cust.changeForgotPassword(userId, MD5Hash(newPw));
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("OOADPProject1@gmail.com", "ILoveChickenRice");

                MailMessage mailMessage = new MailMessage("OOADPProject1@gmail.com", email, "Password Reset Successful", "Your new password is"+Environment.NewLine+newPw);

                try
                {
                    smtpClient.Send(mailMessage);
                    return 1;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
            return 0;
        }
    }
}