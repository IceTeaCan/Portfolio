using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BaseData;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "IDatos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione IDatos.svc o IDatos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class IDatos : IIDatos
    {
        public Datos consultarData(string ID)
        {
            AccesoDatos json = new AccesoDatos();
            Datos dt = new Datos();
            try
            {
                dt.loginID = json.Consulta(ID).Rows[0]["LoginID"].ToString();
                dt.jobTitle = json.Consulta(ID).Rows[0]["JobTitle"].ToString();
                dt.birthDate = json.Consulta(ID).Rows[0]["BirthDate"].ToString();
                dt.Maritalstatus = json.Consulta(ID).Rows[0]["MaritalStatus"].ToString();
                dt.Gender = json.Consulta(ID).Rows[0]["Gender"].ToString();
                return dt;

            }catch(IndexOutOfRangeException exe)
            {
                exe.ToString();
                return dt;
            }
        }
    }
}
