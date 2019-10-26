using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.ope {
    public partial class operacion_registro1 : System.Web.UI.Page {


        private ObjConexion objConexion;

        private CRegistro cRegistro;
        private CTipoRegistro cTipoRegistro;
        private CCliente cCliente;
        private CMercaderia cMercaderia;

        private Registro registro;
        private List<Cliente> clientes;

        private ClassAdo obj;

        DataSet dataSet;

        private int idCliente, idMercaderia, idTipoRegistro, idEmpleado, cantidad, estado;
        private string fecha;
        private double areaCubica;

        protected void Page_Load(object sender, EventArgs e) {
            if (Global.empleado != null)
            {
                idEmpleado = Global.empleado.IdEmpleado;
                cRegistro = new CRegistro();
                cTipoRegistro = new CTipoRegistro();
                cMercaderia = new CMercaderia();
                cCliente = new CCliente();
                obj = new ClassAdo();
                objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_OPERARIO, Constantes.USER_OPERARIO_PASS, Constantes.SERVIDOR);

                clientes = cCliente.obtenerListaClientes(objConexion);

                if (!this.IsPostBack)
                {
                    this.BindGrid();
                    txtFecha.Text = DateTime.Now.ToShortDateString();
                    txtFecha.Enabled = false;

                    dataSet = cTipoRegistro.obtenerTiposRegistro(objConexion);

                    //Itera sobre la lista para llenar la dropdownlist
                    foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            string idTipo = dr["idTipoRegistro"].ToString();
                            string descripcion = dr["descripcionTipo"].ToString();

                            listaTipo.Items.Add(new ListItem(descripcion, idTipo));
                        }
                    }
                    dataSet.Clear();
                    cTipoRegistro.closeConexion();

                    //Itera sobre la lista de clientes para llenar la dropdownlist
                    foreach (Cliente clien in clientes)
                    {
                        listaCliente.Items.Add(new ListItem(clien.NombreEmpresa, clien.IdCliente + ""));

                        foreach (CAPA_DATOS.Mercaderia merca in clien.Mercaderias)
                        {
                            //listaMercaderia.Items.Add(new ListItem(merca.Descripcion, merca.IdMercaderia + ""));
                        }
                    }
                    cCliente.closeConexion();

                }
            }
            else
            {

            }
        }

        protected void btnFecha_Click(object sender, EventArgs e) {
            calendario.Visible = true;
        }

        protected void listaCliente_SelectedIndexChanged(object sender, EventArgs e) {
            listaMercaderia.Items.Clear();
            listaCliente.Items.Remove("Seleccione");
            idCliente = int.Parse(listaCliente.SelectedValue);

            //Itera sobre la lista para llenar la dropdownlist
            foreach (Cliente clien in clientes)
            {
                foreach (CAPA_DATOS.Mercaderia merca in clien.Mercaderias)
                {
                    if (idCliente == merca.IdCliente)
                    {
                        listaMercaderia.Items.Add(new ListItem(merca.Descripcion, merca.IdMercaderia + ""));
                    }

                }
            }
        }

        protected void calendario_SelectionChanged(object sender, EventArgs e) {
            txtFecha.Text = calendario.SelectedDate.ToShortDateString();
            fecha = txtFecha.Text;
            calendario.Visible = false;
        }

        protected void btnRegistrarRegistro_Click(object sender, EventArgs e) {
            if (!camposVacios())
            {
                idTipoRegistro = int.Parse(listaTipo.SelectedValue);
                idCliente = int.Parse(listaCliente.SelectedValue);
                idMercaderia = int.Parse(listaMercaderia.SelectedValue);
                idEmpleado = Global.empleado.IdEmpleado;
                fecha = txtFecha.Text;
                cantidad = int.Parse(txtCantidad.Text);
                areaCubica = double.Parse(txtAreaCubica.Text);
                estado = 1;

                registro = new Registro(idCliente, idMercaderia, idTipoRegistro, idEmpleado, fecha, cantidad, areaCubica, estado);

                cRegistro.registrarGuia(objConexion, registro);
                BindGrid();
            }
        }

        private bool camposVacios() {
            if (txtFecha.Text.Length == 0)
                return true;
            else if (txtCantidad.Text.Length == 0)
                return true;
            else if (txtAreaCubica.Text.Length == 0)
                return true;
            else
                return false;
        }

        private void BindGrid() {
            RegistroList.DataSource = cRegistro.obtenerGuiaEntrada(objConexion).Tables[0].DefaultView;
            RegistroList.DataBind();
            cRegistro.closeConexion();
        }
    }
}