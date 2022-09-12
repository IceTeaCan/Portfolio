using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace WebTikiService
{
    [Table(Name = "Contenido")]
    public class IngrProducto
    {
        [Column(IsDbGenerated =true)]
        public int IdContenido { get; set; }

        [Column]
        public string Descripcion { get; set; }

        [Column]
        public int CantUniDisponible { get; set; }

        [Column]
        public decimal PrecioUnidad { get; set; }
    }
}