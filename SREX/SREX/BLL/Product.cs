using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{

    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public string Description { get; set; }
        public string PictureName { get; set; }
        public int InStock { get; set; }
        public int Sold { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }

        public Product()
        {

        }

        public Product(string Id, string Name, decimal Price, string CategoryId, string Description, string PictureName, int InStock,int Sold)
        {
            this.Id =Id; 
            this.Name = Name;
            this.Price = Price;
            this.CategoryId = CategoryId;
            this.Description = Description;
            this.PictureName = PictureName;
            this.InStock = InStock;
            this.Sold = Sold;
        }

        public List<Product> GetAllProductsByCategory(string categoryID)
        {
            ProductDAO dao = new ProductDAO();
            return dao.SelectAllByCategory(categoryID);
        }

        public List<Product> GetTopFourPopularProduct()
        {
            ProductDAO dao = new ProductDAO();
            return dao.SelectTopFourItems();
        }

        public Product GetProductDetail(string productID)
        {
            ProductDAO dao = new ProductDAO();
            return dao.SelectByProductId(productID);
        }

        public int UpdateProductInfo(string productID, string productName, decimal prodPrice, string categoryId, string description, string pictureName, int inStock)
        {
            ProductDAO dao = new ProductDAO();
            return dao.UpdateByProductId(productID,productName,prodPrice,categoryId,description,pictureName,inStock);
        }

        public List<Product> GetProductByKeyword(string keyword)
        {
            ProductDAO dao = new ProductDAO();
            return dao.SelectByKeyword(keyword);
        }

        public int InsertProduct()
        {
            ProductDAO dao = new ProductDAO();
            int result = dao.InsertProduct(this);
            return result;
        }

        public List<Product> ValidateProduct(string productName, string imageName)
        {
            ProductDAO prod = new ProductDAO();
            List<Product> prodList = prod.ValidateExisitingProduct(productName, imageName);
            return prodList;
        }

        public List<Product> getLowStock()
        {
            ProductDAO dao = new ProductDAO();
            List<Product> lowStockList = dao.getLowStockProducts();
            return lowStockList;
        }
    }
}