using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavaScriptProject.API
{
    /// <summary>
    /// UserHandler 的摘要描述
    /// </summary>
    public class UserHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");




            string action = context.Request.Form["action"];

            string name1 = context.Request.Form["Name"];
            string age1 = context.Request.Form["Age"];
            string sex1 = context.Request.Form["Sex"];

            int age = Convert.ToInt32(age1);

            //----- 檢查授權 -----
            string token = context.Request.QueryString["token"];
            bool canExecute = false;

            if (!string.IsNullOrEmpty(token))
                canExecute = true;

            if (!canExecute)
            {
                if (LoginHelper.HasLogined())
                    canExecute = true;
            }

            if (!canExecute)
                return;
            //----- 檢查授權 -----

            if (action == "create")
                DataBaseExecutor.CreateUserInfo(name1, age, sex1);
            else if (action == "update")
            {
            }
            else if (action == "delete")
            {
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}