using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO {
    public class CCliente : ClassAdo {

        CMercaderia cMercaderia = new CMercaderia();
        List<Cliente> listaCliente;
        List<Mercaderia> listaMercaderia;

        public void registrarCliente(ObjConexion obj, Cliente cliente) {
            conexion(obj);
            string sql = Constantes.REGISTRAR_CLIENTE;
            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("nombreEmpresa", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("dueñoEmpresa", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("RUC", OleDbType.VarWChar, 13);
            cmd.Parameters.Add("estado", OleDbType.Integer);
            cmd.Parameters[0].Value = cliente.NombreEmpresa;
            cmd.Parameters[1].Value = cliente.DueñoEmpresa;
            cmd.Parameters[2].Value = cliente.RUC;
            cmd.Parameters[3].Value = cliente.Estado;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }

        public DataSet obtenerClientes(ObjConexion obj) {
            conexion(obj);
            string sql = Constantes.OBTENER_CLIENTES;
            return consultasql(sql);
        }

        public string obtenerNumClientes(ObjConexion obj) {
            conexion(obj);
            string sql = "SELECT COUNT(*) FROM Cliente WHERE estado = 1";
            return selectEscalar(sql) + "";
        }

        public void actualizarCliente(ObjConexion obj, Cliente cliente) {
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
            cmd.Parameters[4].Value = cliente.Estado;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }

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


        public List<Cliente> obtenerListaClientes(ObjConexion obj) {
            conexion(obj);

            listaCliente = new List<Cliente>();

            listaMercaderia = cMercaderia.obtenerListaMercaderia(obj);

            string sql = Constantes.OBTENER_CLIENTES;

            DataSet ds = consultasql(sql);

            //Itera sobre la lista para llenar la dropdownlist
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    int idCliente = int.Parse(dr["idCliente"].ToString());
                    string nombre = dr["nombreEmpresa"].ToString();
                    string dueño = dr["dueñoEmpresa"].ToString();
                    string ruc = dr["RUC"].ToString();
                    int estado = int.Parse(dr["estado"].ToString());

                    Cliente cliente = new Cliente(idCliente, nombre, dueño, ruc, estado);

                    foreach (Mercaderia merca in listaMercaderia)
                    {
                        if (cliente.IdCliente == merca.IdCliente)
                            cliente.Mercaderias.Add(merca);
                    }


                    listaCliente.Add(cliente);
                }
            }
            return listaCliente;
        }
    }
}
