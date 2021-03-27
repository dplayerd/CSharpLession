using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessionSamples
{
    public partial class SamplePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = 
                DataBaseExecutor.ReadTestTable1DT();

            ucPager.TotalSize = dt.Rows.Count;
            ucPager.Url = "~/LessionSamples.aspx";
            ucPager.Bind();

            this.repList.DataSource = dt;
            this.repList.DataBind();
        }
    }
}