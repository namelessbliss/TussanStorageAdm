﻿using CAPA_DATOS;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.adm {
    public partial class Mercaderia : System.Web.UI.Page {

        private ObjConexion objConexion;
        private CMercaderia cMercaderia;
        private CTipoMercaderia cTipoMercaderia;
        private CAPA_DATOS.Mercaderia objMercaderia;
        private ClassAdo obj;
        private CCliente cCliente;

        private int idCliente, idTipoMercaderia, cantidad;
        private string descripcion, categoria, unidad;
        private double areaCubica;

        protected void Page_Load(object sender, EventArgs e) {
            cMercaderia = new CMercaderia();
            cCliente = new CCliente();
            cTipoMercaderia = new CTipoMercaderia();
            obj = new ClassAdo();
            objConexion = new ObjConexion(Constantes.BASE_DE_DATOS, Constantes.USER_ADM, Constantes.USER_ADM_PASS, Constantes.SERVIDOR);

            DataSet dataSet = cCliente.obtenerClientes(objConexion);

            //Itera sobre la lista de clientes registrados para llenar la dropdownlist
            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    string idCliente = dr["idCliente"].ToString();
                    string nombreEmpresa = dr["nombreEmpresa"].ToString();

                    listaClientes.Items.Add(new ListItem(nombreEmpresa, idCliente));
                }
            }
            dataSet.Clear();
            cCliente.closeConexion();

            dataSet = cTipoMercaderia.obtenerTiposMercaderia(objConexion);

            //Itera sobre la lista de tipos mercaderia registrados para llenar la dropdownlist
            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    string idTipoMerca = dr["idTipoMerca"].ToString();
                    string descripcion = dr["descripcionTipoMerca"].ToString();

                    listaTipo.Items.Add(new ListItem(descripcion, idTipoMerca));
                }
            }
            dataSet.Clear();
            cTipoMercaderia.closeConexion();

            txtCantidad.Text = "0";
        }

        protected void btnRegistrarMerca_Click(object sender, EventArgs e) {
            if (!camposVacios())
            {
                idTipoMercaderia = int.Parse(listaTipo.SelectedValue);
                idCliente = int.Parse(listaClientes.SelectedValue);
                descripcion = txtDescripcion.Text;

                areaCubica = double.Parse(txtAreaCubica.Text);

                categoria = listaCategoria.SelectedValue;

                unidad = listaUnidad.SelectedValue;

                cantidad = int.Parse(txtCantidad.Text);

                objMercaderia = new CAPA_DATOS.Mercaderia(idTipoMercaderia, idCliente, descripcion, areaCubica, categoria, unidad, cantidad);

                cMercaderia.registrarMercaderia(objConexion, objMercaderia);

                mensaje.Text = "Mercaderia " + descripcion + " Registrada";
            }
        }

        private bool camposVacios() {
            if (txtDescripcion.Text.Length == 0)
            {
                mensaje.Text = "Llene todos los campos para registrar";
                return true;
            }
            else if (txtCantidad.Text.Length == 0)
            {
                mensaje.Text = "Llene todos los campos para registrar";
                return true;
            }
            else if (txtAreaCubica.Text.Length == 0)
            {
                mensaje.Text = "Llene todos los campos para registrar";
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}