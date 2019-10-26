using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.adm {
    public partial class listado_mercaderia : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CMercaderia cMercaderia;
        private CAPA_DATOS.Mercaderia objMercaderia;
        private ClassAdo obj;

        private int idMercaderia, idCliente, cantidad;
        private string descripcion;
        private double areaCubica;

        protected void Page_Load(object sender, EventArgs e) {
            if (Global.empleado != null)
            {
                if (Global.empleado.IdCargo == 1)
                {

                    cMercaderia = new CMercaderia();
                    obj = new ClassAdo();
                    objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

                    if (!this.IsPostBack)
                    {
                        this.BindGrid();
                    }
                }
            }
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }

        private void BindGrid() {
            UserList.DataSource = cMercaderia.obtenerMercaderia(objConexion).Tables[0].DefaultView;
            UserList.DataBind();
            cMercaderia.closeConexion();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e) {
            UserList.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }


        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e) {
            /*
            GridViewRow row = UserList.Rows[(e).RowIndex];
            idMercaderia = Convert.ToInt32(UserList.DataKeys[e.RowIndex].Values[0]);
            descripcion = (row.Cells[1].Controls[0] as TextBox).Text;
            areaCubica = Convert.ToDouble((row.Cells[2].Controls[0] as TextBox).Text);
            cantidad = Convert.ToInt32((row.Cells[4].Controls[0] as TextBox).Text);
            idCliente = Convert.ToInt32(UserList.DataKeys[e.RowIndex].Values[1]);

            objMercaderia = new CAPA_DATOS.Mercaderia(idMercaderia, descripcion, areaCubica, cantidad);

            cMercaderia.actualizarMercaderia(objConexion, objMercaderia);

            UserList.EditIndex = -1;
            this.BindGrid();
            */
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e) {
            UserList.EditIndex = -1;
            this.BindGrid();
        }
    }
}