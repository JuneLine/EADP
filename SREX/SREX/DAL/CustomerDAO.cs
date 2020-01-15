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

            string sqlStmt = @"SELECT * FROM Users WHERE Password = @paraPassWord AND EmailAddr = @paraEmail";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            SQLCmd.Parameters.AddWithValue("@paraPassWord", Password);
            SQLCmd.Parameters.AddWithValue("@paraEmail", Email);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            if (dr.Read())
            {
                Stuff = Read(dr);
            }
            Connection.Close();

            return Stuff;
        }

        public Customer getLoggedInDetails(string id)
        {
            Customer Cust = null;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"SELECT * FROM Users WHERE Id = @paraId";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            SQLCmd.Parameters.AddWithValue("@paraId", id);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            if (dr.Read())
            {
                Cust = Read(dr);
            }
            Connection.Close();

            return Cust;
        }

        public int changeLoggedInPW(string userId, string oldPw, string newPw)
        {
            int result = 0;
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"UPDATE Users SET Password = @paranewPw WHERE Id = @paraId AND Password = @paraoldPw";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", userId);
            SQLCmd.Parameters.AddWithValue("@paraoldPw", oldPw);
            SQLCmd.Parameters.AddWithValue("@paranewPw", newPw);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public string checkEmailExist(string email)
        {
            string Id = null;
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"SELECT Id FROM Users WHERE EmailAddr = @paraEmail ";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraEmail", email);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr["Id"].ToString();
            }

            Connection.Close();

            return Id;
        }

        public int createOTPCode(string UserId, string code)
        {
            int result = 0;
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO PasswordReset (Id, UserId, Code, Time, Status) VALUES (@paraId, @paraUserId, @paraCode, @paraTime, @paraStatus)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@paraUserId", UserId);
            SQLCmd.Parameters.AddWithValue("@paraCode", code);
            SQLCmd.Parameters.AddWithValue("@paraTime", DateTime.Now);
            SQLCmd.Parameters.AddWithValue("@paraStatus", "Active");

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public string checkOTPCode(string userId, string code)
        {
            string custId = null;
            int result = 0;
            SqlCommand SQLCmd = new SqlCommand();
            SqlCommand SQLCmd1 = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"SELECT UserId FROM PasswordReset WHERE UserId = @paraId AND Code = @paraCode AND Status = @paraStatus AND Time < DATEADD(minute, 2, @paraTime)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", userId);
            SQLCmd.Parameters.AddWithValue("@paraCode", code);
            SQLCmd.Parameters.AddWithValue("@paraStatus", "Active");
            SQLCmd.Parameters.AddWithValue("@paraTime", DateTime.Now);

            string sqlStmt2 = @"UPDATE PasswordReset SET Status = @paraStatus WHERE UserId = @paraId AND Code = @paraCode AND Status = @paraStatus1";

            SQLCmd1 = new SqlCommand(sqlStmt2, Connection);
            SQLCmd1.Parameters.AddWithValue("@paraId", userId);
            SQLCmd1.Parameters.AddWithValue("@paraCode", code);
            SQLCmd1.Parameters.AddWithValue("@paraStatus", "Used");
            SQLCmd1.Parameters.AddWithValue("@paraStatus1", "Active");

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            if (dr.Read())
            {
                custId = dr["UserId"].ToString();
            }
            Connection.Close();

            Connection.Open();
            if (custId != null)
            {
                result = SQLCmd1.ExecuteNonQuery();
            }
            Connection.Close();

            if (result == 1)
            {
                return custId;
            }
            else
            {
                return "";
            }
        }

        public int changeForgotPassword(string userId, string newPw)
        {
            int result = 0;
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"UPDATE Users SET Password = @paranewPw WHERE Id = @paraId";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", userId);
            SQLCmd.Parameters.AddWithValue("@paranewPw", newPw);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }
    }
}