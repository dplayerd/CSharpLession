using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LInkTo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Request.QueryString["ID"] != null)
            {
                this.Label1.Text = this.Request.QueryString["ID"];
            }
            else
            {
                this.Label1.Text = "No ID in Query.";
            }
        }
    }
}