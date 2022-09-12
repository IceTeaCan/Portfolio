using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataPry
{
    public class cls_Eliminar_Contacto
    {
        cls_ConexionBD i_conexion = new cls_ConexionBD();
        public bool m_Eliminar_Contacto(String telefono_celular)
        {
            try
            {
                SqlConnection Conection = new SqlConnection(this.i_conexion.conection);
                SqlCommand Comando = new SqlCommand("delete from ContactoPe where telefono_celular = '" + telefono_celular + "'", Conection);
                Conection.Open();
                if (Comando.ExecuteNonQuery() >= 1)
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
