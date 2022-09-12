using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web.UI.WebControls;
using System.Data;

namespace WebTikiService
{
    public class Service1 : IService1
    {
        //Linq
        Enterprise bd = new Enterprise();

        //trae solo los productos 
        public List<Producto> ConsultarData(int id)
        {
            var consulta = from cl in bd.Product where cl.IdSoda == id select cl;
            return consulta.ToList();
        }


        public int ConsultIdPed(int idCarr)
        {
            try
            {
                var consulta = from cl in bd.Pedido where cl.IdCarrito == idCarr select cl;
                return consulta.Max(x => x.IdPedido);

            }catch(Exception ex)
            {
                ex.ToString();
                return 1;
            }
        }


        //trae el contenido de producto 
        public List<ContProd> ConsultContenido(int id)
        {
            var consulta = from cl in bd.ContProd where cl.IdProducto == id select cl;
            return consulta.ToList();
        }

        //trae el contenido de producto 
        public string ConsultContProd(int id)
        {
            var consulta = from cl in bd.IngrProduct where cl.IdContenido == id select cl.Descripcion;
            return consulta.Single();
        }

        //trae todos los productos 
        public List<Producto> ConsProduct()
        {
            var consulta = from cl in bd.Product select cl;
            return consulta.ToList();
        }

        //Trae info sodas 
        public List<Soda> InfoSoda()
        {
            var consulta = from cl in bd.Soda select cl;
            return consulta.ToList();
        }

        //Trae de la base compara y lleva el nombre a la pagina 
        public List<Usuario> Login(int IdUsuario, string Contraseña)
        {
            var User = from cl in bd.Usuario where cl.IdUsuario == IdUsuario && cl.Contraseña == Contraseña select cl;
            return User.ToList();
            
        }

        // Crear pedido
        public void AgregarPedido(int idPedido, int idCarrito, int idProducto, int cantidad, decimal costounitario, decimal costoTotal)
        {
            Pedido nuevoPedido = new Pedido { IdPedido = idPedido, IdCarrito = idCarrito, IdProducto = idProducto, Cantidad = cantidad, CostoUnitario = costounitario, CostoTotal = costoTotal };
            bd.Pedido.InsertOnSubmit(nuevoPedido);
            bd.SubmitChanges();

        }

        //Nuevo
        public List<Usuario> ObtenerUsuarios() {
            var Users = from cl in bd.Usuario select cl;

            return Users.ToList();
        }

        public List<Usuario> ObtenerUsuarioContrasenia(string cedula)
        {
            var consulta = from cl in bd.Usuario
                           where cl.IdUsuario.Equals(cedula)
                           select cl;
            return consulta.ToList();
        }

        public List<Administrador> ObtenerAdministradorContrasenia(string cedula)
        {
            var consulta = from cl in bd.Administrador
                           where cl.IdUsuario.Equals(cedula)
                           select cl;
            return consulta.ToList();
        }


        // trae el pedido 
        public List<Pedido> ObtenerPedido(int idPed, int car)
        {

            var consulta = from cl in bd.Pedido where (cl.IdPedido == idPed && cl.IdCarrito == car) select cl;
            return consulta.ToList();
        }

        //Trae el contenidoproductospersonalizado 

        public List<ContPersonalizado> ObtenerProductoPer(int shopC, int ped, int idProd, int iden)
        {

            var consulta = from cl in bd.ContPersonalizado where cl.IdCarrito == shopC && cl.IdPedido == ped && cl.IdProducto == idProd && cl.IdentDeProduct == iden select cl;
            return consulta.ToList();
        }

        // utilizada para calculo de contenidos 
        public int ObtenerMutlProdPers(int shopC, int ped, int idProd)
        {

            var consulta = from cl in bd.ContPersonalizado where cl.IdCarrito == shopC && cl.IdPedido == ped && cl.IdProducto == idProd group cl by cl.IdentDeProduct into grouped select new { IdentDeProduct = grouped.Key};
            return consulta.Count();
        }

        public List<ContPersonalizado> EditProductoPer(int shopC, int ped, int idProd, int iden)
        {

            var consulta = from cl in bd.ContPersonalizado where (cl.IdCarrito == shopC && cl.IdPedido == ped && cl.IdProducto == idProd && cl.IdentDeProduct == iden) select cl;
            return consulta.ToList();
        }

        //Ingresa valor a la tabla contenido personalizado 
        public void AgregarContPers(int idProd, int inde, int idCont, string ContNomb,int idCarr, int idPed,int cant)
        {
            ContPersonalizado nuevoPedido = new ContPersonalizado { IdProducto = idProd, IdentDeProduct = inde, IdContenido = idCont, ContNomb = ContNomb, IdCarrito = idCarr, IdPedido = idPed, Cantidad = cant };
            bd.ContPersonalizado.InsertOnSubmit(nuevoPedido);
            bd.SubmitChanges();

        }

        public void ModificarCantidad(int idPedido,int car, int cantidad, int identi)
        {
            ContPersonalizado pedido = bd.ContPersonalizado.Single(p => p.IdPedido == idPedido && p.IdCarrito == car&& p.IdentDeProduct == identi);

            pedido.Cantidad = cantidad;
            bd.SubmitChanges();

        }

        public void EliminarPedido(string nombre, int ped,int carr)
        {
            ContPersonalizado pedid = bd.ContPersonalizado.Single(c => c.ContNomb == nombre && c.IdPedido == ped&& c.IdCarrito == carr);
            bd.ContPersonalizado.DeleteOnSubmit(pedid);
            bd.SubmitChanges();
        }

        public void AgregarCliente(int idUsuario, string nombre, string apellido, string correo, string contraseña, string telefono, string localizacion, int idCarrito)
        {
          
            Usuario nuevoCliente = new Usuario { IdUsuario = idUsuario, Nombre = nombre, Apellido = apellido, Correo = correo, Contraseña = contraseña, Telefono = telefono, Localizacion = localizacion, IdCarrito = idCarrito };
            bd.Usuario.InsertOnSubmit(nuevoCliente);
             bd.SubmitChanges();
          

        }


        public void AgregarCarrito(int carrito) {
            Carrito nuevoCarrito = new Carrito { IdCarrito=carrito};
            bd.Carrito.InsertOnSubmit(nuevoCarrito);
           
                bd.SubmitChanges();
            
           
        }


        public List<Pedido> ObtenerPedidoPorIDSoda(int idsoda)
        {
            var consulta = from cl in bd.Pedido
                           where cl.IdSoda.Equals(idsoda)
                           select cl;
            return consulta.ToList();
        }




    }
}
