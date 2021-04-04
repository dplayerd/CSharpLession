using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace LessionSamples
{
    public class PageBase : System.Web.UI.Page
    {
        public PlaceHolder Main { get; set; }

        //protected void Page_Init(object sender, EventArgs e)
        //{
        //    this.Main =
        //        this.FindControl("MainContent") as PlaceHolder;
        //}
    }
}