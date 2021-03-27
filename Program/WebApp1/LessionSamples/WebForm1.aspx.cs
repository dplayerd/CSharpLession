using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessionSamples
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Site1 masterPage = (this.Master as Site1);
            //masterPage.HeaderText = "This is set by page";

            masterPage.SType = Site1.SourceType.Outter;

            masterPage.SetHeaderText("Header Text");
        }
    }
}