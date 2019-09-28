using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Descripción breve de ClassAdo
/// </summary>
public class ClassAdo {
    OleDbConnection con = new OleDbConnection();
    public ClassAdo() {

    }

    public void conexion(string db, string user, string pass, string server) //msn mensaje de retorno
    {
        con.ConnectionString = "Provider=SQLNCLI11;Data Source=" + server + ";Persist Security Info=True;User ID=" + user + ";password=" + pass + ";Initial Catalog=" + db;
        con.Open();
    }
    public void transaccion(string sql) //1.- exito, 0 fallo
    {
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = con;
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public int login(string sql) //1.- exito, 0 fallo
    {
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = con;
        cmd.CommandText = sql;
        return cmd.ExecuteNonQuery();
    }

    public DataSet consultasql(string sql) //retorna datos
    {
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
        da.Fill(ds, "tabla");
        return ds;
    }

    public void closeConexion() {
        con.Close();
    }
}