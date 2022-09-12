
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
  -------------------     Proyecto SAMA(Storage And Management Agenda) v3.0                                                                   ---------------------
  -------------------     Autor : Jonathan Salazar Rodríguez                                                                                  ---------------------
  -------------------     Profesor : Luis Felipe Fernández Alvarado                                                                           ---------------------
  -------------------     Materia : Programación III                                                    última modificación : 28/2/2021       ---------------------
  -------------------                                                                                                                         ---------------------
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

using System;
using System.Windows.Forms;
using BussinesPry;

namespace StorageAndManagementAgenda
{
    public partial class Ingreso : Form
    {
        Cls_Registro ingre = new Cls_Registro();
        public Ingreso()
        {
            InitializeComponent();
        }

        private void login()
        {
            string Contra = ingre.Encriptar(txbContra.Text);
            Boolean estado = ingre.log(txbUser.Text, Contra);

            if (estado == true)
            {
                label3.Text = "BIENVENIDO";
                f_Menu_Agenda_Personal principal = new f_Menu_Agenda_Personal();
                principal.Show();
                this.Hide();
            }

            else if (estado == false)
            {
                MessageBox.Show("Contraseña o Usuario incorrectos");
            }
        }

        private void loginEmpresa()
        {
            txbContra.Text = ingre.Encriptar(txbContra.Text);
            Boolean estado = ingre.logEmpresa(txbUser.Text, txbContra.Text);

            if (estado == true)
            {
                label3.Text = "BIENVENIDO";
                GUI Enterprice = new GUI();
                Enterprice.Show();
                this.Hide();

            }

            else if (estado == false)
            {
                MessageBox.Show("Contraseña o Usuario incorrectos");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbPersonal.Checked)
            {
                login();
            }
            else if (tbEmpresa.Checked)
            {
                loginEmpresa();
            }

            else
            {
                MessageBox.Show("No a seleccionado ninguna opcion");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            #region abre el form del registro personal
            Personal registro = new Personal();

            registro.Show();

            this.Hide();
            #endregion
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            #region abre el form del registro empresarial
            Empresarial registro = new Empresarial();

            registro.Show();

            this.Hide();
            #endregion
        }
    }
}
