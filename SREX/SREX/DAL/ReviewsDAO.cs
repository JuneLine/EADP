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
            string id = dr["id"].ToString();
            string userId = dr["userId"].ToString();
            string username = dr["userName"].ToString();
            string comments = dr["comments"].ToString();
            string date = dr["date"].ToString();
            decimal ratings = Convert.ToDecimal(dr["ratings"]);

            Reviews Read = new Reviews
            {
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
            SQLCmd = new SqlCommand("Select * from PageReviews", Connection);
           
            List<Reviews> rows = new List<Reviews>();

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                Reviews td = Read(dr);
                rows.Add(td);
            }
            Connection.Close();

            //SqlDataAdapter sda = new SqlDataAdapter("Select * from PageReviews", Connection);
            //DataSet ds = new DataSet();
            //sda.Fill(ds);
            //int rec_cnt = ds.Tables[0].Rows.Count;
            //for (int i = 0; i < rec_cnt; i++)
            //{
            //    DataRow row = ds.Tables[0].Rows[i];
            //    string userId = row["userId"].ToString();
            //    string username = row["userName"].ToString();
            //    string comments = row["comments"].ToString();
            //    string date = row["date"].ToString();
            //    decimal rating = Convert.ToDecimal(row["ratings"].ToString());
            //    Reviews Data = new Reviews(userId, username, comments, date, rating);
            //    rows.Add(Data);
            //}

            return rows;
        }
    }
}