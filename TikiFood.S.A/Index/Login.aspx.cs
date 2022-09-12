using Index.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Index
{
    public partial class Loging : System.Web.UI.Page
    {
        public static int idCarrito { get; set; }
        public static string Nombre { get; set; }
        ServiceReference1.Service1Client Bd = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddPrueba.Visible = false;
            MsjError.Visible = true;
        }
        public static string paraAdmin;

        
        protected void Login_Click(object sender, EventArgs e)
        {
            foreach (var value in Bd.Login(Convert.ToInt32(Usuario.Text.Trim()), Contrasenia.Text.Trim()))
            {
                idCarrito = value.IdCarrito;
                Nombre = value.Nombre.ToString();
            }

            Session["ClienteContra"] = Usuario.Text;

            if (Usuario.Text == String.Empty || Contrasenia.Text == String.Empty)
            {
                MsjError.Text = "Error. Ningun campo debe estar vacio!";
            }
            else
            {
                var passtemp = (from cl in Bd.ObtenerUsuarioContrasenia(Usuario.Text)
                                where cl.IdUsuario == Convert.ToInt32(Usuario.Text)
                                select cl.Contraseña);


                ddPrueba.DataSource = passtemp.ToList();
                ddPrueba.DataBind();


                string contra = ddPrueba.SelectedValue.ToString();
                MsjError.Text = "*";


                if (contra == String.Empty)
                {
                    MsjError.Text = "Error al ingresar usuario o contraseña, por favor intentelo de nuevo";
                }
                else
                {
                    if (Contrasenia.Text == contra)
                    {
                        Response.Redirect("Default.aspx");
                    }

                }
            }

            if (Usuario.Text == String.Empty || Contrasenia.Text == String.Empty)
            {
                MsjError.Text = "Error. Ningun campo debe estar vacio!";
            }
            else
            {
                var passtemp = (from cl in Bd.ObtenerAdministradorContrasenia(Usuario.Text)
                                where cl.IdUsuario == Usuario.Text
                                select cl.Contraseña);
                ddPrueba.DataSource = passtemp.ToList();
                ddPrueba.DataBind();


                string contra = ddPrueba.SelectedValue.ToString();
                MsjError.Text = "*";


                if (contra == String.Empty)
                {
                    MsjError.Text = "Error al ingresar usuario o contraseña, porfavor intentelo de nuevo";
                }
                else
                {
                    if (Contrasenia.Text == contra)
                    {

                        var passtemp1 = (from cl in Bd.ObtenerAdministradorContrasenia(Usuario.Text)
                                         where cl.IdUsuario == Usuario.Text
                                         select cl.IdSoda);
                        ddPrueba.DataSource = passtemp1.ToList();
                        ddPrueba.DataBind();


                        Session["Ssoda"] = ddPrueba.SelectedValue.ToString();



                        Response.Redirect("Administrador.aspx");

                    }
                    else
                    {
                        MsjError.Text = "Error al ingresar usuario o contraseña, profavor intentelo de nuevo";
                    }

                }

            }

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar_Cliente.aspx");

        }

        protected void Contrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}