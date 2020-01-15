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
    public class CategoryDAO
    {
        public List<Category> SelectAllCategories()
        {

            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Categories", con);
            
            DataSet ds = new DataSet();
            sda.Fill(ds);

            List<Category> empList = new List<Category>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string id = row["Id"].ToString();
                string name = row["Name"].ToString();
                Category obj = new Category(id, name);
                empList.Add(obj);
            }

            return empList;
        }
    }
}