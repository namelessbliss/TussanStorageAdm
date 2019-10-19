using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.adm {
    public partial class cliente : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CCliente cCliente;
        private ClassAdo ado;
        private Cliente objCliente;
        private int idCliente, estado;
        private string nombreEmpresa, dueñoEmpresa, RUC;

        protected void Page_Load(object sender, EventArgs e) {
            cCliente = new CCliente();
            ado = new ClassAdo();
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

            if (!this.IsPostBack)
            {
                this.BindGrid();
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

        protected void OnRowEditing(object sender, GridViewEditEventArgs e) {
            ClienteList.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e) {
            GridViewRow row = ClienteList.Rows[(e).RowIndex];
            idCliente = Convert.ToInt32(ClienteList.DataKeys[e.RowIndex].Values[0]);
            nombreEmpresa = (row.Cells[1].Controls[0] as TextBox).Text;
            dueñoEmpresa = (row.Cells[2].Controls[0] as TextBox).Text;
            RUC = (row.Cells[3].Controls[0] as TextBox).Text;
            estado = Convert.ToInt32(ClienteList.DataKeys[e.RowIndex].Values[1]);

            objCliente = new Cliente(idCliente, nombreEmpresa, dueñoEmpresa, RUC, estado);

            cCliente.actualizarCliente(objConexion, objCliente);

            ClienteList.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e) {
            ClienteList.EditIndex = -1;
            this.BindGrid();
        }


        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e) {
            GridViewRow row = ClienteList.Rows[(e).RowIndex];
            idCliente = Convert.ToInt32(ClienteList.DataKeys[e.RowIndex].Values[0]);
            nombreEmpresa = (row.Cells[1].Text);
            dueñoEmpresa = (row.Cells[2].Text);
            RUC = (row.Cells[3].Text);
            estado = Convert.ToInt32(ClienteList.DataKeys[e.RowIndex].Values[1]);

            objCliente = new Cliente(idCliente, nombreEmpresa, dueñoEmpresa, RUC, estado);

            cCliente.eliminarCliente(objConexion, objCliente);

            this.BindGrid();
        }
    }
}