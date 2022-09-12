
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
  -------------------     Proyecto SAMA(Storage And Management Agenda) v3.0                                                                   ---------------------
  -------------------     Autor : Jonathan Salazar Rodríguez                                                                                  ---------------------
  -------------------     Profesor : Luis Felipe Fernández Alvarado                                                                           ---------------------
  -------------------     Materia : Programación III                                                    última modificación : 28/2/2021       ---------------------
  -------------------                                                                                                                         ---------------------
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using BussinesPry;

namespace StorageAndManagementAgenda
{
    public partial class Personal : Form
    {
        Cls_Registro Reg = new Cls_Registro();
        public Personal()
        {
            InitializeComponent();
        }

        //metodo que limpia las variables
        public void limpiar()
        {
            txbNombre.Text = "";
            txbUsuario.Text = "";
            txbCorreo.Text = "";
            txbContraseña.Text = "";
            txbConfirmar.Text = "";
            txbApellidos.Text = "";
        }
        private void btbRegistrar_Click(object sender, EventArgs e)
        {
            //compara las contraseñas 
            if (txbContraseña.Text == txbConfirmar.Text)
            {
                try
                {
                    //le pregunta al usuario si desea crear la cuenta
                    const string message = "Desea crear esta cuenta con este usuario y contraseña";
                    //almacena lo que devuelve el messagebox
                    var result = MessageBox.Show(message, "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //hace la validacion en caso de que diga que si
                    if (result == DialogResult.Yes)
                    {
                        //almaceno la contraseña incriptada que me devuelve el metodo de encriptación
                        string Contraseña = Reg.Encriptar(txbContraseña.Text);

                        //llama al metodo que inserta y se le envian los parametros
                        Reg.InsertarPRod(Contraseña.ToString(), txbUsuario.Text.ToString()
                            , txbCorreo.Text.ToString(), txbNombre.Text.ToString(), txbApellidos.Text.ToString());
                        f_Pers.Font = new Font(f_Pers.Font.Name, 20);

                        MessageBox.Show("Datos ingresados");
                        this.UseWaitCursor = true;
                        //espera 3 segundos 
                        Thread.Sleep(3000);

                        this.UseWaitCursor = false;

                        //se instancia el forms de ingreso y luego se muestra y se oculta este
                        Ingreso ing = new Ingreso();

                        ing.Show();

                        this.Hide();
                    }
                    //si el usuario dice que no se limpia los texboxs 
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
