using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
