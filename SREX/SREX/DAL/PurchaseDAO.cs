using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SREX.DAL
{
    public class PurchaseDAO
    {
        public int checkoutAllCurrentItems(string userId, decimal amount, string orderID)
        {
            int result = 0;
            int result2 = 0;

            SqlCommand SQLCmd = new SqlCommand();
            SqlCommand SQLCmd2 = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"UPDATE CartItem SET Status = 'Paid', OrderID = @paraorderID WHERE UserId = @parauserId AND Status = 'Active'";
            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraorderID", orderID);
            SQLCmd.Parameters.AddWithValue("@parauserId", userId);

            string sqlStmt2 = @"INSERT INTO PurchaseHistoryFull (OrderId, Price) VALUES (@paraOrderID, @paraPrice)";
            SQLCmd2 = new SqlCommand(sqlStmt2, Connection);
            SQLCmd2.Parameters.AddWithValue("@paraOrderID", orderID);
            SQLCmd2.Parameters.AddWithValue("@paraPrice", amount);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();
            result2 = SQLCmd2.ExecuteNonQuery();
            Connection.Close();

            return result;
        }
    }
}