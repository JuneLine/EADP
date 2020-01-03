﻿using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREX.BLL
{
    public class Purchase
    {
        public string OrderID { get; set; }
        public decimal Price { get; set; }
        public string DateOfPurchase { get; set; }
        public string UserID { get; set; }

        public Purchase()
        {

        }

        public Purchase(string orderID, decimal price, string dateOfPurchase, string userID)
        {
            this.OrderID = orderID;
            this.Price = price;
            this.DateOfPurchase = dateOfPurchase;
            this.UserID = userID;
        }

        public int checkOut(string userId, string OrderId, decimal Amount)
        {
            PurchaseDAO purchaseDAO = new PurchaseDAO();
            int result = purchaseDAO.checkoutAllCurrentItems(userId, Amount, OrderId);
            return result;
        }

        public List<Purchase> getBuyHistory(string userId)
        {
            PurchaseDAO purchaseDAO = new PurchaseDAO();
            List<Purchase> History = purchaseDAO.getPurchaseHistory(userId);
            return History;
        }
    }
}