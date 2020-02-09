using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class TourGuides
    {
        public string UniqueId { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public string EmailAddr { get; set; }
        public string UploadFile { get; set; }
        public TourGuides()
        {
        }

        public TourGuides(string UniqueId, string UserName, string Gender, string Email, string UploadFile)
        {
            this.UniqueId = UniqueId;
            this.UserName = UserName;
            this.Gender = Gender;
            this.EmailAddr = Email;
            this.UploadFile = UploadFile;
        }

        public TourGuides(string UniqueId, string UserName, string Gender, string Email)
        {
            this.UniqueId = UniqueId;
            this.UserName = UserName;
            this.Gender = Gender;
            this.EmailAddr = Email;
        }

        public List<TourGuides> getApplications(string yes)
        {
            TourGuidesDAO dao = new TourGuidesDAO();
            return dao.getApplications(yes);
        }

        public int UpdTDbyID(string status, string id)
        {
            TourGuidesDAO dao = new TourGuidesDAO();
            return dao.UpdateRole(status, id);
        }

        public int UpdTdbyIDDenied(string status, string id)
        {
            TourGuidesDAO dao = new TourGuidesDAO();
            return dao.UpdateStatusDeny(status, id);
        }
        public int UpdStatusbyID(string status, string id)
        {
            TourGuidesDAO dao = new TourGuidesDAO();
            return dao.UpdateStatus(status, id);
        }

        public List<TourGuides> getTourGuide(string role)
        {
            TourGuidesDAO dao = new TourGuidesDAO();
            return dao.getTourGuide(role);
        }
    }
}