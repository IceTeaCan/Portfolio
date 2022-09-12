using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace WebTikiService
{

    [Table(Name = "Pedido")]
    public class Pedido
    {
        [Column(IsDbGenerated = true)]
        public int IdPedido { get; set; }

        [Column]
        public int IdCarrito { get; set; }

        [Column]
        public int IdProducto { get; set; }

        [Column]
        public int IdSoda { get; set; }

        [Column]
        public int Cantidad { get; set; }

        [Column]
        public decimal CostoUnitario { get; set; }

        [Column]
        public decimal CostoTotal { get; set; }

    }
}