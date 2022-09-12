using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataPry
{
    public class Registro
    {
        private ConexionBase conexion = new ConexionBase();

        //para los insert
        SqlCommand comando = new SqlCommand();

        //insert a las tablas de usuario y contraseña del registro personal
        #region registro del usuario y contraseña usuario
        public void Inser(string Contraseña, string Usuario, string Correo, string Nombre, String Apellidos)
        {
            comando.Connection = conexion.Abrirconexion();

            comando.CommandText = "Ingreso";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Contraseña", Contraseña);
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellidos", Apellidos);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

            conexion.CerrarConexion();
        }
        #endregion

        //insert a las tablas de usuario y contraseña del registro Empresarial
        #region registro del usuario y contraseña Empresa
        public void Insert_Empresa(string Contraseña, string Usuario, string Empresa, string Correo)
        {
            comando.Connection = conexion.Abrirconexion();

            comando.CommandText = "Empresarial_reg";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Contraseña", Contraseña);
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.Parameters.AddWithValue("@Nombre_Empresa", Empresa);
            comando.Parameters.AddWithValue("@Correo", Correo);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

            conexion.CerrarConexion();
        }
        #endregion

        public DataTable logear(string usuario, string contraseña)
        {

            conexion.Abrirconexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Registro WHERE Usuario = @Usuario AND Contraseña = @Contraseña", conexion.Abrirconexion());
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("contraseña", contraseña);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }


        public DataTable logearEmpresa(string usuario, string contraseña)
        {

            conexion.Abrirconexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Empresarial WHERE Usuario = @Usuario AND Contraseña = @Contraseña", conexion.Abrirconexion());
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("contraseña", contraseña);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }
    }
}
