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
    public class TouristAttractionsDAO
    {
        private static TouristAttractions Read(SqlDataReader dr)
        {
            string id = dr["AttractionId"].ToString();
            string Name = dr["Name"].ToString();
            string Picture = dr["Picture"].ToString();
            string URL = dr["URL"].ToString();
            string Description = dr["Description"].ToString();

            TouristAttractions list = new TouristAttractions
            {
                Id = id,
                AttractionName = Name,
                Picture = Picture,
                URL = URL,
                Description = Description
            };

            return list;
        }

        public List<TouristAttractions> RetrieveAll()
        {
            List<TouristAttractions> rows = new List<TouristAttractions>();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = "Select * from TouristAttractions";

            SqlCommand SQLCmd = new SqlCommand(sqlStmt, Connection);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                TouristAttractions td = Read(dr);
                rows.Add(td);
            }
            Connection.Close();

            return rows;
        }

        public TouristAttractions RetrieveOne(string Id)
        {
            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            SqlDataAdapter sda = new SqlDataAdapter("Select * from TouristAttractions Where AttractionId = @paraId", ConnectDB);
            sda.SelectCommand.Parameters.AddWithValue("@paraId", Id);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            TouristAttractions Listing = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string id = row["AttractionId"].ToString();
                string Name = row["Name"].ToString();
                string Picture = row["Picture"].ToString();
                string URL = row["URL"].ToString();
                string Description = row["Description"].ToString();
                string Tags = row["Tag"].ToString();
                string Price = row["Price"].ToString();
                Listing = new TouristAttractions(id, Name, Picture, URL, Description, Tags, Price);
            }

            return Listing;
        }

        public int InsertAttraction(TouristAttractions List)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO TouristAttractions(AttractionId, Name, Picture, URL, Description, Tag, Price) " +
            "VALUES(@paraId,@paraName, @paraPicture, @paraURL, @paraDescription, @paraTag, @paraPrice)";


            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@paraName", List.AttractionName);
            SQLCmd.Parameters.AddWithValue("@paraPicture", List.Picture);
            SQLCmd.Parameters.AddWithValue("@paraURL", List.URL);
            SQLCmd.Parameters.AddWithValue("@paraDescription", List.Description);
            SQLCmd.Parameters.AddWithValue("@paraTag", List.Tags);
            SQLCmd.Parameters.AddWithValue("@paraPrice", List.Price);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public int UpdateAttraction(string id, string name, string picture, string url, string description, string tags, string price)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"UPDATE touristAttractions SET Name = @paraName, Picture = @paraPicture, URL = @paraURL, Description = @paraDescription, Tag = @paraTag, Price = @paraPrice WHERE AttractionId = @paraId";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", id);
            SQLCmd.Parameters.AddWithValue("@paraName", name);
            SQLCmd.Parameters.AddWithValue("@paraPicture", picture);
            SQLCmd.Parameters.AddWithValue("@paraURL", url);
            SQLCmd.Parameters.AddWithValue("@paraDescription", description);
            SQLCmd.Parameters.AddWithValue("@paraTag", tags);
            SQLCmd.Parameters.AddWithValue("@paraPrice", price);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public List<TouristAttractions> SelectDestination(string destinationName)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from TouristAttractions where Name = @paraName ";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraName", destinationName);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<TouristAttractions> tdList = new List<TouristAttractions>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string id = row["AttractionId"].ToString();
                    string Name = row["Name"].ToString();
                    string Picture = row["Picture"].ToString();
                    string URL = row["URL"].ToString();
                    string Description = row["Description"].ToString();
                    string Tags = row["Tag"].ToString();
                    string Price = row["Price"].ToString();

                    TouristAttractions dest = new TouristAttractions(id, Name, Picture, URL, Description, Tags, Price);

                    tdList.Add(dest);
                }


            }

            else
            {
                tdList = null;
            }

            return tdList;
        }

        public List<TouristAttractions> SelectAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from TouristAttractions";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            List<TouristAttractions> tdList = new List<TouristAttractions>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string id = row["AttractionId"].ToString();
                    string Name = row["Name"].ToString();
                    string Picture = row["Picture"].ToString();
                    string URL = row["URL"].ToString();
                    string Description = row["Description"].ToString();
                    string Tags = row["Tag"].ToString();
                    string Price = row["Price"].ToString();

                    TouristAttractions dest = new TouristAttractions(id, Name, Picture, URL, Description, Tags, Price);

                    tdList.Add(dest);
                }


            }

            else
            {
                tdList = null;
            }

            return tdList;
        }
    }
}