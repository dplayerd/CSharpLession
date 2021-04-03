using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessionSamples
{

    public partial class StatusViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int? val = (this.Session["key1"]) as int?;

            if (val.HasValue)
                this.Literal1.Text = val.Value.ToString();
            else
                this.Literal1.Text = "--";
        }
    }
}