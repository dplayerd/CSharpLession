using LessionSamples.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessionSamples
{
	public partial class UserInfo1 : System.Web.UI.Page
	{
        private const string _sessionKey = "IsLogined";
        private const string _sessionKey_Account = "Account";

        protected void Page_Load(object sender, EventArgs e)
		{
            if (LoginHelper.HasLogined())
            {
                this.ltAccount.Text = LoginHelper.GetCurrentUserInfo();
            }

            //bool? val = this.Session[_sessionKey] as bool?;
            //if (val.HasValue && val.Value)
            //{
            //    this.ltAccount.Text = this.Session[_sessionKey_Account] as string;
            //}
        }
	}
}