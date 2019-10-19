using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO {
    public class CTransportista : ClassAdo {

        public void registrarTransportista(ObjConexion obj, Transportista transportista) {
            conexion(obj);
            string sql = Constantes.REGISTRAR_TRANSPORTISTA;
            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("TransportistaDNI", OleDbType.VarWChar, 8);
            cmd.Parameters.Add("Nombre", OleDbType.VarWChar, 20);
            cmd.Parameters[0].Value = transportista.DNI;
            cmd.Parameters[1].Value = transportista.Nombre;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }

        public DataSet obtenerTransportistas(ObjConexion obj) {
            conexion(obj);
            string sql = Constantes.OBTENER_TRANSPORTISTAS;
            return consultasql(sql);
        }

        public DataSet obtenerVistaTransportista(ObjConexion obj) {
            conexion(obj);
            string sql = Constantes.OBTENER_VISTA_TRANSPORTISTAS;
            return consultasql(sql);
        }

        public void actualizarTransportista(ObjConexion obj, Transportista transportista) {
            conexion(obj);

            string sql = Constantes.ACTUALIZAR_TRANSPORTISTA;

            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("TransportistaDNI", OleDbType.VarWChar, 8);
            cmd.Parameters.Add("Nombre", OleDbType.VarWChar, 20);
            cmd.Parameters[0].Value = transportista.DNI;
            cmd.Parameters[1].Value = transportista.Nombre;

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
