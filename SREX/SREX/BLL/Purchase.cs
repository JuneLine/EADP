using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class Purchase
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }

        public Purchase()
        {

        }

        public Purchase(string productId, int quantity, string userId)
        {
            this.Id = Guid.NewGuid().ToString();
            this.ProductId = productId;
            this.Quantity = quantity;
            this.UserId = userId;
        }

        public int checkOut(string userId, string OrderId)
        {
            CartItemDAO dao = new CartItemDAO();
            List<CartItem> Cart = dao.SelectAllByUserId(userId);
            System.Diagnostics.Debug.WriteLine(Cart);
            return Cart.Count;
        }
    }
}