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
    public class SelfPlanDAO
    {

        public int InsertHistory(SelfPlan Hist)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO SelfPlanHistory (Id,Title, Date, Hire, Timing1, Timing2, Timing3, Timing4, Timing5, Timing6, Timing7, Timing8, Timing9, Timing10, Status, UserName) 
VALUES (@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming1, @paraTiming2, @paraTiming3, @paraTiming4, @paraTiming5, @paraTiming6, @paraTiming7, @paraTiming8, @paraTiming9, @paraTiming10, @paraStatus, @paraUserName)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", Hist.Id);
            SQLCmd.Parameters.AddWithValue("@paraTitle", Hist.Title);
            SQLCmd.Parameters.AddWithValue("@paraDate", Hist.Date);
            SQLCmd.Parameters.AddWithValue("@paraHire", Hist.Hire);
            SQLCmd.Parameters.AddWithValue("@paraTiming1", Hist.Timing1);
            SQLCmd.Parameters.AddWithValue("@paraTiming2", Hist.Timing2);
            SQLCmd.Parameters.AddWithValue("@paraTiming3", Hist.Timing3);
            SQLCmd.Parameters.AddWithValue("@paraTiming4", Hist.Timing4);
            SQLCmd.Parameters.AddWithValue("@paraTiming5", Hist.Timing5);
            SQLCmd.Parameters.AddWithValue("@paraTiming6", Hist.Timing6);
            SQLCmd.Parameters.AddWithValue("@paraTiming7", Hist.Timing7);
            SQLCmd.Parameters.AddWithValue("@paraTiming8", Hist.Timing8);
            SQLCmd.Parameters.AddWithValue("@paraTiming9", Hist.Timing9);
            SQLCmd.Parameters.AddWithValue("@paraTiming10", Hist.Timing10);
            SQLCmd.Parameters.AddWithValue("paraStatus", Hist.Status);
            SQLCmd.Parameters.AddWithValue("paraUserName", Hist.UserName);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;

            //            int result = 0;

            //            SqlCommand SQLCmd = new SqlCommand();

            //            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            //            SqlConnection Connection = new SqlConnection(ConnectDB);

            //            string sqlStmt = @"INSERT INTO SelfPlanHist (Id,Title, Date, Hire, Timing, Activity) 
            //VALUES (@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming1,@paraTiming1),(@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming2,@paraTiming2), (@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming3,@paraTiming3), 
            //(@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming4,@paraTiming4), (@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming5,@paraTiming5), (@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming6,@paraTiming6),
            //(@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming7,@paraTiming7),(@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming8,@paraTiming8),(@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming9,@paraTiming9)
            //,(@paraId, @paraTitle, @paraDate, @paraHire, @paraTiming10,@paraTiming10)";


            //            SQLCmd = new SqlCommand(sqlStmt, Connection);
            //            SQLCmd.Parameters.AddWithValue("@paraId", Hist.Id);
            //            SQLCmd.Parameters.AddWithValue("@paraTitle", Hist.Title);
            //            SQLCmd.Parameters.AddWithValue("@paraDate", Hist.Date);
            //            SQLCmd.Parameters.AddWithValue("@paraHire", Hist.Hire);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming1", Hist.Timing1);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming2", Hist.Timing2);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming3", Hist.Timing3);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming4", Hist.Timing4);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming5", Hist.Timing5);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming6", Hist.Timing6);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming7", Hist.Timing7);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming8", Hist.Timing8);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming9", Hist.Timing9);
            //            SQLCmd.Parameters.AddWithValue("@paraTiming10", Hist.Timing10);
            //            SQLCmd.

            //            Connection.Open();
            //            result = SQLCmd.ExecuteNonQuery();

            //            Connection.Close();

            //            return result;
        }

        public List<SelfPlan> SelectAllById(string Id)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from SelfPlanHistory where Id = @paraId", con);
            sda.SelectCommand.Parameters.AddWithValue("@paraId", Id);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            List<SelfPlan> empList = new List<SelfPlan>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string id = row["Id"].ToString();
                string title = row["Title"].ToString();
                string date = row["Date"].ToString();
                string hire = row["Hire"].ToString();
                string Timing1 = row["Timing1"].ToString();
                string Timing2 = row["Timing2"].ToString();
                string Timing3 = row["Timing3"].ToString();
                string Timing4 = row["Timing4"].ToString();
                string Timing5 = row["Timing5"].ToString();
                string Timing6 = row["Timing6"].ToString();
                string Timing7 = row["Timing7"].ToString();
                string Timing8 = row["Timing8"].ToString();
                string Timing9 = row["Timing9"].ToString();
                string Timing10 = row["Timing10"].ToString();
                SelfPlan obj = new SelfPlan(id, title, date, hire, Timing1, Timing2, Timing3, Timing4, Timing5, Timing6, Timing7, Timing8, Timing9, Timing10);
                empList.Add(obj);
            }

            return empList;

        }

        public List<SelfPlan> getTourGuided(string hired)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from SelfPlanHistory where Status = @paraPending";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("paraPending", hired);

            DataSet ds = new DataSet();
            da.Fill(ds);
            List<SelfPlan> tdList = new List<SelfPlan>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int uniqueId = int.Parse(row["UniqueId"].ToString());
                    string userName = row["UserName"].ToString();
                    string date = row["Date"].ToString();
                    string title = row["Title"].ToString();
                    string hire = row["Hire"].ToString();

                    SelfPlan hist = new SelfPlan(uniqueId, userName, title, date, hire);

                    tdList.Add(hist);
                }


            }

            else
            {
                tdList = null;
            }

            return tdList;
        }

        public List<SelfPlan> SelectDestinationById(string Id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from SelfPlanHistory where Id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", Id);

            DataSet ds = new DataSet();
            da.Fill(ds);
            List<SelfPlan> tdList = new List<SelfPlan>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int uniqueId = int.Parse(row["UniqueId"].ToString());
                    string username = row["UserName"].ToString();
                    string title = row["Title"].ToString();
                    string date = row["Date"].ToString();
                    string hire = row["Hire"].ToString();

                    SelfPlan dest = new SelfPlan(uniqueId, username, title, date, hire);

                    tdList.Add(dest);
                }


            }

            else
            {
                tdList = null;
            }

            return tdList;
        }

        public SelfPlan SelectByUniqueId(int UniqueId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT * From SelfPlanHistory where UniqueId = @paraUniqueId ";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraUniqueId", UniqueId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            SelfPlan td = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string id = row["Id"].ToString();
                string titleName = row["Title"].ToString();
                string date = row["Date"].ToString();
                string hire = row["Hire"].ToString();
                string status = row["Status"].ToString();
                string timing1 = row["Timing1"].ToString();
                string timing2 = row["Timing2"].ToString();
                string timing3 = row["Timing3"].ToString();
                string timing4 = row["Timing4"].ToString();
                string timing5 = row["Timing5"].ToString();
                string timing6 = row["Timing6"].ToString();
                string timing7 = row["Timing7"].ToString();
                string timing8 = row["Timing8"].ToString();
                string timing9 = row["Timing9"].ToString();
                string timing10 = row["Timing10"].ToString();
                string username = row["UserName"].ToString();
                string tourguidename = row["TourGuideName"].ToString();


                td = new SelfPlan(id, titleName, date, hire, timing1, timing2, timing3, timing4, timing5, timing6, timing7, timing8, timing9, timing10, status, username, tourguidename);

            }
            return td;
        }

        public int UpdateStatus(string status, int id, string tourguideId, string tourguidename)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE SelfPlanHistory SET Status = @paraStatus, TourGuideId = @paraTourGuideId, TourGuideName = @paraTourGuideName where UniqueId =  @paraUniqueId";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("paraTourGuideId", tourguideId);
            sqlCmd.Parameters.AddWithValue("@paraStatus", status);
            sqlCmd.Parameters.AddWithValue("paraUniqueId", id);
            sqlCmd.Parameters.AddWithValue("paraTourGuideName", tourguidename);



            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int UpdateApplication(string status, string id, string uploadFile)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Users SET Status = @paraStatus, Upload = @paraUpload where Id =  @paraUniqueId";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraStatus", status);
            sqlCmd.Parameters.AddWithValue("@paraUpload", uploadFile);
            sqlCmd.Parameters.AddWithValue("paraUniqueId", id);



            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public List<SelfPlan> selectByTitle(string titleChosen)
        {
            string status = "Pending";
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from SelfPlanHistory where Title = @paraTitle AND Status = @paraStatus";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraTitle", titleChosen);
            da.SelectCommand.Parameters.AddWithValue("@paraStatus", status);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<SelfPlan> tdList = new List<SelfPlan>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int uniqueId = int.Parse(row["UniqueId"].ToString());
                    string userName = row["UserName"].ToString();
                    string date = row["Date"].ToString();
                    string title = row["Title"].ToString();
                    string hire = row["Hire"].ToString();

                    SelfPlan hist = new SelfPlan(uniqueId, userName, title, date, hire);

                    tdList.Add(hist);
                }


            }

            else
            {
                tdList = null;
            }

            return tdList;
        }

        public List<SelfPlan> selectAll()
        {
            string status = "Pending";
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from SelfPlanHistory where Status = @paraStatus";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraStatus", status);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<SelfPlan> tdList = new List<SelfPlan>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int uniqueId = int.Parse(row["UniqueId"].ToString());
                    string userName = row["UserName"].ToString();
                    string date = row["Date"].ToString();
                    string title = row["Title"].ToString();
                    string hire = row["Hire"].ToString();

                    SelfPlan hist = new SelfPlan(uniqueId, userName, title, date, hire);

                    tdList.Add(hist);
                }


            }

            else
            {
                tdList = null;
            }

            return tdList;
        }

        public List<SelfPlan> selectAllByGuideId(string id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from SelfPlanHistory where TourGuideId = @paraTourGuideId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraTourGuideId", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<SelfPlan> tdList = new List<SelfPlan>();
            int rec_cnt = ds.Tables[0].Rows.Count;

            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int uniqueId = int.Parse(row["UniqueId"].ToString());
                    string userName = row["UserName"].ToString();
                    string date = row["Date"].ToString();
                    string title = row["Title"].ToString();
                    string hire = row["Hire"].ToString();

                    SelfPlan hist = new SelfPlan(uniqueId, userName, title, date, hire);

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