using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SREX.BLL;

namespace SREX.DAL
{
    public class ReviewsDAO
    {
        private static Reviews Read(SqlDataReader dr)
        {
            string id = dr["Id"].ToString();
            string userId = dr["userId"].ToString();
            string username = dr["userName"].ToString();
            string comments = dr["comments"].ToString();
            string date = dr["date"].ToString();
            decimal ratings = Convert.ToDecimal(dr["ratings"]);

            Reviews Read = new Reviews
            {
                Id = id,
                userId = userId,
                username = username,
                Comments = comments,
                date = date,
                rating = ratings
            };
            return Read;
        }

        public int InsertComment(Reviews List)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO PageReviews(userId, userName, comments, date, ratings)" +
            "VALUES(@parauserId, @paraName, @paraComments, @paraDate, @paraRating)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);            
            SQLCmd.Parameters.AddWithValue("@parauserId", List.userId);
            SQLCmd.Parameters.AddWithValue("@paraName", List.username);
            SQLCmd.Parameters.AddWithValue("@paraComments", List.Comments);
            SQLCmd.Parameters.AddWithValue("@paraDate", List.date);
            SQLCmd.Parameters.AddWithValue("@paraRating", List.rating);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public List<Reviews> RetrieveAllComment()
        {
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);            
            SQLCmd = new SqlCommand("Select * from PageReviews ORDER BY Id DESC", Connection);
           
            List<Reviews> rows = new List<Reviews>();

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                Reviews td = Read(dr);
                rows.Add(td);
            }
            Connection.Close();        
            return rows;
        }

        public List<Reviews> RetrieveOneComment(string id)
        {
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);
            SQLCmd = new SqlCommand("Select * from PageReviews where Id = @paraId", Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", id);

            List<Reviews> rows = new List<Reviews>();

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                Reviews td = Read(dr);
                rows.Add(td);
            }
            Connection.Close();
            return rows;
        }

        public int UpdateComment(string id, string comment, decimal rating)
        {
            int result = 0;

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"UPDATE PageReviews SET comments = @paraComment, ratings = @paraRating where Id = @paraId";

            SqlCommand SQlCmd = new SqlCommand(sqlStmt, Connection);            
            SQlCmd.Parameters.AddWithValue("@paraComment", comment);
            SQlCmd.Parameters.AddWithValue("@paraRating", rating);
            SQlCmd.Parameters.AddWithValue("@paraId", id);
        
            Connection.Open();
            result = SQlCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }
    }
}