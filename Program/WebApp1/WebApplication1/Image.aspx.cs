using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Image : System.Web.UI.Page
    {

        public string AAA = "123"; 
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Image1.ImageUrl = "https://1.bp.blogspot.com/-WusqFXyxZyE/X9lJsqgJy7I/AAAAAAABc8M/gyc7RdN77JQPZfGa-rrjL7OMIzvpr4XcgCNcBGAsYHQ/s400/yukata_kids_couple.png";


            Response.Write("123");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string val = this.DropDownList1.SelectedValue;

            if (val == "1")
            {
                this.PlaceHolder1.Visible = true;
                this.Image1.Visible = false;
            }
            else
            {
                this.PlaceHolder1.Visible = false;
                this.Image1.Visible = true;
            }
        }
    }
}