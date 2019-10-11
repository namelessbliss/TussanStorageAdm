using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen {
    public partial class Default : System.Web.UI.Page {
        ClassAdo obj = new ClassAdo();
        ObjConexion objConexion;

        protected void Page_Load(object sender, EventArgs e) {
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, "123", Constantes.SERVIDOR);
        }

        protected void btnLogin_Click(object sender, EventArgs e) {

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario.Length > 0 && contraseña.Length > 0)
            {
                string sql = "exec sp_login 1, '" + usuario + "', '" + contraseña + "'";
                obj.conexion(objConexion);

                if (obj.login(sql) == 1)
                {
                    Response.Redirect("resumen.aspx");
                }
                else
                {
                    Response.Redirect("default.aspx");
                }


            }
        }
    }
}