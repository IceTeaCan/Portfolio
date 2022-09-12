using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    //Objeto WCF
    ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    //Metodo de acción al botón de consulta 
    protected void Accion_Click(object sender, EventArgs e)
    {
        try
        {
            if (tbxId.Text != String.Empty)
            {
                // recorrido de la información que es contenida en el metodo obtenido por el WCF 
                foreach (var value in proxy.ObtenerVentas(tbxId.Text))
                {
                    tbxTipoid.Text = value.Tipo_id.ToString();
                    tbxNombre.Text = value.nombre.ToString();
                    tbxJefe.Text = value.jefe.ToString();
                    tbxProv.Text = value.provincia.ToString();
                    tbxCuotaVent.Text = value.cuotaventas.ToString();
                    tbxBonificacion.Text = value.bonificacion.ToString();
                    tbxPorComision.Text = value.porccomision.ToString();
                    tbxVentasAn.Text = value.ventasanuales.ToString();
                    tbxVentAnioAnt.Text = value.ventasanioant.ToString();
                    tbxPromMens.Text = value.promediomensual.ToString();
                    tbxNombre.Text = value.nombre.ToString();
                    if(value.ventasanuales>=value.cuotaventas)
                    {
                        tbxComision.Text = Convert.ToString(value.ventasanuales * (value.porccomision/100));
                        lbl_Out.Text = "Ejecutado con exito";
                    }
                    else
                    {
                        tbxComision.Text = "0";
                        lbl_Out.Text = "Ejecutado con exito";
                    }
                }
            }
            else
            {
                lbl_Out.Text = "Error de acción";
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
}