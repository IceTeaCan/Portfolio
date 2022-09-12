using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataPry;

namespace BussinesPry
{
    public class BusinessCls
    {
        DataCls dato = new DataCls();
        private string usuario, email, nombre, apellido, direccion, empresa, ejemplo;
        private int telEmp, telCel;


        //-----------------------------------------------------------------------------------
        public void SetValue(string usu, string em, string nom, string ap, string dir, string emp, int tEm, int tCl)
        { this.usuario = usu; this.email = em; this.nombre = nom; this.apellido = ap; this.direccion = dir; this.empresa = emp; this.telEmp = tEm; this.telCel = tCl; }
        public void SetDel(int refe) { this.telCel = refe; }
        public void Ejemplo(string name) { this.ejemplo = name; }
        public string GetUsuario() { return usuario; }
        public string GetEmail() { return email; }
        public string GetNombre() { return nombre; }
        public string GetApellido() { return apellido; }
        public string GetDireccion() { return direccion; }
        public string GetEmpresa() { return empresa; }
        public int GetTelEmp() { return telEmp; }
        public int GetTelCel() { return telCel; }

        //------------------------------------------------------------------------------------------------
        public void SetContacto() { dato.Insertar_Contacto(GetUsuario(), GetEmail(), GetNombre(), GetApellido(), GetTelEmp(), GetTelCel(), GetDireccion(), GetEmpresa()); }
        public DataTable GimmeTheContact() { return dato.Consultar_contactos(); }
        public void DelContact() { dato.Eliminar_Contacto(GetTelCel()); }
        public void ModUsuario(string value,int refe)    { dato.Mod_Usuario(value,refe);    }
        public void ModNombre(string value, int refe)    { dato.Mod_Nombre(value, refe);    }
        public void ModApellido(string value, int refe)  { dato.Mod_Apellido(value, refe);  }
        public void ModEmail(string value, int refe)     { dato.Mod_Email(value, refe);     }
        public void ModEmpresa(string value, int refe)   { dato.Mod_Empresa(value, refe);   }
        public void ModDireccion(string value, int refe) { dato.Mod_Direccion(value, refe); }
        public void ModTelEmp(int value, int refe)       { dato.Mod_TelEmp(value, refe);    }
        public void ModTelCel(int value, int refe)       { dato.Mod_TelCel(value, refe);    }

        //------------------------------------------------------------------------------------------------
        public void Write()
        {
            string path = @"C:\Users\micke\source\repos\StorageAndManagementAgenda\carepool.co";
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path)) { sw.WriteLine(usuario +" "+ ejemplo+ DateTime.Now); }
                }
                else if (File.Exists(path))
                {
                    using (StreamWriter sw = File.AppendText(path)) { sw.WriteLine(usuario +" "+ ejemplo+ DateTime.Now); }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        } 
    }
}
