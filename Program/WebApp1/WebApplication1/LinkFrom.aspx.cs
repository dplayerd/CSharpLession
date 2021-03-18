using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LinkFrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.aLink.HRef = "http://www.google.com";
            this.aLink.HRef = "LinkTo.aspx?ID=Help";
            this.aLink.Target = "_blank";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/LinkTo.aspx?ID=Help");
        }
    }
}