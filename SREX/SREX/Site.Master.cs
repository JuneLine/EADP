using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["email"] != null)
                {
                    liLogin.Style["display"] = "none";
                    liLogout.Style["display"] = "block";
                }
                else
                {
                    liLogin.Style["display"] = "block";
                    liLogout.Style["display"] = "none";
                }
            }
        }
    }
}