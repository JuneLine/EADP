using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SREX
{
    public partial class ElectricalDevices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            if (!IsPostBack)
            {
                string categoryId = Request.QueryString["category"];
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Products where CategoryId = '"+categoryId+"'" , con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();

            }
            
        }
    }
}