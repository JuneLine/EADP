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
        public string Time1 { get; set; }
        public string Activity1 { get; set; }
        public string Time2 { get; set; }
        public string Activity2 { get; set; }
        public string Time3 { get; set; }
        public string Activity3 { get; set; }
        public string Time4 { get; set; }
        public string Activity4 { get; set; }
        public string Time5 { get; set; }
        public string Activity5 { get; set; }
        public string Time6 { get; set; }
        public string Activity6 { get; set; }
        public string Time7 { get; set; }
        public string Activity7 { get; set; }


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

        //public GuideTour(string tourId, string Date, string meetUpTime, string meetUpLocation, decimal AdultCost, decimal ChildCost, decimal SeniorCost)
        //{
        //    this.tourId = tourId;
        //    this.Date = Date;
        //    this.meetUpTime = meetUpTime;
        //    this.meetUpLocation = meetUpLocation;
        //    this.AdultCost = AdultCost;
        //    this.ChildCost = ChildCost;
        //    this.SeniorCost = SeniorCost;
        //}

        public GuideTour(string tourInfoId, string Time1, string Activity1, string Time2, string Activity2, string Time3, string Activity3, string Time4, string Activity4, string Time5, string Activity5, string Time6, string Activity6, string Time7, string Activity7, string tourId)
        {
            this.tourInfoId = tourInfoId;
            this.Time1 = Time1;
            this.Time2 = Time2;
            this.Time3 = Time3;
            this.Time4 = Time4;
            this.Time5 = Time5;
            this.Time6 = Time6;
            this.Time7 = Time7;
            this.Activity1 = Activity1;
            this.Activity2 = Activity2;
            this.Activity3 = Activity3;
            this.Activity4 = Activity4;
            this.Activity5 = Activity5;
            this.Activity6 = Activity6;
            this.Activity7 = Activity7;
            this.tourId = tourId;
        }


        public GuideTour(string PurchaseId, string Date, string Name, string Email, string Contact, int AdultQuantity, int ChildQuantity, int SeniorQuantity, decimal Payment, string userId, string tourName,string tourId)
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
            this.tourName = tourName;
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

        public List<GuideTour> GetOneID(string name, string picture, string caption)
        {
            GuideTourDAO TourOne = new GuideTourDAO();
            return TourOne.RetrieveSpecificID(name, picture, caption);
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

        public int UpdateGuideTour(string tourId, string tourName, string tourPic, string tourCaption, string Date, string meetUpTime, string meetUpLocation, decimal AdultCost, decimal ChildCost, decimal SeniorCost)
        {
            GuideTourDAO info = new GuideTourDAO();
            return info.UpdateTour(tourId,tourName,tourPic,tourCaption,Date,meetUpTime,meetUpLocation,AdultCost,ChildCost,SeniorCost);
        }

        public int UpdateGuideTourInfo(string Time1, string Activity1, string Time2, string Activity2, string Time3, string Activity3, string Time4, string Activity4, string Time5, string Activity5, string Time6, string Activity6, string Time7, string Activity7, string tourId)
        {
            GuideTourDAO details = new GuideTourDAO();
            return details.UpdateTourInfo(Time1, Activity1, Time2, Activity2, Time3, Activity3, Time4, Activity4, Time5, Activity5, Time6, Activity6, Time7, Activity7, tourId);
        }

        //For Histories
        public List<GuideTour> GetHist(string userId)
        {
            GuideTourDAO History = new GuideTourDAO();
            return History.RetrievePurchasesHist(userId);
        }

        public List<GuideTour> GetOneHist(string id, string userId)
        {
            GuideTourDAO History = new GuideTourDAO();
            return History.RetrieveSpecificPurchase(id, userId);
        }

        public int CreatePurchases()
        {
            GuideTourDAO List = new GuideTourDAO();
            int result = List.InsertPurchases(this);
            return result;
        }

        //For Admin
        public List<GuideTour> GetListTour()
        {
            GuideTourDAO TourOne = new GuideTourDAO();
            return TourOne.RetrieveListOfTour();
        }

        //public List<GuideTour> GetSearchList(string Name)
        //{
        //    GuideTourDAO Search = new GuideTourDAO();
        //    return Search.RetrieveSpecificListOfTour(Name);
        //}


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