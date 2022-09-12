using System.Collections.Generic;
using System.ServiceModel;

namespace WCFexamen
{
    // Alumno: JonathanSalazar
    // Profesor : Clauido Mendez Cardenas

    //Contrato de servicios WCF
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Cliente> ObtenerVentas(string id);
        
    }
}
