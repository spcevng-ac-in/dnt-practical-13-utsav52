﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox2.Text.ToString() =="BLOCKCHAIN")
        {
            Session["username"] = TextBox1.Text.ToString();
            Response.Redirect("Welcome.aspx");
        }
        else
        {
            Label4.Text="Wrong password";
        }
    }
  }
