using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataPry
{
    public class ConexionBase
    {
        //el string de conexion
        private SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-JNQV22NK\tican;Initial Catalog=Agenda;Integrated Security=True");
        //abre la conexion
        public SqlConnection Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)

                    conexion.Open();

                return conexion;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //cierra la conexion
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)

                conexion.Close();

            return conexion;
        }
    }
}
