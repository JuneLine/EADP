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
                sortBySth.Text = "";
                Session["alertMessage"] = null;
                Session["deleteMsg"] = null;
                if (Request.QueryString["sortby"] == "Name" && Request.QueryString["order"] == "Asc")
                {
                    sortBySth.Text = SortByNameAsc.InnerText;
                }
                else if (Request.QueryString["sortby"] == "Name" && Request.QueryString["order"] == "Desc")
                {
                    sortBySth.Text = SortByNameDesc.InnerText;
                }
                else if (Request.QueryString["sortby"] == "Price" && Request.QueryString["order"] == "Asc")
                {
                    sortBySth.Text = SortByPriceAsc.InnerText;
                }
                else if (Request.QueryString["sortby"] == "Price" && Request.QueryString["order"] == "Desc")
                {
                    sortBySth.Text = SortByPriceDesc.InnerText;
                }
                else if (Request.QueryString["sortby"] == "Sold" && Request.QueryString["order"] == "Asc")
                {
                    sortBySth.Text = SortByPopularityAsc.InnerText;
                }
                else if (Request.QueryString["sortby"] == "Keyword" && Request.QueryString["order"] == "Asc")
                {
                    sortBySth.Text = SortByPopularityAsc.InnerText;
                }

                if (Request.QueryString["sortby"] == null && Request.QueryString["order"] == null)
                {
                    Response.Redirect("Shopping");
                }


                if (Request.QueryString["category"] != null && Request.QueryString["sortby"] != null && Request.QueryString["order"] != null)
                {
                    Product prod = new Product();
                    productsList = prod.GetAllProductsByCategoryWithSort(Request.QueryString["category"].ToString(), Request.QueryString["sortby"].ToString(), Request.QueryString["order"].ToString());
                    DataList1.DataSource = productsList;
                    DataList1.DataBind();
                    SortByNameAsc.Attributes["href"] = "ProductList?category=" + Request.QueryString["category"].ToString() + "&sortby=Name&order=Asc";
                    SortByNameDesc.Attributes["href"] = "ProductList?category=" + Request.QueryString["category"].ToString() + "&sortby=Name&order=Desc";
                    SortByPriceAsc.Attributes["href"] = "ProductList?category=" + Request.QueryString["category"].ToString() + "&sortby=Price&order=Asc";
                    SortByPriceDesc.Attributes["href"] = "ProductList?category=" + Request.QueryString["category"].ToString() + "&sortby=Price&order=Desc";
                    SortByPopularityAsc.Attributes["href"] = "ProductList?category=" + Request.QueryString["category"].ToString() + "&sortby=Sold&order=Asc";

                }
                if (Request.QueryString["keyword"] != null && Request.QueryString["sortby"] != null && Request.QueryString["order"] != null)
                {
                    if (Request.QueryString["keyword"] == "")
                    {
                        Response.Redirect("Shopping");
                    }
                    else
                    {
                        Product prod = new Product();
                        productsList = prod.GetProductByKeyword(Request.QueryString["keyword"].ToString(), Request.QueryString["sortby"].ToString(), Request.QueryString["order"].ToString());
                        DataList1.DataSource = productsList;
                        DataList1.DataBind();
                        SortByNameAsc.Attributes["href"] = "ProductList?keyword=" + Request.QueryString["keyword"].ToString() + "&sortby=Name&order=Asc";
                        SortByNameDesc.Attributes["href"] = "ProductList?keyword=" + Request.QueryString["keyword"].ToString() + "&sortby=Name&order=Desc";
                        SortByPriceAsc.Attributes["href"] = "ProductList?keyword=" + Request.QueryString["keyword"].ToString() + "&sortby=Price&order=Asc";
                        SortByPriceDesc.Attributes["href"] = "ProductList?keyword=" + Request.QueryString["keyword"].ToString() + "&sortby=Price&order=Desc";
                        SortByPopularityAsc.Attributes["href"] = "ProductList?keyword=" + Request.QueryString["keyword"].ToString() + "&sortby=Sold&order=Asc";

                    }
                }
            }

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductList?keyword=" + targetItem.Text.ToLower().ToString() + "&sortby=Sold&order=Asc");
        }

    }
}