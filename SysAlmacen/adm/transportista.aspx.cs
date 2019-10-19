using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.adm {
    public partial class transportista : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CTransportista cTransportista;
        private CVehiculo cVehiculo;
        private CAPA_DATOS.Transportista objTransportista;
        private CAPA_DATOS.Vehiculo objVehiculo;
        private ClassAdo obj;

        private int idEmpleado, idCargo, estado;

        private string dni, nombre, placa;

        protected void Page_Load(object sender, EventArgs e) {
            cTransportista = new CTransportista();
            cVehiculo = new CVehiculo();
            obj = new ClassAdo();
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        protected void btnRegistrarTransportista_Click(object sender, EventArgs e) {

            if (!camposVacios())
            {
                dni = txtDNI.Text;
                nombre = txtNombre.Text;
                placa = txtPlaca.Text;

                objTransportista = new CAPA_DATOS.Transportista(dni, nombre);
                objVehiculo = new CAPA_DATOS.Vehiculo(placa, dni);

                cTransportista.registrarTransportista(objConexion, objTransportista);
                cVehiculo.registrarVehiculo(objConexion, objVehiculo);
                BindGrid();
            }
        }

        private bool camposVacios() {
            if (txtDNI.Text.Length == 0)
                return true;
            else if (txtNombre.Text.Length == 0)
                return true;
            else if (txtPlaca.Text.Length == 0)
                return true;
            else
                return false;
        }

        private void BindGrid() {
            UserList.DataSource = cTransportista.obtenerVistaTransportista(objConexion).Tables[0].DefaultView;
            UserList.DataBind();
            cTransportista.closeConexion();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e) {
            UserList.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }


        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e) {
            GridViewRow row = UserList.Rows[(e).RowIndex];
            dni = Convert.ToString(UserList.DataKeys[e.RowIndex].Values[0]);
            nombre = (row.Cells[2].Controls[0] as TextBox).Text;
            placa = (row.Cells[3].Controls[0] as TextBox).Text;

            objTransportista = new CAPA_DATOS.Transportista(dni, nombre);
            objVehiculo = new CAPA_DATOS.Vehiculo(placa, dni);

            cTransportista.actualizarTransportista(objConexion, objTransportista);
            cVehiculo.actualizarVehiculo(objConexion, objVehiculo);

            UserList.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e) {
            UserList.EditIndex = -1;
            this.BindGrid();
        }
    }
}