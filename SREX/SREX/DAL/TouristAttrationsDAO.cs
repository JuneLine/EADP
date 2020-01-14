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
                Listing = new TouristAttractions(id, Name, Picture, URL, Description);
            }

            return Listing;
        }

        public int InsertAttraction(TouristAttractions List)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO TouristAttractions(AttractionId, Name, Picture, URL, Description) " +
            "VALUES(@paraId,@paraName, @paraPicture, @paraURL, @paraDescription)";


            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@paraName", List.AttractionName);
            SQLCmd.Parameters.AddWithValue("@paraPicture", List.Picture);
            SQLCmd.Parameters.AddWithValue("@paraURL", List.URL);
            SQLCmd.Parameters.AddWithValue("@paraDescription", List.Description);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public int UpdateAttraction(string id, string name, string picture, string url, string description)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"UPDATE touristAttractions SET Name = @paraName, Picture = @paraPicture, URL = @paraURL, Description = @paraDescription WHERE AttractionId = @paraId";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", id);
            SQLCmd.Parameters.AddWithValue("@paraName", name);
            SQLCmd.Parameters.AddWithValue("@paraPicture", picture);
            SQLCmd.Parameters.AddWithValue("@paraURL", url);
            SQLCmd.Parameters.AddWithValue("@paraDescription", description);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }
    }
}