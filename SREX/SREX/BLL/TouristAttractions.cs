using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class TouristAttractions
    {
        public string Id { get; set; }
        public string AttractionName { get; set; }
        public string Picture { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }

        public TouristAttractions(string Id, string AttractionName, string Picture, string URL, string Description)
        {
            this.Id = Id;
            this.AttractionName = AttractionName;
            this.Picture = Picture;
            this.URL = URL;
            this.Description = Description;
        }

        public TouristAttractions()
        {

        }

        public List<TouristAttractions> GetAll()
        {
            TouristAttractionsDAO AllAttractions = new TouristAttractionsDAO();
            return AllAttractions.RetrieveAll();
        }

        public TouristAttractions GetOne(string Id)
        {
            TouristAttractionsDAO OneAttractions = new TouristAttractionsDAO();
            return OneAttractions.RetrieveOne(Id);
        }

        public int CreateAttractions()
        {
            TouristAttractionsDAO List = new TouristAttractionsDAO();
            int result = List.InsertAttraction(this);
            return result;
        }

        public int UpdateAttractionInfo(string id, string Name, string Picture, string URL, string Description)
        {
            TouristAttractionsDAO info = new TouristAttractionsDAO();
            return info.UpdateAttraction(id, Name, Picture, URL, Description);
        }
    }
}