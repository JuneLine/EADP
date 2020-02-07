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
    public class TourGuidesDAO
    {
        public List<TourGuides> getApplications(string hired)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Users where Status = @paraPending";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("paraPending", hired);

            DataSet ds = new DataSet();
            da.Fill(ds);
            List<TourGuides> tdList = new List<TourGuides>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string uniqueId = row["Id"].ToString();
                    string userName = row["Username"].ToString();
                    string gender = row["Gender"].ToString();
                    string emailAddr = row["EmailAddr"].ToString();
                    string uploadFile = row["Upload"].ToString();

                    TourGuides hist = new TourGuides(uniqueId, userName, gender, emailAddr, uploadFile);

                    tdList.Add(hist);
                }
            }

            else
            {
                tdList = null;
            }

            return tdList;
        }

        public int UpdateRole(string role, string id)
        {
            string confirmed = "Confirmed";
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Users SET Role = @paraRole, Status = @paraConfirmed where Id =  @paraId";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraRole", role);
            sqlCmd.Parameters.AddWithValue("@paraConfirmed", confirmed);
            sqlCmd.Parameters.AddWithValue("paraId", id);



            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public List<TourGuides> getTourGuide(string role)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Users where Role = @paraRole";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("paraRole", role);

            DataSet ds = new DataSet();
            da.Fill(ds);
            List<TourGuides> tdList = new List<TourGuides>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string uniqueId = row["Id"].ToString();
                    string userName = row["Username"].ToString();
                    string gender = row["Gender"].ToString();
                    string emailAddr = row["EmailAddr"].ToString();
                    string uploadFile = row["Upload"].ToString();

                    TourGuides hist = new TourGuides(uniqueId, userName, gender, emailAddr, uploadFile);

                    tdList.Add(hist);
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