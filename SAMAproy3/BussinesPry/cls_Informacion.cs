using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPry;

namespace BussinesPry
{
    public class cls_Informacion
    {
        private string nombre = "";
        private string apellido = "";
        private int telefono_celular = 0;
        private string correo = "";
        private string direccion = "";
        private string fecha_cumpleanios = "";
        private string apodo = "";

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Telefono_celular { get => telefono_celular; set => telefono_celular = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Fecha_cumpleanios { get => fecha_cumpleanios; set => fecha_cumpleanios = value; }
        public string Apodo { get => apodo; set => apodo = value; }

        cls_Validar_Ingreso i_autenti_ingreso = new cls_Validar_Ingreso();

        public cls_Informacion()
        {

        }

        public cls_Informacion(string nombr, string apelli)
        {
            this.nombre = nombr;
            this.apellido = apelli;
        }
        public Boolean auten_Ingreso_Contacto()
        {
            if (i_autenti_ingreso.m_Verificar_Usuario(this.nombre, this.apellido) == true)
            {
                cls_Ingresos.guardarCon("Contacto " + this.nombre + " guardado con exito!!");
                return true;
            }
            else
            {
                cls_Ingresos.guardarCon("Intento fallido. Contacto: " + this.nombre);
                return false;
            }
        }

        public String[] m_Buscar_Contacto()
        {
            return i_autenti_ingreso.buscar_Contacto(this.nombre, this.apellido);
        }

        public void m_Insertar_Contacto(string nombre, string apellido, string telefono_celular,
           string correo, string direccion, string fecha_nacimiento, string apodo)
        {
            cls_InsertarContactoBD i_icontacto = new cls_InsertarContactoBD();
            i_icontacto.insertar_Contacto(nombre, apellido, telefono_celular, correo,
                direccion, fecha_nacimiento, apodo);
        }
        public bool m_Eliminar_Contacto(string telefono_celular)
        {
            cls_Eliminar_Contacto i_agenda = new cls_Eliminar_Contacto();
            if (i_agenda.m_Eliminar_Contacto(telefono_celular) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool m_Modificar_Contacto(string nombre, string apellido, string telefono_celular,
           string correo, string direccion, string fecha_nacimiento, string apodo)
        {
            cls_Modificar_Contacto i_agenda = new cls_Modificar_Contacto();
            if (i_agenda.m_Modificar_Contacto(nombre, apellido, telefono_celular, correo,
                direccion, fecha_nacimiento, apodo) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean m_Agenda()
        {
            cls_Agenda i_agenda = new cls_Agenda();
            if (i_agenda.m_Ver_Agenda() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean m_Agenda_Rapida()
        {
            cls_Agenda_Rapida i_agenda_rapida = new cls_Agenda_Rapida();
            if (i_agenda_rapida.m_Agenda_Rapida(this.nombre, this.apellido) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
