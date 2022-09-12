using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataPry
{
    public class cls_Validar_Ingreso
    {
        cls_ConexionBD i_conexion = new cls_ConexionBD();
        public bool m_Verificar_Usuario(String nom, String apell)
        {
            try
            {
                SqlConnection Conection = new SqlConnection(this.i_conexion.conection);
                SqlCommand Comando = new SqlCommand("select * from ContactoPe where nombre = '" + nom + "' and apellido = '" + apell + "'", Conection);
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

        public string[] buscar_Contacto(String nom, String apell)
        {
            String[] contacto = new String[7];
            try
            {
                SqlConnection Conection = new SqlConnection(this.i_conexion.conection);
                SqlCommand Comando = new SqlCommand("select * from ContactoPe where nombre = '" + nom + "' and apellido = '" + apell + "'", Conection);
                Conection.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                if (reader.Read())
                {
                    contacto[0] = reader["nombre"].ToString();
                    contacto[1] = reader["Apellido"].ToString();
                    contacto[2] = reader["Telefono_celular"].ToString();
                    contacto[3] = reader["Correo"].ToString();
                    contacto[4] = reader["Direccion"].ToString();
                    contacto[5] = reader["Fecha_Nacimiento"].ToString();
                    contacto[6] = reader["Apodo"].ToString();
                }
                Conection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return contacto;
        }
    }
}
