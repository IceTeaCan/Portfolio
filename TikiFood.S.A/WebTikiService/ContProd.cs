using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace WebTikiService
{
    [Table(Name ="Contenido_producto")]
    public class ContProd
    {
        [Column(IsPrimaryKey = true)]
        public int IdProducto { get; set; }

        [Column]
        public int IdContenido { get; set; }

        [Column]
        public int Cantidad { get; set; }
    }
}