using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessionSamples
{
    public partial class StatusItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Items["key1"] + "<br/>");
            Response.Write(Class1.GetItemValue() + "<br/>");
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Items["key1"] = "In button set value";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            //Response.Write(Items["key1"] + "<br/>");
            Response.Write(Class1.GetItemValue() + "<br/>");
        }
    }
}