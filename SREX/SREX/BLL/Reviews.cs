using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class Reviews
    {
        public string Id { get; set; }
        public string userId { get; set; }
        public string Comments { get; set; }
        public string date { get; set; }
        public decimal rating { get; set; }

        public Reviews()
        {

        }

        public Reviews(string id, string userId, string Comments, string date, decimal rating)
        {
            this.Id = id;
            this.userId = userId;
            this.Comments = Comments;
            this.date = date;
            this.rating = rating;
        }

        public int CreateComment()
        {
            ReviewsDAO List = new ReviewsDAO();
            int result = List.InsertComment(this);
            return result;
        }

    }
}