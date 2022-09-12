using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataPry
{
    public class cls_Agenda_Rapida
    {
        cls_ConexionBD i_conexion = new cls_ConexionBD();
        public bool m_Agenda_Rapida(String nom, String apell)
        {
            try
            {
                SqlConnection Conection = new SqlConnection(this.i_conexion.conection);
                //SqlCommand Comando = new SqlCommand("select * from Contacto where nombre = '" + nom + "' and apellido = '" + apell + "'", Conection);
                SqlCommand Comando = new SqlCommand("select Nombre, Apellido, Telefono_Celular from ContactoPe", Conection);
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
