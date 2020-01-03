using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SREX.DAL
{
    public class CartItemDAO
    {
        public int InsertItemToCart(CartItem cItem)
        {
            // Execute NonQuery return an integer value
            int result = 0;
            SqlCommand sqlCmd = new SqlCommand();

            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Instantiate SqlCommand instance to add record 
            //          with INSERT statement
            string sqlStmt = "INSERT INTO CartItem (Id, ProductId, Quantity, UserId) " +
                "VALUES (@paraId,@paraProdId, @paraQuantity, @paraUserId)";
            sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraId", cItem.Id);
            sqlCmd.Parameters.AddWithValue("@paraProdId", cItem.ProductId);
            sqlCmd.Parameters.AddWithValue("@paraQuantity", cItem.Quantity);
            sqlCmd.Parameters.AddWithValue("@paraUserId", cItem.UserId);


            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }

        public int DeleteItemFromCart(string productId, string userId)
        {
            // Execute NonQuery return an integer value
            int result = 0;
            SqlCommand sqlCmd = new SqlCommand();

            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Instantiate SqlCommand instance to add record 
            //          with INSERT statement
            string sqlStmt = "DELETE FROM CartItem WHERE ProductId=@paraProdId AND UserId=@paraUserId and Status='Active'";
            sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraProdId", productId);
            sqlCmd.Parameters.AddWithValue("@paraUserId", userId);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }

        public List<CartItem> SelectAllByUserId(string userID)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Select ci.Quantity, ci.UserId, ci.Id, pd.Id ProductId, pd.Price, pd.CategoryId, pd.Description, pd.PictureName, pd.InStock, pd.Sold, pd.Name from CartItem ci inner join Products pd on ci.ProductId = pd.id where ci.userId= @paraUserId and Status='Active'";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraUserId", userID);
            DataSet ds = new DataSet();
            da.Fill(ds);

            List<CartItem> cartItemList = new List<CartItem>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string id = row["Id"].ToString();
                string productId = row["ProductId"].ToString();
                int quantity = Convert.ToInt16(row["Quantity"]);
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"].ToString());
                string categoryID = row["CategoryId"].ToString();
                string description = row["Description"].ToString();
                string pictureName = row["PictureName"].ToString();
                int inStock = Convert.ToInt16(row["InStock"].ToString());
                int sold = Convert.ToInt16(row["Sold"].ToString());
                Product prod = new Product
                {
                    Id = productId,
                    Name = name,
                    Price = price,
                    CategoryId = categoryID,
                    Description = description,
                    PictureName = pictureName,
                    InStock = inStock,
                    Sold = sold
                };
                CartItem cartItem = new CartItem
                {
                    Id = id,
                    ProductId = productId,
                    Quantity = quantity,
                    Prod = prod,
                };
                cartItemList.Add(cartItem);
            }
            return cartItemList;
        }

        public List<CartItem> ValidateExisitingItem(string productId, string userId)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from CartItem where ProductId=@paraProdId and UserId=@paraUserId and Status='Active'", con);
            DataSet ds = new DataSet();
            sda.SelectCommand.Parameters.AddWithValue("@paraProdId", productId);
            sda.SelectCommand.Parameters.AddWithValue("@paraUserId", userId);
            sda.Fill(ds);


            List<CartItem> empList = new List<CartItem>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string id = row["Id"].ToString();
                string productID = row["ProductId"].ToString();
                int quantity = Convert.ToInt16(row["Quantity"].ToString());
                string userID = row["UserId"].ToString();
                CartItem obj = new CartItem(productID, quantity, userID);
                empList.Add(obj);
            }

            return empList;
        }

        public List<CartItem> getSoldItem(string userId)
        {
            List<CartItem> Purchases = new List<CartItem>();

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"SELECT * FROM CartItem INNER JOIN Products ON CartItem.ProductId = Products.Id WHERE UserId = @paraUserID AND Status = 'Paid'";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            SQLCmd.Parameters.AddWithValue("@paraUserID", userId);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                string id = dr["Id"].ToString();
                string productId = dr["ProductId"].ToString();
                int quantity = Convert.ToInt16(dr["Quantity"]);
                string UserId = dr["UserId"].ToString();
                string Status = dr["Status"].ToString();
                string OrderID = dr["OrderID"].ToString();
                string name = dr["Name"].ToString();
                decimal price = Convert.ToDecimal(dr["Price"].ToString());
                string categoryID = dr["CategoryId"].ToString();
                string description = dr["Description"].ToString();
                string pictureName = dr["PictureName"].ToString();
                int inStock = Convert.ToInt16(dr["InStock"].ToString());
                int sold = Convert.ToInt16(dr["Sold"].ToString());
                Product prod = new Product
                {
                    Id = productId,
                    Name = name,
                    Price = price,
                    CategoryId = categoryID,
                    Description = description,
                    PictureName = pictureName,
                    InStock = inStock,
                    Sold = sold
                };
                CartItem cartItem = new CartItem
                {
                    Id = id,
                    ProductId = productId,
                    Quantity = quantity,
                    UserId = UserId,
                    Status = Status,
                    OrderID = OrderID,
                    Prod = prod,
                };
                Purchases.Add(cartItem);
            }
            return Purchases;
        }
    }
}