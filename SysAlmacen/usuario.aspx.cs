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

        ObjConexion objConexion;
        CEmpleado cEmpleado;
        ClassAdo obj = new ClassAdo();

        protected void Page_Load(object sender, EventArgs e) {
            BindGrid();
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e) {

            if (!camposVacios())
            {
                int idCargo = int.Parse(listaCargo.SelectedValue);
                string dni = txtDNI.Text;
                string nombre = txtNombre.Text;
                string user = txtUsuario.Text;
                string pass = txtContraseña.Text;

                Empleado empleado = new Empleado(idCargo, dni, nombre, user, pass, 1);

                cEmpleado.registrarEmpleado(objConexion, empleado);
                Response.Redirect("usuario.aspx");
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
            cEmpleado = new CEmpleado();
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, "123", Constantes.SERVIDOR);
            UserList.DataSource = cEmpleado.obtenerEmpleados(objConexion).Tables[0].DefaultView;
            UserList.DataBind();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e) {
            UserList.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }


        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e) {
            GridViewRow row = UserList.Rows[e.RowIndex];
            int idEmpleado = Convert.ToInt32(UserList.DataKeys[e.RowIndex].Values[0]);

            //TODO
            // https://www.aspsnippets.com/Articles/Edit-Update-and-Delete-in-ASPNet-GridView-with-AutoGenerateColumns-True-using-C-and-VBNet.aspx

            UserList.EditIndex = -1;
            this.BindGrid();
        }
    }
}