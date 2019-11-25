﻿using System;
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
        public int InsertUser(Customer Cust)
        {
            int result = 0;
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO Users (Username, Password, Gender, PassportID, DOB, EmailAddr, Role) 
VALUES (@paraName, @paraPass, @paraGender, @paraPassPort, @paraDOB, @paraEmail, @paraUser)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            SQLCmd.Parameters.AddWithValue("@paraName", Cust.user);
            SQLCmd.Parameters.AddWithValue("@paraPass", Cust.pass);
            SQLCmd.Parameters.AddWithValue("@paraGender", Cust.gender);
            SQLCmd.Parameters.AddWithValue("@paraPassPort", Cust.passnum);
            SQLCmd.Parameters.AddWithValue("@paraDOB", Cust.dob);
            SQLCmd.Parameters.AddWithValue("@paraEmail", Cust.email);
            SQLCmd.Parameters.AddWithValue("@paraUser", "Normal");
  
            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }
    }
}