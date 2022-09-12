using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace WebTikiService
{
    [Table(Name = "Contenido_prod_pers")]

    public class ContPersonalizado
    {
        [Column]
        public int IdProducto   { get; set; }

        [Column]
        public int IdentDeProduct { get; set; }
        
        [Column]
        public int IdContenido  { get; set; }

        [Column]
        public string ContNomb  { get; set; }

        [Column]
        public int IdCarrito    { get; set; }

        [Column]
        public int IdPedido     { get; set; }

        [Column]
        public int Cantidad     { get; set; }

    }
}