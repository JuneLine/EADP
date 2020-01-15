using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SREX
{
    public partial class Reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCfmEmail_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != "" && codebox.Style["display"] == "null")
            {
                emailbox.Style["display"] = "none";
                codebox.Style["display"] = "block";
            }
            Random r = new Random();
            string num = (r.Next(000000, 1000000)).ToString("D6");
            System.Diagnostics.Debug.WriteLine(num);
        }
    }
}