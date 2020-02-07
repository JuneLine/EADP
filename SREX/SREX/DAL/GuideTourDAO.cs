using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SREX.BLL;

namespace SREX.DAL
{
    public class GuideTourDAO
    {
        private static GuideTour ReadDB1(SqlDataReader dr)
        {
            string Id = dr["tourId"].ToString();
            string tourName = dr["tourName"].ToString();
            string tourPic = dr["tourPic"].ToString();
            string tourCaption = dr["caption"].ToString();
            string Date = dr["Date"].ToString();
            string meetUpTime = dr["meetUpTime"].ToString();
            string meetUpLocation = dr["meetUpLocation"].ToString();
            decimal AdultCost = Convert.ToDecimal(dr["AdultCost"]);
            decimal ChildCost = Convert.ToDecimal(dr["ChildCost"]);
            decimal SeniorCost = Convert.ToDecimal(dr["SeniorCost"]);

            GuideTour Reader1 = new GuideTour
            {
                tourId = Id,
                tourName = tourName,
                tourPic = tourPic,
                tourCaption = tourCaption,
                Date = Date,
                meetUpTime = meetUpTime,
                meetUpLocation = meetUpLocation,
                AdultCost = AdultCost,
                ChildCost = ChildCost,
                SeniorCost = SeniorCost,
            };

            return Reader1;
        }

        private static GuideTour ReadDB2(SqlDataReader dr)
        {
            string tourId = dr["tourId"].ToString();
            string Time1 = dr["Time1"].ToString();
            string Activity1 = dr["Activity1"].ToString();
            string Time2 = dr["Time2"].ToString();
            string Activity2 = dr["Activity2"].ToString();
            string Time3 = dr["Time3"].ToString();
            string Activity3 = dr["Activity3"].ToString();
            string Time4 = dr["Time4"].ToString();
            string Activity4 = dr["Activity4"].ToString();
            string Time5 = dr["Time5"].ToString();
            string Activity5 = dr["Activity5"].ToString();
            string Time6 = dr["Time6"].ToString();
            string Activity6 = dr["Activity6"].ToString();
            string Time7 = dr["Time7"].ToString();
            string Activity7 = dr["Activity7"].ToString();

            GuideTour Reader2 = new GuideTour
            {
                tourId = tourId,
                Time1 = Time1,
                Time2 = Time2,
                Time3 = Time3,
                Time4 = Time4,
                Time5 = Time5,
                Time6 = Time6,
                Time7 = Time7,
                Activity1 = Activity1,
                Activity2 = Activity2,
                Activity3 = Activity3,
                Activity4 = Activity4,
                Activity5 = Activity5,
                Activity6 = Activity6,
                Activity7 = Activity7,
            };

            return Reader2;
        }

        private static GuideTour ReadDB3(SqlDataReader dr)
        {
            string id = dr["PurchaseId"].ToString();
            string Date = dr["Date"].ToString();
            string Name = dr["Name"].ToString();
            string Email = dr["Email"].ToString();
            string Contact = dr["Contact"].ToString();
            int AdultQuantity = int.Parse(dr["AdultQuantity"].ToString());
            int ChildQuantity = int.Parse(dr["ChildQuantity"].ToString());
            int SeniorQuantity = int.Parse(dr["SeniorQuantity"].ToString());
            decimal Payment = Convert.ToDecimal(dr["PaymentAmount"].ToString());
            string userId = dr["userId"].ToString();
            string tourId = dr["tourId"].ToString();

            GuideTour Reader3 = new GuideTour
            {
                PurchaseId = id,
                Date = Date,
                UserName = Name,
                UserEmail = Email,
                UserContact = Contact,
                AdultQuantity = AdultQuantity,
                ChildQuantity = ChildQuantity,
                SeniorQuantity = SeniorQuantity,
                PaymentAmount = Payment,
                userId = userId,
                tourId = tourId
            };

            return Reader3;
        }

        public List<GuideTour> RetrieveAllGuide()
        {
            List<GuideTour> rows = new List<GuideTour>();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = "Select * from GuideTour";

            SqlCommand SQLCmd = new SqlCommand(sqlStmt, Connection);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                GuideTour td = ReadDB1(dr);
                rows.Add(td);
            }
            Connection.Close();

            return rows;
        }

        public List<GuideTour> RetrieveSpecificEvent(string tourId)
        {
            List<GuideTour> rows = new List<GuideTour>();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = "Select * from GuideTour where tourId = @paratourId";

            SqlCommand SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paratourId", tourId);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                GuideTour td = ReadDB1(dr);
                rows.Add(td);
            }
            Connection.Close();

            return rows;
        }

        public List<GuideTour> RetrieveSpecificEventInfo(string tourId)
        {
            List<GuideTour> rows = new List<GuideTour>();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            SqlCommand SQLCmd = new SqlCommand("Select * from TourInfo where tourId = @paratourId", Connection);
            SQLCmd.Parameters.AddWithValue("@paratourId", tourId);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                GuideTour td = ReadDB2(dr);
                rows.Add(td);
            }
            Connection.Close();

            return rows;
        }

        public List<GuideTour> RetrieveSpecificID(string name, string pic, string caption)
        {
            List<GuideTour> rows = new List<GuideTour>();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            SqlCommand SQLCmd = new SqlCommand("Select * from GuideTour where tourName = @paraName and tourPic = @paraPic and caption = @paraCapt", Connection);
            SQLCmd.Parameters.AddWithValue("@paraName", name);
            SQLCmd.Parameters.AddWithValue("@paraPic", pic);
            SQLCmd.Parameters.AddWithValue("@paraCapt", caption);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                GuideTour td = ReadDB1(dr);
                rows.Add(td);
            }
            Connection.Close();

            return rows;
        }

        public int InsertTour(GuideTour List)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO GuideTour(tourId, tourName, tourPic, caption, Date, meetUpTime, meetUpLocation, AdultCost, ChildCost, SeniorCost) " +
            "VALUES(@paratourId,@paratourName, @paratourPic, @paraCaption, @paraDate, @paraMeetTime, @paraMeetLocation, @paraAdult, @paraChild, @paraSenior)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paratourId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@paratourName", List.tourName);
            SQLCmd.Parameters.AddWithValue("@paratourPic", List.tourPic);
            SQLCmd.Parameters.AddWithValue("@paraCaption", List.tourCaption);
            SQLCmd.Parameters.AddWithValue("@paraDate", List.Date);
            SQLCmd.Parameters.AddWithValue("@paraMeetTime", List.meetUpTime);
            SQLCmd.Parameters.AddWithValue("@paraMeetLocation", List.meetUpLocation);
            SQLCmd.Parameters.AddWithValue("@paraAdult", List.AdultCost);
            SQLCmd.Parameters.AddWithValue("@paraChild", List.ChildCost);
            SQLCmd.Parameters.AddWithValue("@paraSenior", List.SeniorCost);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public int InsertTourActivity(GuideTour List)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO TourDetails(tourInfoId, Time1, Activity1, Time2, Activity2, Time3, Activity3, Time4, Activity4, Time5, Activity5, Time6, Activity6, Time7, Activity7, tourId) " +
            "VALUES(@paratourInfoId, @paraTime1, @paraActivity1, @paraTime2, @paraActivity2, @paraTime3, @paraActivity3, @paraTime4, @paraActivity4, @paraTime5, @paraActivity5, @paraTime6, @paraActivity6, @paraTime7, @paraActivity7, @paratourId)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paratourInfoId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@paraTime1", List.Time1);
            SQLCmd.Parameters.AddWithValue("@paraTime2", List.Time2);
            SQLCmd.Parameters.AddWithValue("@paraTime3", List.Time3);
            SQLCmd.Parameters.AddWithValue("@paraTime4", List.Time4);
            SQLCmd.Parameters.AddWithValue("@paraTime5", List.Time5);
            SQLCmd.Parameters.AddWithValue("@paraTime6", List.Time6);
            SQLCmd.Parameters.AddWithValue("@paraTime7", List.Time7);
            SQLCmd.Parameters.AddWithValue("@paraActivity1", List.Activity1);
            SQLCmd.Parameters.AddWithValue("@paraActivity2", List.Activity2);
            SQLCmd.Parameters.AddWithValue("@paraActivity3", List.Activity3);
            SQLCmd.Parameters.AddWithValue("@paraActivity4", List.Activity4);
            SQLCmd.Parameters.AddWithValue("@paraActivity5", List.Activity5);
            SQLCmd.Parameters.AddWithValue("@paraActivity6", List.Activity6);
            SQLCmd.Parameters.AddWithValue("@paraActivity7", List.Activity1);
            SQLCmd.Parameters.AddWithValue("@paratourId", List.tourId);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public List<GuideTour> RetrievePurchasesHist(string userId)
        {
            List<GuideTour> rows = new List<GuideTour>();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = "Select * from GuidePurchases where userId = @parauserId";

            SqlCommand SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@parauserId", userId);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                GuideTour td = ReadDB3(dr);
                rows.Add(td);
            }
            Connection.Close();

            return rows;
        }

        public List<GuideTour> RetrieveSpecificPurchase(string id, string userId)
        {
            List<GuideTour> rows = new List<GuideTour>();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = "Select * from GuidePurchases where PurchaseId = @paraId and userId = @parauserId";

            SqlCommand SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", id);
            SQLCmd.Parameters.AddWithValue("@parauserId", userId);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                GuideTour td = ReadDB3(dr);
                rows.Add(td);
            }
            Connection.Close();

            return rows;
        }


        public int InsertPurchases(GuideTour Listing)
        {
            int result = 0;

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO GuidePurchases(PurchaseId, Date ,Name, Email, Contact, AdultQuantity, ChildQuantity, SeniorQuantity, PaymentAmount, userId, tourId) " +
            "VALUES(@paraPurchaseId, @paraDate, @paraName, @paraEmail, @paraContact, @paraAQuant, @paraCQuant, @paraSQuant, @paraPayAmt, @parauserId, @paratourId)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraPurchaseId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@paraDate", Listing.Date);
            SQLCmd.Parameters.AddWithValue("@paraName", Listing.UserName);
            SQLCmd.Parameters.AddWithValue("@paraEmail", Listing.UserEmail);
            SQLCmd.Parameters.AddWithValue("@paraContact", Listing.UserContact);
            SQLCmd.Parameters.AddWithValue("@paraAQuant", Listing.AdultQuantity);
            SQLCmd.Parameters.AddWithValue("@paraCQuant", Listing.ChildQuantity);
            SQLCmd.Parameters.AddWithValue("@paraSQuant", Listing.SeniorQuantity);
            SQLCmd.Parameters.AddWithValue("@paraPayAmt", Listing.PaymentAmount);
            SQLCmd.Parameters.AddWithValue("@parauserId", Listing.userId);
            SQLCmd.Parameters.AddWithValue("@paratourId", Listing.tourId);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }
    }
}