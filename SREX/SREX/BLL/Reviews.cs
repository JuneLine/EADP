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
        public string username { get; set; }
        public string Comments { get; set; }
        public string date { get; set; }
        public decimal rating { get; set; }
        public bool IsMe { get; set; }

        public Reviews()
        {

        }

        public Reviews(string id, string userId, string username, string Comments, string date, decimal rating)
        {
            this.Id = id;
            this.userId = userId;
            this.username = username;
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

        public List<Reviews> GetAllComments(string user)
        {
            ReviewsDAO rows = new ReviewsDAO();
            List<Reviews> List = rows.RetrieveAllComment();
            for(int i = 0;i < List.Count; i++)
            {
                if(List[i].userId == user)
                {
                    List[i].IsMe = true;
                }
                else
                {
                    List[i].IsMe = false;
                }
            }
            return List;            
        }            
    }
}