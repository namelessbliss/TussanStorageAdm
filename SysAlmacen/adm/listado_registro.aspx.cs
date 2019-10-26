using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.adm {
    public partial class listado_registro : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CRegistro cRegistro;
        private ClassAdo ado;

        protected void Page_Load(object sender, EventArgs e) {
            cRegistro = new CRegistro();
            ado = new ClassAdo();
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        private void BindGrid() {
            DataSet ds = cRegistro.obtenerGuiaEntrada(objConexion);
            GuiaList.DataSource = ds;
            GuiaList.DataBind();
            cRegistro.closeConexion();

        }

        protected void listaTipoGuia_SelectedIndexChanged(object sender, EventArgs e) {
            if (listaTipoGuia.SelectedValue.Equals("1"))
            {
                DataSet ds = cRegistro.obtenerGuiaEntrada(objConexion);
                GuiaList.DataSource = ds;
                GuiaList.DataBind();
                cRegistro.closeConexion();

            }
            else
            {
                DataSet ds = cRegistro.obtenerGuiaSalida(objConexion);
                GuiaList.DataSource = ds;
                GuiaList.DataBind();
                cRegistro.closeConexion();

            }
        }
    }
}