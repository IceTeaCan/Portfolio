using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace WebTikiService
{
    //Tabla de encabezado donde se obtiene información
    [Table(Name = "Producto")]
    public class Producto
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdProducto { get; set; }

        [Column]
        public int IdSoda { get; set; }

        [Column]
        public string Nombre { get; set; }

        [Column]
        public decimal CostoUnitario { get; set; }
    }
}