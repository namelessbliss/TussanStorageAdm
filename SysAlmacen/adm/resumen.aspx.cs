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
        private CTransportista cTransportista;
        private ClassAdo obj;
        protected void Page_Load(object sender, EventArgs e) {
            cEmpleado = new CEmpleado();
            cCliente = new CCliente();
            cTransportista = new CTransportista();
            obj = new ClassAdo();
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        private void BindGrid() {
            UserList.DataSource = cEmpleado.obtenerEmpleados(objConexion).Tables[0].DefaultView;
            UserList.DataBind();
            cEmpleado.closeConexion();

            ClienteList.DataSource = cCliente.obtenerClientes(objConexion).Tables[0].DefaultView;
            ClienteList.DataBind();
            cCliente.closeConexion();

            TransportistaList.DataSource = cTransportista.obtenerVistaTransportista(objConexion).Tables[0].DefaultView;
            TransportistaList.DataBind();
            cTransportista.closeConexion();
        }
    }
}