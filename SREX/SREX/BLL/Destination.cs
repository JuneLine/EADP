using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class Destination
    {
        public string UniqueId { get; set; }
        public string DestinationName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Tag { get; set; }
        public string PictureName { get; set; }

        public Destination(string uniqueId, string destinationName, string pictureName, string description, string price, string tag)
        {
            this.UniqueId = uniqueId;
            this.PictureName = pictureName;
            this.DestinationName = destinationName;
            this.Description = description;
            this.Price = price;
            this.Tag = tag;

        }

        public Destination(string destinationName, string pictureName, string description, string price, string tag)
        {
            this.PictureName = pictureName;
            this.DestinationName = destinationName;
            this.Description = description;
            this.Price = price;
            this.Tag = tag;

        }

        public Destination()
        {
        }

        public List<Destination> GetAllDestination()
        {
            DestinationDAO dao = new DestinationDAO();
            return dao.SelectAll();
        }


        public List<Destination> searchDestination(string destinationName)
        {
            DestinationDAO dao = new DestinationDAO();
            return dao.SelectDestination(destinationName);
        }

        public int InsertDestination()
        {
            DestinationDAO dao = new DestinationDAO();
            int result = dao.InsertDestination(this);
            return result;
        }

        public Destination GetTDByUniqueId(int uniqueId)
        {
            DestinationDAO dao = new DestinationDAO();
            return dao.SelectByUniqueId(uniqueId);
        }

        public int SearchByPictureName(string pictureName)
        {
            DestinationDAO dao = new DestinationDAO();
            return dao.SearchByPictureName(pictureName);

        }
        public int UpdTDbyDestination(string description, string photoName, int uniqueId, string price, string tag)
        {
            DestinationDAO dao = new DestinationDAO();
            return dao.UpdateDescription(description, photoName, uniqueId, price, tag);
        }
    }
}