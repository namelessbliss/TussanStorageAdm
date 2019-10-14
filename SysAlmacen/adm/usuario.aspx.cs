using System;
using CAPA_DATOS;
using CAPA_NEGOCIO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen {
    public partial class usuario : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CEmpleado cEmpleado;
        private ClassAdo obj;

        private int idEmpleado, idCargo, estado;
        private string dni, nombre, nombreUsuario, contraseña;

        protected void Page_Load(object sender, EventArgs e) {
            cEmpleado = new CEmpleado();
            obj = new ClassAdo();
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e) {

            if (!camposVacios())
            {
                idCargo = int.Parse(listaCargo.SelectedValue);
                dni = txtDNI.Text;
                nombre = txtNombre.Text;
                nombreUsuario = txtUsuario.Text;
                contraseña = txtContraseña.Text;

                Empleado empleado = new Empleado(idCargo, dni, nombre, nombreUsuario, contraseña, 1);

                cEmpleado.registrarEmpleado(objConexion, empleado);
                BindGrid();
            }
        }

        private bool camposVacios() {
            if (txtDNI.Text.Length == 0)
                return true;
            else if (txtNombre.Text.Length == 0)
                return true;
            else if (txtUsuario.Text.Length == 0)
                return true;
            else if (txtContraseña.Text.Length == 0)
                return true;
            else
                return false;
        }

        private void BindGrid() {
            UserList.DataSource = cEmpleado.obtenerEmpleados(objConexion).Tables[0].DefaultView;
            UserList.DataBind();
            cEmpleado.closeConexion();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e) {
            UserList.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }


        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e) {
            GridViewRow row = UserList.Rows[(e).RowIndex];
            idEmpleado = Convert.ToInt32(UserList.DataKeys[e.RowIndex].Values[0]);
            idCargo = Convert.ToInt32((row.Cells[1].Controls[0] as TextBox).Text);
            //int idCargo = Convert.ToInt32((row.Cells[1].Controls[0] as TextBox).Text);
            dni = (row.Cells[2].Controls[0] as TextBox).Text;
            nombre = (row.Cells[3].Controls[0] as TextBox).Text;
            nombreUsuario = (row.Cells[4].Controls[0] as TextBox).Text;
            contraseña = (row.Cells[5].Controls[0] as TextBox).Text;
            estado = Convert.ToInt32(UserList.DataKeys[e.RowIndex].Values[1]);

            Empleado empleado = new Empleado(idEmpleado, idCargo, dni, nombre, nombreUsuario, contraseña, estado);

            cEmpleado.actualizarEmpleado(objConexion, empleado);

            UserList.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e) {
            UserList.EditIndex = -1;
            this.BindGrid();
        }


        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e) {
            GridViewRow row = UserList.Rows[(e).RowIndex];
            idEmpleado = Convert.ToInt32(UserList.DataKeys[e.RowIndex].Values[0]);
            idCargo = Convert.ToInt32((row.Cells[1].Text));
            dni = (row.Cells[2].Text);
            nombre = (row.Cells[3].Text);
            nombreUsuario = (row.Cells[4].Text);
            contraseña = (row.Cells[5].Text);
            estado = Convert.ToInt32(UserList.DataKeys[e.RowIndex].Values[1]);

            Empleado empleado = new Empleado(idEmpleado, idCargo, dni, nombre, nombreUsuario, contraseña, estado);

            cEmpleado.eliminarEmpleado(objConexion, empleado);

            this.BindGrid();
        }
    }
}