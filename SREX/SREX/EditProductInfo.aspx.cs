using SREX.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class EditProductInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string productId = Request.QueryString["productId"];
                Session["productId"] = productId;

                if (!string.IsNullOrEmpty(productId))
                {
                    Product prod = new Product();
                    prod = prod.GetProductDetail(productId);
                    productNameTB.Text = prod.Name;
                    productPriceTB.Text = prod.Price.ToString();
                    ProductDescTB.Text = prod.Description;
                    inStockTB.Text = prod.InStock.ToString();
                    ddlCategory.SelectedItem.Text = prod.CategoryId;
                    Session["imageInfo"] = prod.PictureName;
                    imageShow.ImageUrl = "Pictures/" + prod.PictureName;

                }
            }
        }

        protected void UpdateProductButton_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            string productId = Request.QueryString["productId"];
            prod = prod.GetProductDetail(productId);
            if (!string.IsNullOrEmpty(productId))
            {
                int result = prod.UpdateProductInfo(Session["productId"].ToString(), productNameTB.Text.ToString(),Convert.ToDecimal(productPriceTB.Text), ddlCategory.SelectedItem.Text.ToString(), ProductDescTB.Text.ToString(), Session["imageInfo"].ToString(), Convert.ToInt16(inStockTB.Text));
                if (result == 1)
                {
                    Response.Redirect("ProductInfo?productId=" + Session["productId"]);
                }
            }
        }

        protected void UploadImage_Click(object sender, EventArgs e)
        {
            if (FileLocation.HasFile)
            {
                imageShow.ImageUrl = "Pictures/" + FileLocation.PostedFile.FileName.ToString();
                Session["imageInfo"] = FileLocation.FileName;
            }
        }
    }
}