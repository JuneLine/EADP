using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class Shopping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> topFourProductsList;
            if (!IsPostBack)
            {
                Session["deleteMsg"] = null;
                Product prod = new Product();
                topFourProductsList = prod.GetTopFourPopularProduct();
                DataList1.DataSource = topFourProductsList;
                DataList1.DataBind();
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals("Admin"))
                    {
                        catTitle.Attributes["Class"] = "section-heading text-right";
                        ButtonAddProd.Style["display"] = "block";
                        catDesign.Attributes["Class"] = "col-sm-7";
                        cat.Style["margin-top"] = "0px";
                        addProduct.Style["float"] = "right";
                        ButtonEditCrs.Style["float"] = "right";
                    }
                    else if(Session["Role"].Equals("User"))
                    {
                        catTitle.Attributes["Class"] = "section-heading text-center";
                        forAdmin1.Visible = false;
                        forAdmin2.Visible = false;
                    }
                }
                else
                {
                    catTitle.Attributes["Class"] = "section-heading text-center";
                    forAdmin1.Visible = false;
                    forAdmin2.Visible = false;
                }


            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductList?keyword=" + targetItem.Text.ToLower().ToString());
        }

        protected void btAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct");
        }

        protected void btEditCRS_Click(object sender, EventArgs e)
        {

        }

        
    }
}