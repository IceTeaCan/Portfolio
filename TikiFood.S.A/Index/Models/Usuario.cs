using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Index.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Contraseña { get; set; }

        public string Telefono { get; set; }

        public string Localizacion { get; set; }

        public int IdCarrito { get; set; }
    }
}