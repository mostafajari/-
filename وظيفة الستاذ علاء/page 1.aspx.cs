using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace وظيفة_الستاذ_علاء
{
    public partial class page_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page 2.aspx?name="+TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            TextBox1.Text = " ";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           Label1.Text=ViewState["name"].ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Response.Redirect("page 2.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Application["name"] = TextBox1.Text;
            Response.Redirect("page 2.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("max",TextBox1.Text);     
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("page 2.aspx");
        }
    }
}