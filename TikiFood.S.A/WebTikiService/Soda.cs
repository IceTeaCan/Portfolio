using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace WebTikiService
{
    //Tabla de encabezado donde se obtiene información
    [Table(Name = "Soda")]
    public class Soda
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdSoda { get; set; }

        [Column]
        public string Nombre { get; set; }

        [Column]
        public string Telefono { get; set; }

        [Column]
        public string Localizacion { get; set; }

        [Column]
        public string Descripcion { get; set; }

        [Column]
        public string Horario_ap { get; set; }

        [Column]
        public string Horario_ci { get; set; }
    }
}