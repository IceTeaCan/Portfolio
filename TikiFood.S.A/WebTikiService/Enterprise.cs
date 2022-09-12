using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Web;

namespace WebTikiService
{
    //Base de datos de donde se obtendrá la información
    [Database(Name = "TikiFoodSA")]
    public class Enterprise:DataContext
    {
        public Enterprise() : base(Configuration.CadenaConexion) { }
        //Se declaran las tablas con las que se va a trabajar y son contenidas en una lista
        public Table<Producto> Product;
        public Table<Soda> Soda;
        public Table<Usuario> Usuario;
        public Table<Administrador> Administrador;
        public Table<ContProd> ContProd;
        public Table<Pedido> Pedido;
        public Table<ContPersonalizado> ContPersonalizado;

        public Table<Carrito> Carrito;

        public Table<IngrProducto> IngrProduct;
 
    }
}