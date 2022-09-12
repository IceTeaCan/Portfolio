using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WCFcalcEmpl
{
    //Base de datos de donde se obtendrá la información
    [Database(Name = "VentasxRegion")]
    public class Business : DataContext
    {
        public Business() : base(Configuration.CadenaConexion) { }
        //Se declaran las tablas con las que se va a trabajar y son contenidas en una lista
        public Table<Cliente> Clientes;
    }
}