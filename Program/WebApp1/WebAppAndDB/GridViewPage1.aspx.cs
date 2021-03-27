using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAndDB
{
    public partial class GridViewPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource =
          DataBaseExecutor.ReadTestTable1DT();
            this.GridView1.DataBind();
        }
    }
}