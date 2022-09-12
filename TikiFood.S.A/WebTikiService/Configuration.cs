using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WebTikiService
{
    public class Configuration
    {
        //Metodo de obtención de cadena de conexión
        public static string CadenaConexion
        {
            get { return ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString.ToString(); }
        }
    }
}