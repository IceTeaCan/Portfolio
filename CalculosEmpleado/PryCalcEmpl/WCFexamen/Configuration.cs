using System.Configuration;

namespace WCFcalcEmpl
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