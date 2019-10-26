using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.ope {
    public partial class cliente : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CCliente cCliente;
        private ClassAdo ado;
        private Cliente objCliente;
        private int idCliente, estado;
        private string nombreEmpresa, dueñoEmpresa, RUC;

        protected void Page_Load(object sender, EventArgs e) {

            if (Global.empleado != null)
            {
                cCliente = new CCliente();
                ado = new ClassAdo();
                objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_OPERARIO, Constantes.USER_OPERARIO_PASS, Constantes.SERVIDOR);

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

        protected void btnRegistrarCliente_Click(object sender, EventArgs e) {
            if (!camposVacios())
            {
                nombreEmpresa = txtEmpresa.Text;
                dueñoEmpresa = txtDueño.Text;
                RUC = txtRUC.Text;

                objCliente = new Cliente(nombreEmpresa, dueñoEmpresa, RUC, 1);

                cCliente.registrarCliente(objConexion, objCliente);
                BindGrid();
            }
        }

        private bool camposVacios() {
            if (txtEmpresa.Text.Length == 0)
                return true;
            else if (txtDueño.Text.Length == 0)
                return true;
            else if (txtRUC.Text.Length == 0)
                return true;
            else
                return false;
        }

        private void BindGrid() {
            ClienteList.DataSource = cCliente.obtenerClientes(objConexion).Tables[0].DefaultView;
            ClienteList.DataBind();
            cCliente.closeConexion();
        }
    }
}