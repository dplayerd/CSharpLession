﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryLifeCircle
{
    public partial class ucA : System.Web.UI.UserControl
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("ucA.Page_PreInit <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("ucA.Page_Init <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("ucA.Page_Load <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("ucA.Page_PreRender <br/>");
        }
    }
}