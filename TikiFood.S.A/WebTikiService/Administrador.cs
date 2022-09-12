using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace WebTikiService
{
    [Table(Name = "Administrador")]
    public class Administrador
    {
        [Column]
        public string IdUsuario { get; set; }
        [Column]
        public string Nombre { get; set; }
        [Column]
        public string Apellido { get; set; }
        [Column]
        public string Correo { get; set; }
        [Column]
        public string Contraseña { get; set; }
        [Column]
        public string Telefono { get; set; }
        [Column]
        public string Localizacion { get; set; }
        [Column]
        public int IdSoda { get; set; }
        

    }
}