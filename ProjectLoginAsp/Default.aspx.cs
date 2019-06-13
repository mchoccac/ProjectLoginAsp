using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.Page.User.Identity.IsAuthenticated)
        {
            FormsAuthentication.RedirectToLoginPage();
        }else{
            // http://localhost:60620/Default.aspx?param=Hola%20mundo&param2=3333
            //?param=Hola mundo
            string v = Request.QueryString["param"];
            string v2 = Request.QueryString["param2"];
            Label1.Text = "v: " + v + " v2: " + v2;
        }

   

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Opciones.aspx?param=sistema nombre");
    }
}