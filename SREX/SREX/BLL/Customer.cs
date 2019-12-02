using System;
using SREX.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public Customer()
        {

        }

        public Customer(string User, string Pass, string Gender, string Passnum, string DOB, string Email)
        {
            this.User = User;
            this.Pass = Pass;
            this.Gender = Gender;
            this.Passnum = Passnum;
            this.Dob = DOB;
            this.Email = Email;
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