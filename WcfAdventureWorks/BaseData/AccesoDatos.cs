using System.Data.OleDb;
using System.Data;

namespace BaseData
{
    public class AccesoDatos
    {
        public DataTable Consulta(string cedula)
        {
            OleDbCommand comando = MetodoDatos.StoredProcedure();
            comando.Parameters.AddWithValue("@ID", cedula);
            return MetodoDatos.EjecCommand(comando);
        }
    }
}
