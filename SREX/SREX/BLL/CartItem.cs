using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SREX.BLL
{
    public class CartItem
    {

        public string Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
        public string OrderID { get; set; }
        public Product Prod { get; set; }
        public Customer Cust { get; set; }

        public CartItem()
        {

        }

        public CartItem(string productId, int quantity, string userId)
        {
            this.Id = Guid.NewGuid().ToString();
            this.ProductId = productId;
            this.Quantity = quantity;
            this.UserId = userId;
        }

        public int AddProductToShoppingCart()
        {
            CartItemDAO ItemDao = new CartItemDAO();
            int result = ItemDao.InsertItemToCart(this);
            return result;
        }

        public int DeleteProductFromCart(string productId, string userId)
        {
            CartItemDAO itemDAO = new CartItemDAO();
            int result = itemDAO.DeleteItemFromCart(productId, userId);
            return result;
        }

        public List<CartItem> GetCartItems(string userId)
        {
            CartItemDAO dao = new CartItemDAO();
            return dao.SelectAllByUserId(userId);
        }

        public List<CartItem> ValidateItem(string productId, string userId)
        {
            CartItemDAO dao = new CartItemDAO();
            return dao.ValidateExisitingItem(productId, userId);
        }

        public List<CartItem> getBoughtItems(string userId)
        {
            CartItemDAO dao = new CartItemDAO();
            return dao.getSoldItem(userId);
        }

        public List<CartItem> getSoldItemFromOrderId(string orderId)
        {
            CartItemDAO dao = new CartItemDAO();
            return dao.getSBoughtItemsFromOrderId(orderId);
        }

        public CartItem getUserDetailsFromOrderId(string orderId)
        {
            CartItemDAO dao = new CartItemDAO();
            return dao.getUserFromOrderId(orderId);
        }

        public List<CartItem> getPopularItems()
        {
            CartItemDAO dao = new CartItemDAO();
            return dao.getMostPopularItem();
        }
    }
}