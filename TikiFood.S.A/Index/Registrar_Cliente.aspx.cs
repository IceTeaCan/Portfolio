using Index.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Index
{
    public partial class Registrar_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        ServiceReference1.Service1Client Bd = new ServiceReference1.Service1Client();

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                var passtemp = (from cl in Bd.ObtenerUsuarioContrasenia(txt_IdUsuario.Text)
                                where cl.IdUsuario == Convert.ToInt32(txt_IdUsuario.Text)
                                select cl.Contraseña);


                ddprueba.DataSource = passtemp.ToList();
                ddprueba.DataBind();


                string contra = ddprueba.SelectedValue.ToString();
                Response.Write("<script>alert(contra)</script>");
                if (contra.Equals(""))
                {
                    if (txt_IdUsuario.Text != String.Empty && txt_nombre.Text != String.Empty && txt_apellido.Text != String.Empty &&
                       txt_correo.Text != String.Empty && txt_password.Text != String.Empty && txt_telefono.Text != String.Empty
                       && txt_direccion.Text != String.Empty)



                        Bd.AgregarCarrito(Convert.ToInt32(txt_IdUsuario.Text));
                    Bd.AgregarCliente(Convert.ToInt32(txt_IdUsuario.Text), txt_nombre.Text, txt_apellido.Text, txt_correo.Text, txt_password.Text,
                                                     txt_telefono.Text, txt_direccion.Text, Convert.ToInt32(Convert.ToInt32(txt_IdUsuario.Text)));
                    Response.Write("<script>alert('Usuario Registrado con exito')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Existe')</script>");
                    contra = "";


                }
            }
            catch (LinqDataSourceValidationException ex)
            {
                Response.Write(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
            finally
            {

                txt_IdUsuario.Text = "";
                txt_nombre.Text = "";
                txt_apellido.Text = "";
                txt_correo.Text = "";
                txt_password.Text = "";
                txt_telefono.Text = "";
                txt_direccion.Text = "";


            }

        }

        protected void txt_idcarrito_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void txt_IdUsuario_TextChanged(object sender, EventArgs e)
        {
                   }
    }
}