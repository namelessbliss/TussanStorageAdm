using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO {
    public class CRegistro : ClassAdo {

        public void registrarGuia(ObjConexion obj, Registro registro) {
            conexion(obj);
            string sql = Constantes.INSERTAR_REGISTRO;
            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idCliente", OleDbType.Integer);
            cmd.Parameters.Add("idMercaderia", OleDbType.Integer);
            cmd.Parameters.Add("idTipoRegistro", OleDbType.Integer);
            cmd.Parameters.Add("idEmpleado", OleDbType.Integer);
            cmd.Parameters.Add("fecha", OleDbType.VarChar, 10);
            cmd.Parameters.Add("cantidad", OleDbType.Integer);
            cmd.Parameters.Add("areaCubica", OleDbType.Double);
            cmd.Parameters.Add("estado", OleDbType.Integer);
            cmd.Parameters[0].Value = registro.IdCliente;
            cmd.Parameters[1].Value = registro.IdMercaderia;
            cmd.Parameters[2].Value = registro.IdTipoRegistro;
            cmd.Parameters[3].Value = registro.IdEmpleado;
            cmd.Parameters[4].Value = registro.Fecha;
            cmd.Parameters[5].Value = registro.Cantidad;
            cmd.Parameters[6].Value = registro.AreaCubica;
            cmd.Parameters[7].Value = registro.Estado;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }

        public DataSet obtenerGuias(ObjConexion obj) {
            conexion(obj);
            string sql = Constantes.OBTENER_GUIAS;
            return consultasql(sql);
        }

        public string obtenerNumGuias(ObjConexion obj) {
            conexion(obj);
            string sql = "SELECT COUNT(*) FROM vistaGuias";
            return selectEscalar(sql) + "";
        }

        public DataSet obtenerGuiaEntrada(ObjConexion obj) {
            conexion(obj);
            string sql = Constantes.OBTENER_GUIA_ENTRADA;
            return consultasql(sql);
        }

        public DataSet obtenerGuiaSalida(ObjConexion obj) {
            conexion(obj);
            string sql = Constantes.OBTENER_GUIA_SALIDA;
            return consultasql(sql);
        }

        public void actualizarRegistro(ObjConexion obj, Registro registro) {
            conexion(obj);

            string sql = Constantes.ACTUALIZAR_REGISTRO;

            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idRegistro", OleDbType.Integer);
            cmd.Parameters.Add("idCliente", OleDbType.Integer);
            cmd.Parameters.Add("idMercaderia", OleDbType.Integer);
            cmd.Parameters.Add("idTipoRegistro", OleDbType.Integer);
            cmd.Parameters.Add("idEmpleado", OleDbType.Integer);
            cmd.Parameters.Add("fecha", OleDbType.VarChar, 10);
            cmd.Parameters.Add("cantidad", OleDbType.Integer);
            cmd.Parameters.Add("areaCubica", OleDbType.Double);
            cmd.Parameters.Add("estado", OleDbType.Integer);
            cmd.Parameters[0].Value = registro.IdRegistro;
            cmd.Parameters[1].Value = registro.IdCliente;
            cmd.Parameters[2].Value = registro.IdMercaderia;
            cmd.Parameters[3].Value = registro.IdTipoRegistro;
            cmd.Parameters[4].Value = registro.IdEmpleado;
            cmd.Parameters[5].Value = registro.Fecha;
            cmd.Parameters[6].Value = registro.Cantidad;
            cmd.Parameters[7].Value = registro.AreaCubica;
            cmd.Parameters[8].Value = registro.Estado;

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
