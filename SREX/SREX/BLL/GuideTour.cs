using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class GuideTour
    {
        public string tourId { get; set; }
        public string userId { get; set; }
        public string Date { get; set; }

        //ForFirstDB [GuideTour]
        public string tourName { get; set; }
        public string tourPic { get; set; }
        public string tourCaption { get; set; }
        public string meetUpTime { get; set; }
        public string meetUpLocation { get; set; }
        public decimal AdultCost { get; set; }
        public decimal ChildCost { get; set; }
        public decimal SeniorCost { get; set; }

        //ForSecondDB [TourInfo]
        public string tourInfoId { get; set; }
        public string Time { get; set; }
        public string Activity { get; set; }

        //ForThirdDB [GuidePurchases]
        public string PurchaseId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserContact { get; set; }
        public int AdultQuantity { get; set; }
        public int ChildQuantity { get; set; }
        public int SeniorQuantity { get; set; }
        public decimal PaymentAmount { get; set; }

        public GuideTour()
        {

        }

        public GuideTour(string tourId, string tourName, string tourPic, string tourCaption, string Date, string meetUpTime, string meetUpLocation, decimal AdultCost, decimal ChildCost, decimal SeniorCost)
        {
            this.tourId = tourId;
            this.tourName = tourName;
            this.tourPic = tourPic;
            this.tourCaption = tourCaption;
            this.Date = Date;
            this.meetUpTime = meetUpTime;
            this.meetUpLocation = meetUpLocation;
            this.AdultCost = AdultCost;
            this.ChildCost = ChildCost;
            this.SeniorCost = SeniorCost;
        }

        public GuideTour(string tourId, string Date, string meetUpTime, string meetUpLocation, decimal AdultCost, decimal ChildCost, decimal SeniorCost, string Time, string Activty)
        {
            this.tourId = tourId;
            this.Date = Date;
            this.meetUpTime = meetUpTime;
            this.meetUpLocation = meetUpLocation;
            this.AdultCost = AdultCost;
            this.ChildCost = ChildCost;
            this.SeniorCost = SeniorCost;
            this.Time = Time;
            this.Activity = Activity;
        }

        public GuideTour(string tourInfoId, string Time, string Activty, string tourId)
        {
            this.tourInfoId = tourInfoId;
            this.Time = Time;
            this.Activity = Activity;
            this.tourId = tourId;
        }

        public GuideTour(string PurchaseId, string Date, string Name, string Email, string Contact, int AdultQuantity, int ChildQuantity, int SeniorQuantity, decimal Payment, string userId, string tourId)
        {
            this.PurchaseId = PurchaseId;
            this.Date = Date;
            this.UserName = Name;
            this.UserEmail = Email;
            this.UserContact = Contact;
            this.AdultQuantity = AdultQuantity;
            this.ChildQuantity = ChildQuantity;
            this.SeniorQuantity = SeniorQuantity;
            this.PaymentAmount = Payment;
            this.userId = userId;
            this.tourId = tourId;
        }

        //For GuidedTour
        public List<GuideTour> GetAll()
        {
            GuideTourDAO TourMain = new GuideTourDAO();
            return TourMain.RetrieveAllGuide();
        }

        public List<GuideTour> GetOne(string tourId)
        {
            GuideTourDAO TourOne = new GuideTourDAO();
            return TourOne.RetrieveSpecificEvent(tourId);
        }

        public List<GuideTour> GetOneInfo(string tourId)
        {
            GuideTourDAO TourOne = new GuideTourDAO();
            return TourOne.RetrieveSpecificEventInfo(tourId);
        }

        public int CreateTour()
        {
            GuideTourDAO List = new GuideTourDAO();
            int result = List.InsertTour(this);
            return result;
        }

        public int CreateTourInfo()
        {
            GuideTourDAO List = new GuideTourDAO();
            int result = List.InsertTourActivity(this);
            return result;
        }

        //For Histories
        public List<GuideTour> GetHist(string userId)
        {
            GuideTourDAO History = new GuideTourDAO();
            return History.RetrievePurchasesHist(userId);
        }

        public int CreatePurchases()
        {
            GuideTourDAO List = new GuideTourDAO();
            int result = List.InsertPurchases(this);
            return result;
        }

        // Calculation
        public decimal CalculateCost(decimal Price, int Quantity)
        {
            decimal result = Price * Quantity;
            return result;
        }

        public decimal CalculateGST(decimal Cost)
        {
            decimal GST = 0.07m;
            decimal result = Cost * GST;
            return result;
        }

        public decimal CalculateService(decimal Cost)
        {
            decimal Service = 0.1m;
            decimal result = Cost * Service;
            return result;
        }
    }
}