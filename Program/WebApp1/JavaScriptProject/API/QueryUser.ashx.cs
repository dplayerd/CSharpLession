using JavaScriptProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavaScriptProject.API
{
    /// <summary>
    /// QueryUser 的摘要描述
    /// </summary>
    public class QueryUser : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string pName = context.Request.QueryString["name"];

            var tempList = DataBaseExecutor.GetUserInfos(pName);
            string result = JsonConvert.SerializeObject(tempList);

            context.Response.ContentType = "application/json";
            context.Response.Charset = "utf-8";
            context.Response.Write(result);
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