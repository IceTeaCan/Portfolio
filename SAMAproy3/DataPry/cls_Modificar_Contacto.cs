using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataPry
{
    public class cls_Modificar_Contacto
    {
        cls_ConexionBD i_conexion = new cls_ConexionBD();
        public bool m_Modificar_Contacto(string nombre, string apellido, string telefono_celular,
           string correo, string direccion, string fecha_nacimiento, string apodo)
        {
            try
            {
                SqlConnection Conection = new SqlConnection(this.i_conexion.conection);
                SqlCommand Comando = new SqlCommand("update ContactoPe set Nombre='" + nombre
                    + "', Apellido='" + apellido
                    + "', Correo = '" + correo
                    + "', Direccion='" + direccion
                    + "', Fecha_Nacimiento='" + fecha_nacimiento
                    + "', Apodo='" + apodo
                    + "' where telefono_celular = '" + telefono_celular + "'", Conection);
                Conection.Open();
                if (Comando.ExecuteNonQuery() == 1)
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
