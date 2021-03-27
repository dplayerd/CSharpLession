using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlPratice
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ltPageTitle.Text = "Hello World!!";

            this.ltPageDesc.Text = "這是我第一個網頁接版成果，天保祐一切順利。";
        }
    }
}