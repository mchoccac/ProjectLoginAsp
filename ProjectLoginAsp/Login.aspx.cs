using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        String username = Login1.UserName;
        String password = Login1.Password;
        ClsLogin m_login = new ClsLogin();
        int seleccionar = m_login.statusUsario(username,password);
        switch (seleccionar)
        {
            case -1:
                Login1.FailureText = "usuario o contrasenia es incorrecta.";
                break;
            case -2:
                Login1.FailureText = "su cuenta no esta activada.";
                break;
            default:
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
                break;
        }
    }
}