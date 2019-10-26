using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen {
    public partial class Default : System.Web.UI.Page {
        ClassAdo obj;
        ObjConexion objConexion;
        CEmpleado cEmpleado;
        Empleado empleado;

        protected void Page_Load(object sender, EventArgs e) {
            obj = new ClassAdo();
            cEmpleado = new CEmpleado();
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);
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
                    cEmpleado.closeConexion();
                    empleado = cEmpleado.obtenerEmpleadoPorCredenciales(objConexion, usuario, contraseña);
                    Global.empleado = empleado;
                    redireccionarSegunCargo();
                }
                else
                {
                    Response.Redirect("default.aspx");
                }


            }
        }

        private void redireccionarSegunCargo() {
            if (empleado.IdCargo == 1)
            {
                Response.Redirect("adm/resumen.aspx");
            }
            else if (empleado.IdCargo == 2)
            {
                Response.Redirect("ope/acceso.aspx");
            }

        }
    }
}