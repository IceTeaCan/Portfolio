using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataPry
{
    public class DataCls
    {
        //BDconnection connect = new BDconnection();
        public static string connect = "Data Source=LAPTOP-JNQV22NK;Initial Catalog=Agenda;Integrated Security=True";
        public void Insertar_Contacto(string usuario, string email, string nombre, string apellido, int telEmp, int telCel, string direccion, string empresa)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();

                SqlParameter usu = new SqlParameter("@Usuario", SqlDbType.NVarChar);
                usu.Value = usuario;
                SqlParameter correo = new SqlParameter("@email", SqlDbType.NVarChar);
                correo.Value = email;
                SqlParameter name = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                name.Value = nombre;
                SqlParameter last_name = new SqlParameter("@Apellido", SqlDbType.NVarChar);
                last_name.Value = apellido;
                SqlParameter emp_num = new SqlParameter("@TelEmp", SqlDbType.Int);
                emp_num.Value = telEmp;
                SqlParameter cel_number = new SqlParameter("@TelCel", SqlDbType.Int);
                cel_number.Value = telCel;
                SqlParameter direction = new SqlParameter("@Direccion", SqlDbType.NVarChar);
                direction.Value = direccion;
                SqlParameter enterprice = new SqlParameter("@Empresa", SqlDbType.NVarChar);
                enterprice.Value = empresa;

                comando.Parameters.Add(usu);
                comando.Parameters.Add(correo);
                comando.Parameters.Add(name);
                comando.Parameters.Add(last_name);
                comando.Parameters.Add(emp_num);
                comando.Parameters.Add(cel_number);
                comando.Parameters.Add(direction);
                comando.Parameters.Add(enterprice);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Ingresar_contacto";
                conn.Open();
                comando.Connection = conn;
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }

        public DataTable Consultar_contactos()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string sql = "SELECT * FROM CONTACTO";
                DataTable contenido = new DataTable();
                SqlCommand comando = new SqlCommand(sql, conn);
                //comando.CommandText = "Consultar_Contacto";
                //comando.Connection = conn;
                //comando.ExecuteNonQuery();
                SqlDataAdapter read = new SqlDataAdapter(comando);
                read.Fill(contenido);
                return contenido;
            }
        }
        public void Eliminar_Contacto(int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference;

                comando.Parameters.Add(refe);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Eliminar_contacto";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void Mod_Usuario(string newValue,int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference;
                SqlParameter send = new SqlParameter("@NewUsuario", SqlDbType.NVarChar);
                send.Value = newValue;
                
                comando.Parameters.Add(refe);
                comando.Parameters.Add(send);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Modificar_usuario";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void Mod_Nombre(string newValue, int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference;
                SqlParameter send = new SqlParameter("@NewNombre", SqlDbType.NVarChar);
                send.Value = newValue;

                comando.Parameters.Add(refe);
                comando.Parameters.Add(send);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Modificar_Nombre";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void Mod_Apellido(string newValue, int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference;
                SqlParameter send = new SqlParameter("@NewApellido", SqlDbType.NVarChar);
                send.Value = newValue;

                comando.Parameters.Add(refe);
                comando.Parameters.Add(send); 

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Modificar_Apellido";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void Mod_Email(string newValue, int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference; ;
                SqlParameter send = new SqlParameter("@NewEmail", SqlDbType.NVarChar);
                send.Value = newValue;

                comando.Parameters.Add(refe);
                comando.Parameters.Add(send);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Modificar_Email";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void Mod_Empresa(string newValue, int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference;
                SqlParameter send = new SqlParameter("@NewEmpresa", SqlDbType.NVarChar);
                send.Value = newValue;

                comando.Parameters.Add(refe);
                comando.Parameters.Add(send);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Modificar_Empresa";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void Mod_Direccion(string newValue, int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference;
                SqlParameter send = new SqlParameter("@NewDireccion", SqlDbType.NVarChar);
                send.Value = newValue;

                comando.Parameters.Add(refe);
                comando.Parameters.Add(send);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Modificar_Direccion";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void Mod_TelEmp(int newValue, int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference;
                SqlParameter send = new SqlParameter("@NewTelEmp", SqlDbType.Int);
                send.Value = newValue;

                comando.Parameters.Add(refe);
                comando.Parameters.Add(send);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Modificar_TelEmp";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void Mod_TelCel(int newValue, int reference)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter refe = new SqlParameter("@tel", SqlDbType.Int);
                refe.Value = reference;
                SqlParameter send = new SqlParameter("@NewTelCel", SqlDbType.Int);
                send.Value = newValue;

                comando.Parameters.Add(refe);
                comando.Parameters.Add(send);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Modificar_TelCel";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
    }
}
