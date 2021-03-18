﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;


namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Method1(object sender)
        {
            Button btn = (sender as Button);

            if (btn != null)
            {
                btn.Text = "123";
            }
        }


        private void Method2(object sender)
        {
            if (sender != null)
            {
                Button btn = (sender as Button);
                btn.Text = "123";
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            //Button btn2 = (Button)sender;

            if (btn.ID == this.Button1.ID)
            {
                this.lblMsg.ForeColor = Color.Red;
                this.lblMsg.Text = "This is traggle by Button1";
            }
            else
            { 
                this.lblMsg.ForeColor = Color.Blue;
                this.lblMsg.Text = "This is traggle by Button2";
            }
        }
    }
}