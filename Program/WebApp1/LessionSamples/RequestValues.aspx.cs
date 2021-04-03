using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessionSamples
{
    public partial class RequestValues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string qsVal = this.Request.QueryString["Page"];
            string postVal = this.Request.Form["Account"];
            string accept = this.Request.Headers["Accept-Language"];

            Uri reqUri = this.Request.Url;
            string rawUrl = this.Request.RawUrl;
            string referrer = this.Request.UrlReferrer?.ToString();

            Response.Write(reqUri + "<br/>");
            Response.Write(rawUrl + "<br/>");
            Response.Write(referrer + "<br/>");


            this.ListAllContent(this.Request.QueryString);
            this.ListAllContent(this.Request.Form);
            this.ListAllContent(this.Request.Headers);

            string[] pageColl = this.Request.QueryString.GetValues("Page");
        }


        private void ListAllContent(NameValueCollection collection)
        {
            foreach (var key in collection.AllKeys)
            {
                var value = collection[key];
                Response.Write($"Key: {key}, Value: {value}<br/>");
            }
        }
    }
}