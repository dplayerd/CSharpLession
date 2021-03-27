using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAndDB
{
    public partial class RepeaterPage1 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            DataTable dt = DataBaseExecutor.ReadTestTable1DT();

            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || 
                e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Literal ltl =
                e.Item.FindControl("ltName") as Literal;

                if (ltl == null)
                    return;

                DataRowView drv =
                e.Item.DataItem as DataRowView;

                string name = drv["Name"].ToString();
                int? numberCol = drv.Row.Field<int?>("NumberCol");

                if(numberCol.HasValue && numberCol.Value == 3)
                    ltl.Text = "Success!!";
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string cmdName = e.CommandName;
            string cmdArgu = e.CommandArgument.ToString();

            if("DeleteItem" == cmdName)
            { 
                DataBaseExecutor.DeleteTestTable1(cmdArgu);

                DataTable dt = DataBaseExecutor.ReadTestTable1DT();

                this.Repeater1.DataSource = dt;
                this.Repeater1.DataBind();
            }


            if ("UpdateItem" == cmdName)
            {
                string targetUrl =
                    "~/RepeaterDetail.aspx?ID=" + cmdArgu;

                Response.Redirect(targetUrl);
            }
        }
    }
}