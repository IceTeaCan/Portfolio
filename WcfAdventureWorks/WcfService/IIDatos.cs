using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IIDatos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IIDatos
    {
        [OperationContract]
        Datos consultarData(string ID);              
    }

    [DataContract]
    public class Datos
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string loginID { get; set; }

        [DataMember]
        public string jobTitle { get; set; }

        [DataMember]
        public string birthDate { get; set; }

        [DataMember]
        public string Maritalstatus { get; set; }

        [DataMember]
        public string Gender { get; set; }
    }
}
