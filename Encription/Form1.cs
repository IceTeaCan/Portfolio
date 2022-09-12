
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
  -------------------     Proyecto de desencripción de mensaje con valor agregado de encripción y simplificación de funciones                 ---------------------
  -------------------     Autor : Jonathan Salazar Rodríguez                                                                                  ---------------------
  -------------------     Profesor : Aarón Barquero Serrano                                                                                   ---------------------
  -------------------     Materia : Diseño y desarrollo de aplicaciones comerciales                           Fecha entrega : 4/6/2021        ---------------------
  -------------------                                                                                                                         ---------------------
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

using System;
using System.Windows.Forms;
using EncriptProcess;

namespace Encription
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Negocios word = new Negocios();
        private void button1_Click(object sender, EventArgs e)
        {
            tb_out.Text =  word.En(tb_IN.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_out.Text = word.De(tb_IN.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_out.Text = word.DeRes(tb_IN.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_out.Text = word.EnRes(tb_IN.Text);

        }
    }
}
