using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlPratice
{
    public partial class ucPractice : System.Web.UI.UserControl
    {
        public string UCName { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            { 
            this.ltMsg.Text = "This is literal in UC" + this.UCName;
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            this.ltMsg.Text = " -- ";
        }
    }
}