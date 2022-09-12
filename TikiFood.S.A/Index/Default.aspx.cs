using Index.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Index
{
    public partial class _Default : Page
    {
        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            Nombre.Text = Loging.Nombre;
            try
            {
                // recorrido de la información que es contenida en el metodo obtenido por el WCF 
                foreach (var value in proxy.InfoSoda())
                {
                    if(value != null)
                    {
                        switch (value.IdSoda)
                        {
                            case 1:
                                lblSoda1.Text = value.Nombre.ToString();
                                lblTelSo1.Text = "Teléfono:" + value.Telefono.ToString();
                                lblLocSo1.Text = "Localización:" + value.Localizacion.ToString();
                                lblDesSo1.Text = "Descripción:" + value.Descripcion.ToString();
                                lblApSo1.Text = "Horario de apertura:" + value.Horario_ap.ToString();
                                lblCiSo1.Text = "Horario de cierre:" + value.Horario_ci.ToString();
                                lblSodaDis1.Text = value.Nombre.ToString();
                                lblSodaDis2.Text = "Teléfono:" + value.Telefono.ToString();
                                lblSodaDis3.Text = "Localización:" + value.Localizacion.ToString();
                                lblSodaDis4.Text = "Descripción:" + value.Descripcion.ToString();
                                lblSodaDis5.Text = "Horario de apertura:" + value.Horario_ap.ToString();
                                lblSodaDis6.Text = "Horario de cierre:" + value.Horario_ci.ToString();
                                break;
                            case 2:
                                lblSoda2.Text = value.Nombre.ToString();
                                lblTelSo2.Text = "Teléfono:" + value.Telefono.ToString();
                                lblLocSo2.Text = "Localización:" + value.Localizacion.ToString();
                                lblDesSo2.Text = "Descripción:" + value.Descripcion.ToString();
                                lblApSo2.Text = "Horario de apertura:" + value.Horario_ap.ToString();
                                lblCiSo2.Text = "Horario de cierre:" + value.Horario_ci.ToString();
                                lblSodaDis7.Text = value.Nombre.ToString();
                                lblSodaDis8.Text = "Teléfono:" + value.Telefono.ToString();
                                lblSodaDis9.Text = "Localización:" + value.Localizacion.ToString();
                                lblSodaDis10.Text = "Descripción:" + value.Descripcion.ToString();
                                lblSodaDis11.Text = "Horario de apertura:" + value.Horario_ap.ToString();
                                lblSodaDis12.Text = "Horario de cierre:" + value.Horario_ci.ToString();
                                break;
                            case 3:
                                lblSoda3.Text = value.Nombre.ToString();
                                lblTelSo3.Text = "Teléfono:" + value.Telefono.ToString();
                                lblLocSo3.Text = "Localización:" + value.Localizacion.ToString();
                                lblDesSo3.Text = "Descripción:" + value.Descripcion.ToString();
                                lblApSo3.Text = "Horario de apertura:" + value.Horario_ap.ToString();
                                lblCiSo3.Text = "Horario de cierre:" + value.Horario_ci.ToString();
                                lblSodaDis13.Text = value.Nombre.ToString();
                                lblSodaDis14.Text = "Teléfono:" + value.Telefono.ToString();
                                lblSodaDis15.Text = "Localización:" + value.Localizacion.ToString();
                                lblSodaDis16.Text = "Descripción:" + value.Descripcion.ToString();
                                lblSodaDis17.Text = "Horario de apertura:" + value.Horario_ap.ToString();
                                lblSodaDis18.Text = "Horario de cierre:" + value.Horario_ci.ToString();
                                break;
                            default:
                                
                                break;
                        }
                    }
                }
            }
            catch (LinqDataSourceValidationException exe)
            {
                Response.Write(exe.Message.ToString());
            }
            catch (Exception exe)
            {
                Response.Write(exe.Message.ToString());
            }
        }
    


    protected void btnProduct1_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.DataSource = proxy.ConsultarData(1);
            GridView1.DataBind();
        }

        protected void btnProduct2_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.DataSource = proxy.ConsultarData(2);
            GridView1.DataBind();
        }

        protected void btnProduct3_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.DataSource = proxy.ConsultarData(3);
            GridView1.DataBind();
        }

        protected void btnSoda1_Click(object sender, ImageClickEventArgs e)
        {
            Contact.ban = 1;
            Contact.negocio = 1;
            
        }

        protected void btnSoda2_Click(object sender, ImageClickEventArgs e)
        {
            Contact.ban = 1;
            Contact.negocio = 2;
        }

        protected void btnSoda3_Click(object sender, ImageClickEventArgs e)
        {
            Contact.ban = 1;
            Contact.negocio = 3;
        }
    }
}