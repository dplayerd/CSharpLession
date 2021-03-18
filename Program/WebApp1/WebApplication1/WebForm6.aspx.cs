using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //this.DropDownList1.SelectedValue = "2";

                this.DropDownList1.Items.Clear();

                this.DropDownList1.Items.Add(
                    new ListItem("Item1", "1")
                    );
                this.DropDownList1.Items.Add(
                    new ListItem("Text", "32")
                    );
                this.DropDownList1.Items.Add(
                    new ListItem("Text2", "33")
                    );
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string val1 =
                this.DropDownList1.SelectedValue;

            if (val1 == "1")
            {
                this.lblMsg.Text = "First Item Picked.";
            }
            else if (val1 == "2")
            {
                this.lblMsg.Text = "Second Item Picked.";
            }
            else
            {
                this.lblMsg.Text = "Error!";
            }
        }
    }
}