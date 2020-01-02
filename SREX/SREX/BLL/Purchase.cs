using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class Purchase
    {
        public string ProductGroupID { get; set; }
        public string OrderID { get; set; }
        public decimal Amount { get; set; }

        public Purchase()
        {

        }

        public Purchase(string productgroupID, string orderID, decimal amount)
        {
            this.ProductGroupID = productgroupID;
            this.OrderID = orderID;
            this.Amount = amount;
        }

        public int checkOut(string userId, string OrderId, decimal Amount)
        {
            PurchaseDAO purchaseDAO = new PurchaseDAO();
            int result = purchaseDAO.checkoutAllCurrentItems(userId, Amount, OrderId);
            return result;
        }
    }
}