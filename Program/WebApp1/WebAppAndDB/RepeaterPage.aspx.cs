using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAndDB
{
    public partial class RepeaterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt =
                DataBaseExecutor.ReadTestTable1DT();
            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || 
                e.Item.ItemType == ListItemType.AlternatingItem)
            {
                // 取得原資料
                var drv = e.Item.DataItem as DataRowView;

                // 取得控制項
                Literal lt = e.Item.FindControl("ltlName") as Literal;

                if (lt != null)
                {
                    lt.Text += $" <br/> {drv["NumberCol"]} <br/>";
                }
            }
        }
    }
}