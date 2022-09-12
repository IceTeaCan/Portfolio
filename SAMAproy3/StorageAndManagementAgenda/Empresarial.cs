
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
  -------------------     Proyecto SAMA(Storage And Management Agenda) v3.0                                                                   ---------------------
  -------------------     Autor : Jonathan Salazar Rodríguez                                                                                  ---------------------
  -------------------     Profesor : Luis Felipe Fernández Alvarado                                                                           ---------------------
  -------------------     Materia : Programación III                                                    última modificación : 28/2/2021       ---------------------
  -------------------                                                                                                                         ---------------------
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

using System;
using System.Threading;
using System.Windows.Forms;
using BussinesPry;

namespace StorageAndManagementAgenda
{
    public partial class Empresarial : Form
    {
        Cls_Registro Regis = new Cls_Registro();
        public Empresarial()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txbNombre_Empresa.Text = "";
            texContraseña_Empresa.Text = "";
            texCorreo_Empresa.Text = "";
            texUsuario_Empresa.Text = "";
            txbConfirmar.Text = "";
        }

        private void Empresa_Click(object sender, EventArgs e)
        {
            if (texContraseña_Empresa.Text == txbConfirmar.Text)
            {
                try
                {
                    const string message = "Desea crear esta cuenta con este usuario y contraseña";
                    var result = MessageBox.Show(message, "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        string Contraseña_Empresa = Regis.Encriptar(texContraseña_Empresa.Text);

                        Regis.InsertarEmpresa(Contraseña_Empresa.ToString(), texUsuario_Empresa.Text.ToString(),
                            texCorreo_Empresa.Text.ToString(), txbNombre_Empresa.Text.ToString());

                        MessageBox.Show("Datos insertados correctamente");

                        this.UseWaitCursor = true;

                        Thread.Sleep(2000);

                        this.UseWaitCursor = false;

                        Ingreso ing = new Ingreso();

                        ing.Show();

                        this.Hide();
                    }
                    else
                        limpiar();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron ingresar Datos ");
                    ex.ToString();
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no conciden");
            }
        }
    }
}
