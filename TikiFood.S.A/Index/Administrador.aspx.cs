using Index.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Index 
{
    
    public partial class Administrador    : System.Web.UI.Page
    {
       
       
        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            //dd_pedido.DataSource = proxy.ObtenerPedido();
            //dd_pedido.DataBind();

            int soda = Convert.ToInt32(Session["Ssoda"].ToString());
       
            dd_pedido.DataSource = proxy.ObtenerPedidoPorIDSoda(Convert.ToInt32(soda));
            dd_pedido.DataBind();


        }

        protected void dd_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}