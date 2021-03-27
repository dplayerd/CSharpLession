using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAndDB
{
    public partial class DataTableToTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadDataTable();
        }

        private void LoadDataTable()
        {
            DataTable dt = 
                DataBaseExecutor.ReadTestTable1DT();
            string bodyContent = string.Empty;

            foreach (DataRow dr in dt.Rows)
            {
                int numCol = 
                    dr.Field<int>("NumberCol");

                string classText = "A";
                if (numCol > 3)
                    classText = "S";
                else if(numCol > 6)
                    classText = "S+";

                string itemText =
                    $@"<tr>
                    <th> {dr["ID"]} </th>
                    <th> {dr["Name"]} </th>
                    <th> {dr["Birthday"]} </th>
                    <th> {classText} </th>
                    </tr>";

                bodyContent += itemText;
            }

            this.ltTableBody.Text = bodyContent;
        }
    }
}