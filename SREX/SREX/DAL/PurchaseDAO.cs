using SREX.BLL;
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
        private static Purchase Read(SqlDataReader dr)
        {
            string OrderID = dr["OrderID"].ToString();
            decimal Price = Convert.ToDecimal(dr["Price"]);
            string DateOfPurchase = dr["DateOfPurchase"].ToString();
            string UserID = dr["UserID"].ToString();

            Purchase History = new Purchase
            {
                OrderID = OrderID,
                Price = Price,
                DateOfPurchase = DateOfPurchase,
                UserID = UserID
            };

            return History;
        }

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

            string sqlStmt2 = @"INSERT INTO PurchaseHistoryFull (OrderId, Price, UserID) VALUES (@paraOrderID, @paraPrice, @paraUserID)";
            SQLCmd2 = new SqlCommand(sqlStmt2, Connection);
            SQLCmd2.Parameters.AddWithValue("@paraOrderID", orderID);
            SQLCmd2.Parameters.AddWithValue("@paraPrice", amount);
            SQLCmd2.Parameters.AddWithValue("@paraUserID", userId);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();
            result2 = SQLCmd2.ExecuteNonQuery();
            Connection.Close();

            return result;
        }

        public List<Purchase> getPurchaseHistory(string userID)
        {
            List<Purchase> History = new List<Purchase>();

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"SELECT * FROM PurchaseHistoryFull WHERE UserID = @paraUserID ORDER BY CONVERT(DATETIME, DateOfPurchase, 103) DESC";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            SQLCmd.Parameters.AddWithValue("@paraUserID", userID);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                Purchase Td = Read(dr);
                History.Add(Td);
            }
            return History;
        }

        public List<Purchase> getMoneyEarned()
        {
            List<Purchase> Purchases = new List<Purchase>();

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"Select TOP 7 SUM(Price) as Price, DateOfPurchase FROM PurchaseHistoryFull GROUP BY DateOfPurchase ORDER BY CONVERT(DATETIME, DateOfPurchase, 103) DESC";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                decimal Price = Convert.ToDecimal(dr["Price"]);
                string Date = dr["DateOfPurchase"].ToString();
                Purchase prod = new Purchase
                {
                    Price = Price,
                    DateOfPurchase = Date,
                };
                Purchases.Add(prod);
            }
            return Purchases;
        }
    }
}