using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessionSamples
{
    public partial class StatusWriter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            this.Session["key1"] = 123;
            this.Response.Write("Add success");
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            this.Session.Remove("key1");
            this.Response.Write("Remove success");
        }
    }
}