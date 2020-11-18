using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace وظيفة_الستاذ_علاء
{
    public partial class page_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string max = Request.QueryString.Get("name");
            Response.Write(max);
            Response.Write(Session["name"]);
            Response.Write(Application["name"]);
            HttpCookieCollection cookies = Response.Cookies;
            Response.Write(cookies["max"].Value);
        }
    }
}