using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {

    ClassAdo obj = new ClassAdo();

    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnLogin_Click(object sender, EventArgs e) {

        string usuario = txtUsuario.Text;
        string contraseña = txtContraseña.Text;

        if (usuario.Length > 0 && contraseña.Length > 0)
        {
            string sql = "exec sp_login 1, '" + usuario + "', '" + contraseña + "'";
            obj.conexion("TussanBD", "administrador", "123", "NAMELESSBLISS");

            if (obj.login(sql) == 1)
            {
                Response.Redirect("resumen.aspx");
            }
            else
            {
                Console.WriteLine("El usuario no existe");
            }

        }
    }
}