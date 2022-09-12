using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPry;

namespace BussinesPry
{
    public class Cls_Registro
    {
        Registro ingreso = new Registro();

        //encripta la contraseña
        public string Encriptar(string acc)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(acc);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public void InsertarPRod(string Contraseña, string Usuario, string Correo, string Nombre, String Apellidos)
        {
            ingreso.Inser(Contraseña, Usuario, Correo, Nombre, Apellidos);

        }

        public void InsertarEmpresa(string Contraseña, string Usuario, string CorreoEmpresarial, string NombreEmpresa)
        {
            ingreso.Insert_Empresa(Contraseña, Usuario, CorreoEmpresarial, NombreEmpresa);
        }

        public Boolean log(string usuario, string contraseña)
        {

            DataTable login = ingreso.logear(usuario, contraseña);

            if (login.Rows.Count == 1)
            {
                return true;
            }
            else
                return false;
        }

        public Boolean logEmpresa(string usuario, string contraseña)
        {

            DataTable login = ingreso.logearEmpresa(usuario, contraseña);

            if (login.Rows.Count == 1)
            {
                return true;
            }
            else
                return false;
        }
    }
}
