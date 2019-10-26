using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.adm {
    public partial class resumen1 : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CEmpleado cEmpleado;
        private CCliente cCliente;
        private CRegistro cRegistro;
        private CMercaderia cMercaderia;

        private ClassAdo obj;

        protected string numEmpleados, numClientes, numMercaderias, numRegistros;

        protected void Page_Load(object sender, EventArgs e) {

            if (Global.empleado != null)
            {
                if (Global.empleado.IdCargo == 1)
                {
                    cEmpleado = new CEmpleado();
                    cCliente = new CCliente();
                    cMercaderia = new CMercaderia();
                    cRegistro = new CRegistro();

                    obj = new ClassAdo();
                    objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

                    if (!this.IsPostBack)
                    {
                        this.BindGrid();
                    }

                    numEmpleados = cEmpleado.obtenerNumEmpleados(objConexion);
                    numClientes = cCliente.obtenerNumClientes(objConexion);
                    numMercaderias = cMercaderia.obtenerNumMercaderias(objConexion);
                    numRegistros = cRegistro.obtenerNumGuias(objConexion);

                }
                else
                {
                    Response.Redirect("~/default.aspx");
                }
            }
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }

        private void BindGrid() {
            UserList.DataSource = cEmpleado.obtenerEmpleados(objConexion).Tables[0].DefaultView;
            UserList.DataBind();
            cEmpleado.closeConexion();

            ClienteList.DataSource = cCliente.obtenerClientes(objConexion).Tables[0].DefaultView;
            ClienteList.DataBind();
            cCliente.closeConexion();
        }
    }
}