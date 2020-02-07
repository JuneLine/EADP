using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class SelfPlan
    {
        private string uniqueId1;

        public string Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Hire { get; set; }
        public string Timing1 { get; set; }
        public string Timing2 { get; set; }
        public string Timing3 { get; set; }
        public string Timing4 { get; set; }
        public string Timing5 { get; set; }
        public string Timing6 { get; set; }
        public string Timing7 { get; set; }
        public string Timing8 { get; set; }
        public string Timing9 { get; set; }
        public string Timing10 { get; set; }
        public int UniqueId { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }

        public SelfPlan()
        {

        }

        public SelfPlan ( string Id, string Title, string Date, string Hire, string Timing1, string Timing2, string Timing3, string Timing4, string Timing5, string Timing6
            , string Timing7, string Timing8, string Timing9, string Timing10 ,string Status, string UserName)
        {
            this.Id = Id;
            this.Title = Title;
            this.Date = Date;
            this.Hire = Hire;
            this.Timing1 = Timing1;
            this.Timing2 = Timing2;
            this.Timing3 = Timing3;
            this.Timing4 = Timing4;
            this.Timing5 = Timing5;
            this.Timing6 = Timing6;
            this.Timing7 = Timing7;
            this.Timing8 = Timing8;
            this.Timing9 = Timing9;
            this.Timing10 = Timing10;
            this.Status = Status;
            this.UserName = UserName;
        }

        public SelfPlan(string Id, string Title, string Date, string Hire, string Timing1, string Timing2, string Timing3, string Timing4, string Timing5, string Timing6
            , string Timing7, string Timing8, string Timing9, string Timing10)
        {
            this.Id = Id;
            this.Title = Title;
            this.Date = Date;
            this.Hire = Hire;
            this.Timing1 = Timing1;
            this.Timing2 = Timing2;
            this.Timing3 = Timing3;
            this.Timing4 = Timing4;
            this.Timing5 = Timing5;
            this.Timing6 = Timing6;
            this.Timing7 = Timing7;
            this.Timing8 = Timing8;
            this.Timing9 = Timing9;
            this.Timing10 = Timing10;
        }

        public SelfPlan(int UniqueId, string userName, string Title, string Date, string Hire)
        {
            this.UniqueId = UniqueId;
            this.UserName = userName;
            this.Title = Title;
            this.Date = Date;
            this.Hire = Hire;
        }

        public int UpdTDbyID(string status, int id)
        {
            SelfPlanDAO dao = new SelfPlanDAO();
            return dao.UpdateStatus(status, id);
        }

        public int UpdTDbyUserId(string status, string id)
        {
            SelfPlanDAO dao = new SelfPlanDAO();
            return dao.UpdateApplication(status, id);
        }
        public int InsertHistory()
        {
            SelfPlanDAO dao = new SelfPlanDAO();
            int result = dao.InsertHistory(this);
            return result;

        }

        public List<SelfPlan> GetAllHistoryById(string Id)
        {
            SelfPlanDAO dao = new SelfPlanDAO();
            return dao.SelectAllById(Id);
        }

        public List<SelfPlan> getDestinationByTitle(string Id)
        {
            SelfPlanDAO dao = new SelfPlanDAO();
            return dao.SelectDestinationById(Id);
        }

        public SelfPlan getTDByUniqueId(int UniqueId)
        {
            SelfPlanDAO dao = new SelfPlanDAO();
            return dao.SelectByUniqueId(UniqueId);
        }

        public List<SelfPlan> getTourGuided(string hire)
        {
            SelfPlanDAO dao = new SelfPlanDAO();
            return dao.getTourGuided(hire);
        }
    }
}