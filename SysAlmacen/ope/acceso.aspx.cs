using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.ope {
    public partial class acceso : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CCliente cCliente;


        private ClassAdo obj;

        protected void Page_Load(object sender, EventArgs e) {
            if (Global.empleado != null)
            {
                cCliente = new CCliente();

                obj = new ClassAdo();
                objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

                if (!this.IsPostBack)
                {
                    this.BindGrid();
                }
            }
            else
            {
                Response.Redirect("~/default.aspx");
            }

        }

        private void BindGrid() {
            ClienteList.DataSource = cCliente.obtenerClientes(objConexion).Tables[0].DefaultView;
            ClienteList.DataBind();
            cCliente.closeConexion();
        }
    }
}