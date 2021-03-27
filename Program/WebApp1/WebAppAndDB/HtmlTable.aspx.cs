using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAndDB
{
    public partial class HtmlTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt =
                DataBaseExecutor.ReadTestTable1DT();

            string outputText = string.Empty;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string id = dr["ID"].ToString();
                string Name = dr["Name"].ToString();
                string Birthday = dr["Birthday"].ToString();
                string NumberCol = dr["NumberCol"].ToString();

                //// 轉型
                //int numCol = Convert.ToInt32(NumberCol);
                //int numCol2 = dr.Field<int>("NumberCol");
                //int? numCol3 = dr.Field<int?>("NumberCol");

                //if(numCol3.HasValue)
                //    outputText += $"<td>{numCol3.Value}</td>";
                //else
                //    outputText += $"<td>-</td>";

                //// null 1
                //if (!dr.IsNull("NumberCol"))
                //    outputText += $"<td>{NumberCol}</td>";
                //else
                //    outputText += $"<td>-</td>";

                //// null 2
                //outputText += $"<td>{((!dr.IsNull("NumberCol")) ? NumberCol : "-")}</td>";
                
                //// null 3
                //if(dr["NumberCol"] != null)
                //    outputText += $"<td>{NumberCol}</td>";
                //else
                //    outputText += $"<td>-</td>";

                outputText += "<tr>";
                outputText += $"<td>{id}</td>";
                outputText += $"<td>{Name}</td>";
                outputText += $"<td>{Birthday}</td>";
                //outputText += $"<td>{NumberCol}</td>";
                // null 3
                if (dr["NumberCol"] != null)
                    outputText += $"<td>{NumberCol}</td>";
                else
                    outputText += $"<td>-</td>";
                outputText += "</tr>";
            }

            this.ltTableContent.Text = outputText;
        }
    }
}