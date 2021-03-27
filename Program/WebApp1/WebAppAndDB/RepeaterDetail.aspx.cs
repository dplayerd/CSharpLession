using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAndDB
{
    public partial class RepeaterDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["ID"];

            DataTable dt = DataBaseExecutor.ReadTestTable1OneRow(id);

            if (dt == null)
                return;

            this.txtBirthday.Text = dt.Rows[0]["Birthday"].ToString();
            this.txtName.Text = dt.Rows[0]["Name"].ToString();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["ID"];

            string birthday = this.txtBirthday.Text;
            string name = this.txtName.Text;

            DataBaseExecutor.UpdateTestTable1(id, name, birthday, "");

            string targetUrl = "~/RepeaterPage1.aspx";
            Response.Redirect(targetUrl);
        }
    }
}