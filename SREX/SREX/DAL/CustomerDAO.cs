using System;
using SREX.BLL;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SREX.DAL
{
    public class CustomerDAO
    {
        private static Customer Read(SqlDataReader dr)
        {
            string User = dr["Username"].ToString();
            string Pass = dr["Password"].ToString();
            string Gen = dr["Gender"].ToString();
            string PPort = dr["PassportID"].ToString();
            string Dob = dr["DOB"].ToString();
            string Email = dr["EmailAddr"].ToString();
            string Role = dr["Role"].ToString();
            string Id = dr["Id"].ToString();

            Customer Value = new Customer
            {
                User = User,
                Pass = Pass,
                Gender = Gen,
                Passnum = PPort,
                Dob = Dob,
                Email = Email,
                Role = Role,
                Id = Id,
            };

            return Value;
        }

        public int InsertUser(Customer Cust)
        {
            int result = 0;
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO Users (Id,Username, Password, Gender, PassportID, DOB, EmailAddr, Role) 
VALUES (@paraId, @paraName, @paraPass, @paraGender, @paraPassPort, @paraDOB, @paraEmail, @paraUser)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", Cust.Id);
            SQLCmd.Parameters.AddWithValue("@paraName", Cust.User);
            SQLCmd.Parameters.AddWithValue("@paraPass", Cust.Pass);
            SQLCmd.Parameters.AddWithValue("@paraGender", Cust.Gender);
            SQLCmd.Parameters.AddWithValue("@paraPassPort", Cust.Passnum);
            SQLCmd.Parameters.AddWithValue("@paraDOB", Cust.Dob);
            SQLCmd.Parameters.AddWithValue("@paraEmail", Cust.Email);
            SQLCmd.Parameters.AddWithValue("@paraUser", "User");
  
            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public List<Customer> ValidateExisitingUser(string NRIC, string Email)
        {
            List<Customer> Stuff = new List<Customer>();

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"SELECT * FROM Users WHERE PassportID = @paraPassPort OR EmailAddr = @paraEmail";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            SQLCmd.Parameters.AddWithValue("@paraPassPort", NRIC);
            SQLCmd.Parameters.AddWithValue("@paraEmail", Email);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                Customer Td = Read(dr);
                Stuff.Add(Td);
            }

            Connection.Close();

            return Stuff;
        }

        public Customer UserLoginData(string Email, string Password)
        {
            Customer Stuff = null;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"SELECT * FROM Users WHERE Password = @paraPassWord";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            SQLCmd.Parameters.AddWithValue("@paraPassWord", Password);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            if (dr.Read())
            {
                Stuff = Read(dr);
            }
            Connection.Close();

            return Stuff;
        }
    }
}