using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class ProductInfo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string productId = Request.QueryString["productId"];
                if (!string.IsNullOrEmpty(productId))
                {
                    Product prod = new Product();
                    prod = prod.GetProductDetail(productId);
                    lbName.Text = prod.Name;
                }
                
            }
        }
    }
}