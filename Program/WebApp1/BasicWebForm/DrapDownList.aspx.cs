using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebForm
{
    public partial class DrapDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string temp = this.DropDownList1.SelectedValue;
            this.Label1.Text = $"您喜歡 {temp} 呀";
        }
    }
}