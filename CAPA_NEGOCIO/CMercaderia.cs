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

            cmd.Parameters.Add("idCliente", OleDbType.Integer);
            cmd.Parameters.Add("descripcionMercaderia", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("areaCubica", OleDbType.Double);
            cmd.Parameters.Add("cantidad", OleDbType.Integer);
            cmd.Parameters[0].Value = mercaderia.IdCliente;
            cmd.Parameters[1].Value = mercaderia.Descripcion;
            cmd.Parameters[2].Value = mercaderia.AreaCubica;
            cmd.Parameters[3].Value = mercaderia.Cantidad;

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

        public void actualizarMercaderia(ObjConexion obj, Mercaderia mercaderia) {
            conexion(obj);

            string sql = Constantes.ACTUALIZAR_MERCADERIA;

            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idMercaderia", OleDbType.Integer);
            cmd.Parameters.Add("idCliente", OleDbType.Integer);
            cmd.Parameters.Add("descripcionMercaderia", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("areaCubica", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("cantidad", OleDbType.Integer);
            cmd.Parameters[0].Value = mercaderia.IdCliente;
            cmd.Parameters[1].Value = mercaderia.IdCliente;
            cmd.Parameters[2].Value = mercaderia.Descripcion;
            cmd.Parameters[3].Value = mercaderia.AreaCubica;
            cmd.Parameters[4].Value = mercaderia.Cantidad;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
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
