using System;
using System.Collections.Generic;
using SREX.BLL;

namespace SREX
{
    public partial class ProductList : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> productsList;
            if (!IsPostBack)
            {
                string categoryId = Request.QueryString["category"];
                string keyword = Request.QueryString["keyword"];
                if (Request.QueryString["category"]!=null)
                {
                    Product prod = new Product();
                    productsList = prod.GetAllProductsByCategory(categoryId);
                    DataList1.DataSource = productsList;
                    DataList1.DataBind();
                }
                else if (Request.QueryString["keyword"]!=null)
                {
                    Product prod = new Product();
                    productsList = prod.GetProductByKeyword(keyword);
                    DataList1.DataSource = productsList;
                    DataList1.DataBind();
                }
                
            }

        }

    }
}