using System;
using System.Collections.Generic;
using System.Configuration;
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
            string Id = dr["Id"].ToString();
            string userId = dr["userId"].ToString();
            string comments = dr["comments"].ToString();
            string date = dr["date"].ToString();
            decimal rating = Convert.ToDecimal(dr["rating"].ToString());

            Reviews Read = new Reviews
            {
                Id = Id,
                userId = userId,
                Comments = comments,
                date = date,
                rating = rating
            };
            return Read;
        }

        public int InsertComment(Reviews List)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO GuideTour(Id, userId, comments, date, rating)" +
            "VALUES(@paraId, @parauserId, @paraComments, @paraDate, @paraRating)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@parauserId", List.userId);
            SQLCmd.Parameters.AddWithValue("@paraComments", List.Comments);
            SQLCmd.Parameters.AddWithValue("@paraDate", List.date);
            SQLCmd.Parameters.AddWithValue("@paraRating", List.rating);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }
    }
}