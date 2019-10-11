using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO {
    public class CEmpleado : ClassAdo {

        public void registrarEmpleado(ObjConexion obj, Empleado empleado) {
            conexion(obj);
            string sql = Constantes.REGISTRAR_EMPLEADO + " ?, ?,?,?,?,?";
            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idCargo", OleDbType.Integer);
            cmd.Parameters.Add("DNI", OleDbType.VarWChar, 8);
            cmd.Parameters.Add("nombreEmpleado", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("usuario", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("contraseña", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("estado", OleDbType.VarWChar, 20);
            cmd.Parameters[0].Value = empleado.IdCargo;
            cmd.Parameters[1].Value = empleado.DNI;
            cmd.Parameters[2].Value = empleado.Nombre;
            cmd.Parameters[3].Value = empleado.Usuario;
            cmd.Parameters[4].Value = empleado.Contraseña;
            cmd.Parameters[5].Value = empleado.Estado;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }

        public DataSet obtenerEmpleados(ObjConexion obj) {
            conexion(obj);
            string sql = "execute sp_selectEmpleados;";
            return consultasql(sql);
        }
    }
}
