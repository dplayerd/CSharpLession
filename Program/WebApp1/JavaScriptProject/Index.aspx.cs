using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JavaScriptProject
{
    public partial class Index : System.Web.UI.Page
    {
        class UserInfo
        { 
            public string UserName { get; set; }
            public int Age { get; set; }
            public string Sex { get; set; }
        }

        List<UserInfo> list = new List<UserInfo>()
        {
            new UserInfo() { UserName = "John", Age = 18, Sex="Male" }
        };


        protected void Page_Load(object sender, EventArgs e)
        {
            //  this.ltArr.Text =
            //@"
            //  var arr2 = [
            //      { UserName: 'John', Age: 17, Sex: 'Male' },
            //      { UserName: 'Mary', Age: 17, Sex: 'Female' },
            //      { UserName: 'Johnny', Age: 17, Sex: 'Male' }
            //  ];
            //";
            this.ltArr.Text =
                $"var arr2 =  [{{ UserName: '{list[0].UserName}', Age: {list[0].Age}, Sex: '{list[0].Sex}' }}];";
        }
    }
}