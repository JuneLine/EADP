using System;
using SREX.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class Customer
    {
        public string user { get; set; }
        public string pass { get; set; }
        public string gender { get; set; }
        public string passnum { get; set; }
        public string dob { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public Customer()
        {

        }

        public Customer(string User, string Pass, string Gender, string Passnum, string DOB, string Email)
        {
            this.user = User;
            this.pass = Pass;
            this.gender = Gender;
            this.passnum = Passnum;
            this.dob = DOB;
            this.email = Email;
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
    }
}