using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO {
    public class CMercaderia : ClassAdo {

        public void registrarMercaderia(ObjConexion obj, Mercaderia mercaderia) {
            conexion(obj);
            string sql = Constantes.REGISTRAR_MERCADERIA;
            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idTipoMerca", OleDbType.Integer);
            cmd.Parameters.Add("idCliente", OleDbType.Integer);
            cmd.Parameters.Add("descripcionMercaderia", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("areaCubica", OleDbType.Double);
            cmd.Parameters.Add("categoria", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("unidad", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("cantidad", OleDbType.Integer);
            cmd.Parameters[0].Value = mercaderia.IdTipoMercaderia;
            cmd.Parameters[1].Value = mercaderia.IdCliente;
            cmd.Parameters[2].Value = mercaderia.Descripcion;
            cmd.Parameters[3].Value = mercaderia.AreaCubica;
            cmd.Parameters[4].Value = mercaderia.Categoria;
            cmd.Parameters[5].Value = mercaderia.Unidad;
            cmd.Parameters[6].Value = mercaderia.Cantidad;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }

        public DataSet obtenerMercaderia(ObjConexion obj) {
            conexion(obj);
            string sql = Constantes.OBTENER_MERCADERIAS;
            return consultasql(sql);
        }

        public string obtenerNumMercaderias(ObjConexion obj) {
            conexion(obj);
            string sql = "SELECT COUNT(*) FROM Mercaderia";
            return selectEscalar(sql) + "";
        }

        public void actualizarMercaderia(ObjConexion obj, Mercaderia mercaderia) {
            conexion(obj);

            string sql = Constantes.ACTUALIZAR_MERCADERIA;

            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idMercaderia", OleDbType.Integer);
            cmd.Parameters.Add("idTipoMerca", OleDbType.Integer);
            cmd.Parameters.Add("idCliente", OleDbType.Integer);
            cmd.Parameters.Add("descripcionMercaderia", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("areaCubica", OleDbType.Double);
            cmd.Parameters.Add("categoria", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("unidad", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("cantidad", OleDbType.Integer);
            cmd.Parameters[0].Value = mercaderia.IdMercaderia;
            cmd.Parameters[1].Value = mercaderia.IdTipoMercaderia;
            cmd.Parameters[2].Value = mercaderia.IdCliente;
            cmd.Parameters[3].Value = mercaderia.Descripcion;
            cmd.Parameters[4].Value = mercaderia.AreaCubica;
            cmd.Parameters[5].Value = mercaderia.Categoria;
            cmd.Parameters[6].Value = mercaderia.Unidad;
            cmd.Parameters[7].Value = mercaderia.Cantidad;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }



        public List<Mercaderia> obtenerListaMercaderia(ObjConexion obj) {
            conexion(obj);

            List<Mercaderia> mercas = new List<Mercaderia>();

            string sql = Constantes.OBTENER_MERCADERIAS;

            DataSet ds = consultasql(sql);

            //Itera sobre la lista para llenar la dropdownlist
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    int idMercaderia = int.Parse(dr["idMercaderia"].ToString());
                    int idTipo = int.Parse(dr["idTipoMerca"].ToString());
                    int idCliente = int.Parse(dr["idCliente"].ToString());
                    string descripcion = dr["descripcionMercaderia"].ToString();
                    double areaCubica = double.Parse(dr["areaCubica"].ToString());
                    string categoria = dr["categoria"].ToString();
                    string unidad = dr["unidad"].ToString();
                    int cantidad = int.Parse(dr["cantidad"].ToString());

                    mercas.Add(new Mercaderia(idMercaderia, idTipo, idCliente, descripcion, areaCubica, categoria, unidad, cantidad));
                }
            }

            return mercas;
        }


        /*
        public void eliminarCliente(ObjConexion obj, Cliente cliente) {
            conexion(obj);

            string sql = Constantes.ACTUALIZAR_CLIENTE;

            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idEmpleado", OleDbType.Integer);
            cmd.Parameters.Add("nombreEmpresa", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("dueñoEmpresa", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("RUC", OleDbType.VarWChar, 13);
            cmd.Parameters.Add("estado", OleDbType.Integer);
            cmd.Parameters[0].Value = cliente.IdCliente;
            cmd.Parameters[1].Value = cliente.NombreEmpresa;
            cmd.Parameters[2].Value = cliente.DueñoEmpresa;
            cmd.Parameters[3].Value = cliente.RUC;
            cmd.Parameters[4].Value = 0; // estado 0 --> Eliminado

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }
        */
    }
}
