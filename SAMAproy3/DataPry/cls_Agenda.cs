using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataPry
{
    public class cls_Agenda
    {
        cls_ConexionBD i_conexion = new cls_ConexionBD();
        public Boolean m_Ver_Agenda()
        {
            try
            {
                SqlConnection Conection = new SqlConnection(this.i_conexion.conection);
                SqlCommand Comando = new SqlCommand("select * from ContactoPe", Conection);
                Conection.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                Conection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
