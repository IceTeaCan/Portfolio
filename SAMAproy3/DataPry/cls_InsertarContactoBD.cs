using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataPry
{
    public class cls_InsertarContactoBD
    {
        cls_ConexionBD i_conexion = new cls_ConexionBD();
        public void insertar_Contacto(string nombre, string apellido, string telefono_celular,
          string correo, string direccion, string fecha_nacimiento, string apodo)
        {
            try
            {
                SqlConnection Connection = new SqlConnection(i_conexion.conection);
                SqlCommand comando = new SqlCommand(); //PARA LLAMAR SENTENCIAS 
                SqlParameter p_nombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                p_nombre.Value = nombre;
                SqlParameter p_apellido = new SqlParameter("@Apellido", SqlDbType.VarChar);
                p_apellido.Value = apellido;
                SqlParameter p_telefono_celular = new SqlParameter("@Telefono_Celular", SqlDbType.Int);
                p_telefono_celular.Value = int.Parse(telefono_celular);
                SqlParameter p_correo = new SqlParameter("@Correo", SqlDbType.VarChar);
                p_correo.Value = correo;
                SqlParameter p_direcion = new SqlParameter("@Direccion", SqlDbType.VarChar);
                p_direcion.Value = direccion;
                SqlParameter p_fecha_nacimiento = new SqlParameter("@Fecha_Nacimiento", SqlDbType.VarChar);
                p_fecha_nacimiento.Value = fecha_nacimiento;
                SqlParameter p_apodo = new SqlParameter("@Apodo", SqlDbType.VarChar);
                p_apodo.Value = correo;


                comando.Parameters.Add(p_nombre);
                comando.Parameters.Add(p_apellido);
                comando.Parameters.Add(p_telefono_celular);
                comando.Parameters.Add(p_correo);
                comando.Parameters.Add(p_direcion);
                comando.Parameters.Add(p_fecha_nacimiento);
                comando.Parameters.Add(p_apodo);


                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Insertar_ContactoPe";
                Connection.Open();
                comando.Connection = Connection;
                comando.ExecuteNonQuery();
                Connection.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
