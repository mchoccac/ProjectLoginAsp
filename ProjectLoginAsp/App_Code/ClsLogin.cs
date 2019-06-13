using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq;

/// <summary>
/// Summary description for ClsLogin
/// </summary>
public class ClsLogin
{
    public ClsLogin()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    DataPersonaLinqDataContext db = new DataPersonaLinqDataContext();

    public int statusUsario(String UserName, String Password) {
        int estado = -1;
        var m_select = from x in db.t_usuarios where x.nombre_usuario == UserName && x.password == Password select x;
        foreach (t_usuario p in m_select)
        {
            if (p.nombre_usuario.Equals(UserName) == true && p.password.Equals(Password) == true)
            {
                estado = p.id;
                break;
            }
            else {
                estado = -1;
            }
        }
        return estado;

    }
}