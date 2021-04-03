using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessionSamples
{
    public class Class1
    {
        public static string GetItemValue()
        {
            return HttpContext.Current.Items["key1"] as string;
        }
    }
}