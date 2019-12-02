﻿using System;
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
                Product prod = new Product();
                productsList = prod.GetAllProductsByCategory(categoryId);
                DataList1.DataSource = productsList;
                DataList1.DataBind();
            }

        }

    }
}