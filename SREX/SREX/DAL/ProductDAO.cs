using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using SREX.BLL;
using System.Data;

namespace SREX.DAL
{
    public class ProductDAO
    {

        public List<Product> SelectAllByCategory(string categoryId)
        {
            
            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Products where CategoryId = @paraCategory", con);
            sda.SelectCommand.Parameters.AddWithValue("@paraCategory", categoryId);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            List<Product> empList = new List<Product>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string id = row["Id"].ToString();
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"].ToString());
                string categoryID = row["CategoryId"].ToString();
                string describtion = row["Description"].ToString();
                string pictureName = row["PictureName"].ToString();
                int inStock = Convert.ToInt16(row["InStock"].ToString());
                int sold = Convert.ToInt16(row["Sold"].ToString());
                Product obj = new Product(id, name, price, categoryID, describtion, pictureName,inStock,sold);
                empList.Add(obj);
            }

            return empList;
        }

        public Product SelectByProductId(string productID)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Products where Id = @paraProductId", con);
            sda.SelectCommand.Parameters.AddWithValue("@paraProductId", productID);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            Product prod = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string id = row["Id"].ToString();
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"].ToString());
                string categoryID = row["CategoryId"].ToString();
                string describtion = row["Description"].ToString();
                string pictureName = row["PictureName"].ToString();
                int inStock = Convert.ToInt16(row["InStock"].ToString());
                int sold = Convert.ToInt16(row["Sold"].ToString());
                prod = new Product(id, name, price, categoryID, describtion, pictureName,inStock,sold);
            }
            else
            {
                prod = null;
            }
            return prod;

        }

        public int UpdateByProductId(string productID,string productName, decimal price, string categoryId,string description, string imageName, int inStock)
        {
            int result = 0;
            SqlCommand sqlCmd = new SqlCommand();

            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);
            string sqlStmt = "Update Products set Name=@paraProductName, Price=@paraPrice, CategoryId=@paraCategoryId, Description = @paraDesc, PictureName = @paraImageName, Instock=@paraInStock where Id = @paraProductId";
            sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraProductId",productID);
            sqlCmd.Parameters.AddWithValue("@paraProductName", productName);
            sqlCmd.Parameters.AddWithValue("@paraPrice", price);
            sqlCmd.Parameters.AddWithValue("@paraCategoryId", categoryId);
            sqlCmd.Parameters.AddWithValue("@paraDesc", description);
            sqlCmd.Parameters.AddWithValue("@paraImageName", imageName);
            sqlCmd.Parameters.AddWithValue("@paraInStock", inStock);
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();
            return result;

        }

        public List<Product> SelectTopFourItems()
        {

            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlDataAdapter sda = new SqlDataAdapter("Select top 4 * from Products Order by sold desc ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            List<Product> empList = new List<Product>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string id = row["Id"].ToString();
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"].ToString());
                string categoryID = row["CategoryId"].ToString();
                string describtion = row["Description"].ToString();
                string pictureName = row["PictureName"].ToString();
                int inStock = Convert.ToInt16(row["InStock"].ToString());
                int sold = Convert.ToInt16(row["Sold"].ToString());
                Product obj = new Product(id, name, price, categoryID, describtion, pictureName, inStock, sold);
                empList.Add(obj);
            }

            return empList;
        }

        public List<Product> SelectByKeyword(string keyword)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Products where Name like @paraKeyword", con);
            sda.SelectCommand.Parameters.AddWithValue("@paraKeyword", "%" + keyword + "%");
            DataSet ds = new DataSet();
            sda.Fill(ds);

            List<Product> empList = new List<Product>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string id = row["Id"].ToString();
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"].ToString());
                string categoryID = row["CategoryId"].ToString();
                string describtion = row["Description"].ToString();
                string pictureName = row["PictureName"].ToString();
                int inStock = Convert.ToInt16(row["InStock"].ToString());
                int sold = Convert.ToInt16(row["Sold"].ToString());
                Product obj = new Product(id, name, price, categoryID, describtion, pictureName, inStock, sold);
                empList.Add(obj);
            }

            return empList;
        }

        public int InsertProduct(Product Prod)
        {
            int result = 0;
            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"INSERT INTO Products (Id,Name, Price, CategoryId, Description, PictureName, InStock, Sold) 
VALUES (@paraId, @paraName, @paraPrice, @paraCategoryId, @paraDescription, @paraPicture, @paraInstock, @paraSold)";

            SQLCmd = new SqlCommand(sqlStmt, Connection);
            SQLCmd.Parameters.AddWithValue("@paraId", Guid.NewGuid().ToString());
            SQLCmd.Parameters.AddWithValue("@paraName", Prod.Name);
            SQLCmd.Parameters.AddWithValue("@paraPrice", Prod.Price);
            SQLCmd.Parameters.AddWithValue("@paraCategoryId", Prod.CategoryId);
            SQLCmd.Parameters.AddWithValue("@paraDescription", Prod.Description);
            SQLCmd.Parameters.AddWithValue("@paraPicture", Prod.PictureName);
            SQLCmd.Parameters.AddWithValue("@paraInstock", Prod.InStock);
            SQLCmd.Parameters.AddWithValue("@paraSold", Prod.Sold);

            Connection.Open();
            result = SQLCmd.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public List<Product> ValidateExisitingProduct(string product, string imageName)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products WHERE Name = @paraProductName OR PictureName = @paraImage", con);
            sda.SelectCommand.Parameters.AddWithValue("@paraProductName", product);
            sda.SelectCommand.Parameters.AddWithValue("@paraImage", imageName);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            List<Product> prodList = new List<Product>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string id = row["Id"].ToString();
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"].ToString());
                string categoryID = row["CategoryId"].ToString();
                string describtion = row["Description"].ToString();
                string pictureName = row["PictureName"].ToString();
                int inStock = Convert.ToInt16(row["InStock"].ToString());
                int sold = Convert.ToInt16(row["Sold"].ToString());
                Product obj = new Product(id, name, price, categoryID, describtion, pictureName, inStock, sold);
                prodList.Add(obj);
            }

            return prodList;
        }

        public List<Product> getLowStockProducts()
        {
            List<Product> lowStockList = new List<Product>();

            SqlCommand SQLCmd = new SqlCommand();

            string ConnectDB = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectDB);

            string sqlStmt = @"SELECT Products.Id, Products.Name, Products.InStock, Categories.Name as Category FROM Products INNER JOIN Categories ON Products.CategoryId = Categories.Id WHERE InStock <= 20 ORDER BY InStock ASC";

            SQLCmd = new SqlCommand(sqlStmt, Connection);

            Connection.Open();
            SqlDataReader dr = SQLCmd.ExecuteReader();
            while (dr.Read())
            {
                string id = dr["Id"].ToString();
                string name = dr["Name"].ToString();
                int inStock = Convert.ToInt32(dr["InStock"]);
                string catName = dr["Category"].ToString();

                Product lowItem = new Product
                {
                    Id = id,
                    Name = name,
                    InStock = inStock,
                    Category = catName,
                };
                lowStockList.Add(lowItem);
            }
            return lowStockList;
        }
    }

}