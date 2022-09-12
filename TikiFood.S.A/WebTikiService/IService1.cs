using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;
using System.ServiceModel.Web;
using System.Text;

namespace WebTikiService
{
    //Servicio WCF para la pagina
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Producto> ConsultarData(int id);

        [OperationContract]
        List<ContProd> ConsultContenido(int id);

        [OperationContract]
        string ConsultContProd(int id);

        [OperationContract]
        int ConsultIdPed(int idCarri);
        
        [OperationContract]
        List<Producto> ConsProduct();

        [OperationContract]
        List<Soda> InfoSoda();

        [OperationContract]
        List<Usuario> Login(int IdUsuario, string Contraseña);

        [OperationContract]
        int ObtenerMutlProdPers(int shopC, int ped, int idProd);

        ///Nuevo Cr
        [OperationContract]
        List<Usuario> ObtenerUsuarios();

        [OperationContract]
        List<Administrador> ObtenerAdministradorContrasenia(string cedula);

        [OperationContract]
        List<Usuario> ObtenerUsuarioContrasenia(string cedula);

        [OperationContract]
        List<Pedido> ObtenerPedido(int ped, int carrito);

        [OperationContract]
        List<ContPersonalizado> ObtenerProductoPer(int shopC,int ped,int idProd, int iden);

        [OperationContract]
        List<ContPersonalizado> EditProductoPer(int carrito, int ped, int idProd, int identidad);

        [OperationContract]
        void AgregarPedido(int idPedido, int idCarrito, int idProducto, int cantidad, decimal costounitario, decimal costoTotal);

        [OperationContract]
        void EliminarPedido(string nombre,int pedido,int carrito);

        [OperationContract]
        void AgregarContPers(int idProd, int inde, int idCont, string ContNomb, int idCarr, int idPed, int cant);

        [OperationContract]
        void ModificarCantidad(int idPedido,int carrito, int cantidad, int identi);

        [OperationContract]
        void AgregarCliente(int idUsuario, string nombre, string apellido, string correo, string contraseña, string telefono, string localizacion, int idcarrito);

        [OperationContract]
        List<Pedido> ObtenerPedidoPorIDSoda(int idsoda);

        [OperationContract]
        void AgregarCarrito(int carrito);
    }
}
