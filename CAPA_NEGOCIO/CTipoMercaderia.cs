using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO {
    public class CTipoMercaderia : ClassAdo {

        public void registrarTipoMercaderia(ObjConexion obj, TipoMercaderia tipoMerca) {
            conexion(obj);
            string sql = Constantes.REGISTRAR_TIPO_MERCADERIA;
            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("descripcionMercaderia", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("precioMerca", OleDbType.Decimal);
            cmd.Parameters[0].Value = tipoMerca.descripcionMercaderia;
            cmd.Parameters[1].Value = tipoMerca.precioMercaderia;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }

        public DataSet obtenerTiposMercaderia(ObjConexion obj) {
            conexion(obj);
            string sql = Constantes.OBTENER_TIPOS_MERCADERIA;
            return consultasql(sql);
        }


        public void actualizarTipoMercaderia(ObjConexion obj, TipoMercaderia tipoMerca) {
            conexion(obj);

            string sql = Constantes.ACTUALIZAR_TIPO_MERCADERIA;

            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idTipoMerca", OleDbType.Integer);
            cmd.Parameters.Add("descripcionMercaderia", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("precioMerca", OleDbType.Decimal);
            cmd.Parameters[0].Value = tipoMerca.idTipoMercaderia;
            cmd.Parameters[1].Value = tipoMerca.descripcionMercaderia;
            cmd.Parameters[2].Value = tipoMerca.precioMercaderia;

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
