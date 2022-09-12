using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Factura
{
    class Coneccion
    {
        public string connect = "Data Source=host;Initial Catalog=Facturacion;Integrated Security=True";

        public DataTable SeeProduct()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string sql = "SELECT * FROM PRODUCTO";
                DataTable contenido = new DataTable();
                SqlCommand comando = new SqlCommand(sql, conn);
                SqlDataAdapter read = new SqlDataAdapter(comando);
                read.Fill(contenido);
                return contenido;
            }
        }
        public DataTable SeeDetalle()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string sql = "SELECT * FROM DETALLE";
                DataTable contenido = new DataTable();
                SqlCommand comando = new SqlCommand(sql, conn);
                SqlDataAdapter read = new SqlDataAdapter(comando);
                read.Fill(contenido);
                return contenido;
            }
        }
        public long SeeIdDeta()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                long id;
                try
                {
                    conn.Open();
                    string sql = "SELECT MAX(Id_proforma) FROM DETALLE";
                    DataTable contenido = new DataTable();
                    SqlCommand comando = new SqlCommand(sql, conn);
                    
                    id = Convert.ToInt64(comando.ExecuteScalar());
                    return id;
                    
                }
                catch(Exception exe)
                {
                    exe.ToString();
                    return 0;
                }
                
            }
        }
        public long SetPRecTotal( long ide,int cant)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string sql = "SELECT Precio FROM Producto WHERE Id_producto ="+ide;
                DataTable contenido = new DataTable();
                SqlCommand comando = new SqlCommand(sql, conn);                
                long precio = Convert.ToInt64(comando.ExecuteScalar())*cant;
                return precio;  
            }
        }

        public void SetDetalle(long idProf,int cantidad, long idProducto, long numeroId,long precio)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter idPro = new SqlParameter("@Id_proforma", SqlDbType.BigInt);
                idPro.Value = idProf;
                SqlParameter idClient = new SqlParameter("@Client", SqlDbType.BigInt);
                idClient.Value = numeroId;
                SqlParameter prod = new SqlParameter("@Id_prod", SqlDbType.BigInt);
                prod.Value = idProducto;
                SqlParameter prec = new SqlParameter("@PrecioTotal", SqlDbType.BigInt);
                prec.Value = precio;
                SqlParameter cant = new SqlParameter("@Cantidad", SqlDbType.Int);
                cant.Value = cantidad;                

                comando.Parameters.Add(idPro);
                comando.Parameters.Add(idClient);
                comando.Parameters.Add(prod);
                comando.Parameters.Add(prec);
                comando.Parameters.Add(cant);
                

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SetDetalle";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }
        public void SetContacto(long idCliente, string nombre)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter idClient = new SqlParameter("@Cedula", SqlDbType.BigInt);
                idClient.Value = idCliente;
                SqlParameter name = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                name.Value = nombre;

                comando.Parameters.Add(idClient);
                comando.Parameters.Add(name);


                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SetCliente";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }
        }

        public long SeeIdFac()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                long id;
                try
                {
                    conn.Open();
                    string sql = "SELECT MAX(Id_factura) FROM Factura";
                    DataTable contenido = new DataTable();
                    SqlCommand comando = new SqlCommand(sql, conn);

                    id = Convert.ToInt64(comando.ExecuteScalar());
                    return id;

                }
                catch (Exception exe)
                {
                    exe.ToString();
                    return 0;
                }

            }
        }
        public void SetFac(long idFactura, long idProforma)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand comando = new SqlCommand();
                SqlParameter idFac = new SqlParameter("@Id_factura", SqlDbType.BigInt);
                idFac.Value = idFactura;
                SqlParameter idProf = new SqlParameter("@Id_proforma", SqlDbType.BigInt);
                idProf.Value = idProforma;

                comando.Parameters.Add(idFac);
                comando.Parameters.Add(idProf);


                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SetFactura";
                comando.Connection = conn;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe) { throw exe; }


        }
    }
}
