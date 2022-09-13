using System;
using System.Data.OleDb;
using System.Data;

namespace BaseData
{
    class MetodoDatos
    {
        public static OleDbCommand StoredProcedure()
        {
            string cadenaConexion = Conexion.CadenaConexion;
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand("consuLta", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            return comando;
        }

        public static DataTable EjecCommand(OleDbCommand comando)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                OleDbDataAdapter adaptador = new OleDbDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
            }
            catch (Exception ex) { throw ex; }
            finally { comando.Connection.Close(); }
            return tabla;
        }
    }
}
