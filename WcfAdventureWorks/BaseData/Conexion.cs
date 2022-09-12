using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData
{
    class Conexion
    {
        //Conexión OLEDB a AdventureWorks2017
        static string conexion = @"Provider=SQLNCLI11;Data Source=LAPTOP-JNQV22NK;Integrated Security=SSPI;Initial Catalog=AdventureWorks2017";
        public static string CadenaConexion { get { return conexion; } }
    }
}
