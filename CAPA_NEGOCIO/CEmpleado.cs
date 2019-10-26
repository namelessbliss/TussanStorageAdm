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

        DataSet dsEmpleado;
        Empleado empleado;

        public void registrarEmpleado(ObjConexion obj, Empleado empleado) {
            conexion(obj);
            string sql = Constantes.REGISTRAR_EMPLEADO;
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

        public string obtenerNumEmpleados(ObjConexion obj) {
            conexion(obj);
            string sql = "SELECT COUNT(*) FROM Empleado WHERE estado = 1";
            return selectEscalar(sql) + "";
        }

        public Empleado obtenerEmpleadoPorCredenciales(ObjConexion obj, string usuario, string contraseña) {
            conexion(obj);
            string sql = Constantes.OBTENER_EMPLEADO_POR_CREDENCIALES;

            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("usuario", OleDbType.VarWChar, 100);
            cmd.Parameters.Add("contraseña", OleDbType.VarWChar, 100);

            cmd.Parameters[0].Value = usuario;
            cmd.Parameters[1].Value = contraseña;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            dsEmpleado = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dsEmpleado, "tabla");
            con.Close();

            //Itera sobre el dataset  para crear un obj empelado
            foreach (DataTable table in dsEmpleado.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    int idEmpleado = int.Parse(dr["idEmpleado"].ToString());
                    int idCargo = int.Parse(dr["idCargo"].ToString());
                    string dni = dr["DNI"].ToString();
                    string nombreEmpleado = dr["nombreEmpleado"].ToString();

                    int estado = int.Parse(dr["estado"].ToString());

                    empleado = new Empleado(idEmpleado, idCargo, dni, nombreEmpleado, usuario, contraseña, estado);
                }
            }

            if (empleado != null)
                return empleado;
            else
                return null;
        }


        public void actualizarEmpleado(ObjConexion obj, Empleado empleado) {
            conexion(obj);

            string sql = Constantes.ACTUALIZAR_EMPLEADO;

            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idEmpleado", OleDbType.Integer);
            cmd.Parameters.Add("idCargo", OleDbType.Integer);
            cmd.Parameters.Add("DNI", OleDbType.VarWChar, 8);
            cmd.Parameters.Add("nombreEmpleado", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("usuario", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("contraseña", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("estado", OleDbType.Integer);
            cmd.Parameters[0].Value = empleado.IdEmpleado;
            cmd.Parameters[1].Value = empleado.IdCargo;
            cmd.Parameters[2].Value = empleado.DNI;
            cmd.Parameters[3].Value = empleado.Nombre;
            cmd.Parameters[4].Value = empleado.Usuario;
            cmd.Parameters[5].Value = empleado.Contraseña;
            cmd.Parameters[6].Value = empleado.Estado;

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }

        public void eliminarEmpleado(ObjConexion obj, Empleado empleado) {
            conexion(obj);

            string sql = Constantes.ACTUALIZAR_EMPLEADO;

            // Set the Connection, CommandText and Parameters.
            cmd = new OleDbCommand(sql, con);

            cmd.Parameters.Add("idEmpleado", OleDbType.Integer);
            cmd.Parameters.Add("idCargo", OleDbType.Integer);
            cmd.Parameters.Add("DNI", OleDbType.VarWChar, 8);
            cmd.Parameters.Add("nombreEmpleado", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("usuario", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("contraseña", OleDbType.VarWChar, 20);
            cmd.Parameters.Add("estado", OleDbType.Integer);
            cmd.Parameters[0].Value = empleado.IdEmpleado;
            cmd.Parameters[1].Value = empleado.IdCargo;
            cmd.Parameters[2].Value = empleado.DNI;
            cmd.Parameters[3].Value = empleado.Nombre;
            cmd.Parameters[4].Value = empleado.Usuario;
            cmd.Parameters[5].Value = empleado.Contraseña;
            cmd.Parameters[6].Value = 0; // estado 0 --> Eliminado

            // Call  Prepare and ExecuteNonQuery.
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            closeConexion();
        }
    }
}
