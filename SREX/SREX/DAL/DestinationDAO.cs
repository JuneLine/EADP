using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SREX.DAL
{
    public class DestinationDAO
    {
        public int InsertDestination(Destination dest)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO Destination (name,picture, description,price,tag) 
VALUES (@paraName, @paraPictureName, @paraDescription, @paraPrice, @paraTag)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraName", dest.DestinationName);
            SQLCmd.Parameters.AddWithValue("@paraPictureName", dest.PictureName);
            SQLCmd.Parameters.AddWithValue("@paraDescription", dest.Description);
            SQLCmd.Parameters.AddWithValue("@paraPrice", dest.Price);
            SQLCmd.Parameters.AddWithValue("@paraTag", dest.Tag);


            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public List<Destination> SelectAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Destination";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            List<Destination> tdList = new List<Destination>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string uniqueId = row["UniqueId"].ToString();
                    string destinationName = row["name"].ToString();
                    string pictureName = row["picture"].ToString();
                    string description = row["description"].ToString();
                    string price = row["price"].ToString();
                    string tag = row["tag"].ToString();

                    Destination dest = new Destination(uniqueId, destinationName, pictureName, description, price, tag);

                    tdList.Add(dest);
                }


            }

            else
            {
                tdList = null;
            }

            return tdList;
        }

        public List<Destination> SelectDestination(string destinationName)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Destination where name = @paraName ";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraName", destinationName);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<Destination> tdList = new List<Destination>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string uniqueId = row["UniqueId"].ToString();
                    string name = row["name"].ToString();
                    string pictureName = row["pictureName"].ToString();
                    string description = row["description"].ToString();
                    string price = row["price"].ToString();
                    string tag = row["tag"].ToString();

                    Destination dest = new Destination(uniqueId, name, pictureName, description, price, tag);

                    tdList.Add(dest);
                }


            }

            else
            {
                tdList = null;
            }

            return tdList;
        }

        public Destination SelectByUniqueId(int uniqueId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT * From Destination where UniqueId = @paraUniqueId ";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraUniqueId", uniqueId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Destination td = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string uId = row["UniqueId"].ToString();
                string name = row["name"].ToString();
                string pictureName = row["picture"].ToString();
                string description = row["description"].ToString();
                string price = row["price"].ToString();
                string tag = row["tag"].ToString();

                td = new Destination(uId, name, pictureName, description, price, tag);

            }
            return td;
        }

        public int UpdateDescription(string description, string photoName, int uniqueId, string price, string tag)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Destination SET description = @paraDescription, picture = @paraPictureName, price = @paraPrice, tag = @paraTag  where UniqueId =  @paraUniqueId";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraDescription", description);
            sqlCmd.Parameters.AddWithValue("@paraPictureName", photoName);
            sqlCmd.Parameters.AddWithValue("@paraUniqueId", uniqueId);
            sqlCmd.Parameters.AddWithValue("@paraPrice", price);
            sqlCmd.Parameters.AddWithValue("@paraTag", tag);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int SearchByPictureName(string pictureName)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "SELECT * From Destination where picture = @paraPictureName";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraPictureName", pictureName);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
    }
}