using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public string Describtion { get; set; }
        public string PictureName { get; set; }

        public Product()
        {

        }

        public Product(int Id, string Name, decimal Price, string CategoryId, string Describtion, string PictureName)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.CategoryId = CategoryId;
            this.Describtion = Describtion;
            this.PictureName = PictureName;
        }

        public List<Product> GetAllProductsByCategory(string categoryID)
        {
            ProductDAO dao = new ProductDAO();
            return dao.SelectAllByCategory(categoryID);
        }

        public Product GetProductDetail(string productID)
        {
            ProductDAO dao = new ProductDAO();
            return dao.SelectByProductId(productID);
        }
    }



    
}