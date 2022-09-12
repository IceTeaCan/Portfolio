using System.Collections.Generic;
using System.Linq;

namespace WCFexamen
{
    public class Service1 : IService1
    {
        //Declaración de objeto basedatos para utilizarlo en método consulta Linq 
        Business bd = new Business();
        public List<Cliente> ObtenerVentas(string id)
        {
            var consulta = from cl in bd.Clientes where cl.id == id select cl;
            return consulta.ToList();
        }
    }
}
