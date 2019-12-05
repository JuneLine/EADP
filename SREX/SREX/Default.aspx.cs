using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["role"] != null)
                {
                    lbRole.Text = Session["role"].ToString();
                    lbUsername.Text = Session["username"].ToString();
                }
                else
                {
                    lbRole.Text = string.Empty;
                }
            }

        }
    }
}