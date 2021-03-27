using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAndDB
{
    public partial class RepeaterPrerenderEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt =
                DataBaseExecutor.ReadTestTable1DT();
            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();
        }

        protected void Repeater1_PreRender(object sender, EventArgs e)
        {
            foreach (RepeaterItem item in this.Repeater1.Items)
            {
                if (item.ItemType == ListItemType.Item || 
                    item.ItemType == ListItemType.AlternatingItem)
                {
                    Literal lt = item.FindControl("ltName") as Literal;
                    lt.Text += " <br/> End of Name <br/>";
                }
            }
        }
    }
}