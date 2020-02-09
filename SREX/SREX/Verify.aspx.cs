using SREX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class Verify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                string Code = Request.QueryString["id"];
                CustomerDAO Cust = new CustomerDAO();
                int result = Cust.verifyRegisterCode(Code);
                if (result == 1)
                {
                    failure.Visible = false;
                }
                else
                {
                    success.Visible = false;
                }
            }
            else
            {
                Response.Redirect("/login");
            }
        }
    }
}