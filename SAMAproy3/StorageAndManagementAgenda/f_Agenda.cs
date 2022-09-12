using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAndManagementAgenda
{
    public partial class f_Agenda : Form
    {
        public f_Agenda()
        {
            InitializeComponent();
        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            //VUELVE AL MENU PRINCIPAL
            MessageBox.Show("Bienvenido al Menu");
            f_Menu_Agenda_Personal form = new f_Menu_Agenda_Personal(); ;
            form.Show();
            this.Hide();
        }
        private void f_Agenda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet1.ContactoPe' Puede moverla o quitarla según sea necesario.
            this.contactoPeTableAdapter.Fill(this.agendaDataSet1.ContactoPe);

        }
    }
}
