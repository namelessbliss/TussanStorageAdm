using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace CAPA_DATOS {
    /// <summary>
    /// Descripción breve de ClassAdo
    /// </summary>
    public class ClassAdo {
        protected OleDbConnection con = new OleDbConnection();
        protected OleDbCommand cmd;
        public ClassAdo() {

        }

        public void conexion(ObjConexion obj) //msn mensaje de retorno
        {
            con.ConnectionString = "Provider=SQLNCLI11;Data Source=" + obj.Server + ";Persist Security Info=True;User ID=" + obj.User + ";password=" + obj.Pass + ";Initial Catalog=" + obj.DB;
            con.Open();
        }
        public void transaccion(string sql) //1.- exito, 0 fallo
        {

            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public int login(string sql) //1.- exito, 0 fallo
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            int resultado = (Int32)cmd.ExecuteScalar();
            return resultado;
        }

        public int selectEscalar(string sql) //1.- exito, 0 fallo
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            int resultado = (Int32)cmd.ExecuteScalar();
            return resultado;
        }

        public DataSet consultasql(string sql) //retorna datos
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds, "tabla");
            con.Close();
            return ds;
        }

        public DataTable consultasqlDataTable(string sql) //retorna datos
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void closeConexion() {
            if (cmd != null)
                cmd.Dispose();
            con.Close();
        }
    }
}