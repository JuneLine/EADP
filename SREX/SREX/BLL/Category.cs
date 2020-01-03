using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Category()
        {

        }

        public Category(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public List<Category> GetAllCategory()
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.SelectAll();
        }
    }
}