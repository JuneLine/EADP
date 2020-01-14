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
            string Time = dr["Time"].ToString();
            string Activity = dr["Activity"].ToString();

            GuideTour Reader2 = new GuideTour
            {
                Time = Time,
                Activity = Activity,
                tourId = tourId
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

            string sqlStmt = "Select * from TourInfo where tourId = @paratourId";

            SqlCommand SQLCmd = new SqlCommand(sqlStmt, Connection);
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

            string sqlStmt = @"INSERT INTO TourInfo(tourInfoId, Time, Activity, tourId) " +
            "VALUES(@paratourInfoId, @paraTime, @paraActivity, @paratourId)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paratourInfoId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@paraTime", List.Time);
            SQLCmd.Parameters.AddWithValue("@paraActivity", List.Activity);
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