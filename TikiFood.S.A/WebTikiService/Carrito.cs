using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
namespace WebTikiService
{

    [Table(Name = "Carrito")]
    public class Carrito
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = false)]
        public int IdCarrito { get; set; }

       
    }
}