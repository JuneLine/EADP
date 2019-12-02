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

            List<Product> empList = new List<BLL.Product>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int id = Convert.ToInt16(row["Id"].ToString());
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"].ToString());
                string categoryID = row["CategoryId"].ToString();
                string describtion = row["Describtion"].ToString();
                string pictureName = row["PictureName"].ToString();
                Product obj = new Product(id, name, price, categoryID, describtion, pictureName);
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
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                int id = Convert.ToInt16(row["Id"].ToString());
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"].ToString());
                string categoryID = row["CategoryId"].ToString();
                string describtion = row["Describtion"].ToString();
                string pictureName = row["PictureName"].ToString();
                prod = new Product(id, name, price, categoryID, describtion, pictureName);
            }
            else
            {
                prod = null;
            }
            return prod;

        }
    }

}