﻿using System;
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
                if (Session["Role"] != null)
                {
                    liLogin.Visible = false;
                    //liLogout.Style["display"] = "block";
                    dropdownMore.Style["display"] = "block";
                    if (Session["Role"].ToString() == "Admin")
                    {
                        AdminCP.Visible = true;
                        AdminList.Visible = true;
                    }
                }
                else
                {
                    liLogin.Style["display"] = "block";
                    //liLogout.Visible = false;
                    dropdownMore.Visible = false;                   
                }
            }
        }
    }
}