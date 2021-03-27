using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAndDB
{
    public partial class GridViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = DataBaseExecutor.ReadTestTable1DT();

            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}