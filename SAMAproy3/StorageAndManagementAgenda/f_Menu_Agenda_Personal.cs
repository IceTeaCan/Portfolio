using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesPry;

namespace StorageAndManagementAgenda
{
    public partial class f_Menu_Agenda_Personal : Form
    {
        public f_Menu_Agenda_Personal()
        {
            InitializeComponent();
        }

        private void btn_agenda_Click(object sender, EventArgs e)
        {
            cls_Informacion i_in = new cls_Informacion();
            if (i_in.m_Agenda() == true)
            {
                MessageBox.Show("Bienvenid@ a su Agenda");
                f_Agenda form = new f_Agenda(); ;
                form.Show();
                this.Hide();
            }
        }

        private void btn_agenda_rapida_Click(object sender, EventArgs e)
        {
            cls_Informacion i_in = new cls_Informacion(txtb_nombre.Text, txtb_apellido.Text);
            if (i_in.m_Agenda_Rapida() == true)
            {
                MessageBox.Show("Bienvenid@ a su Agenda Rapida");
                f_Agenda_Rapida form = new f_Agenda_Rapida(); ;
                form.Show();
                this.Hide();
            }
        }
        private void btn_salir_atras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Pronto");
            Ingreso menu = new Ingreso();
            menu.Show();
            this.Hide();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cls_Informacion cls_Informacion = new cls_Informacion(txtb_nombre.Text, txtb_apellido.Text);
            String[] contacto = cls_Informacion.m_Buscar_Contacto();
            txtb_nombre.Text = contacto[0];
            txtb_apellido.Text = contacto[1];
            txtb_tele_celular.Text = contacto[2];
            txtb_correo.Text = contacto[3];
            txtb_direccion.Text = contacto[4];
            txtb_fechanacimiento.Text = contacto[5];
            txtb_apodo.Text = contacto[6];
        }
        private void btn_contacto_nuevo_Click(object sender, EventArgs e)
        {
            cls_Informacion i_informacion = new cls_Informacion(txtb_nombre.Text, txtb_apellido.Text);
            i_informacion.m_Insertar_Contacto(txtb_nombre.Text, txtb_apellido.Text, txtb_tele_celular.Text, txtb_correo.Text,
                txtb_direccion.Text, txtb_fechanacimiento.Text, txtb_apodo.Text);

            if (i_informacion.auten_Ingreso_Contacto() == true)
            {
                MessageBox.Show("Ingreso Correcto");
            }
            else
            {
                MessageBox.Show("Ingreso Incorrecto");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            cls_Informacion i_in = new cls_Informacion();
            if (i_in.m_Modificar_Contacto(txtb_nombre.Text, txtb_apellido.Text, txtb_tele_celular.Text, txtb_correo.Text, txtb_direccion.Text, txtb_fechanacimiento.Text, txtb_apodo.Text) == true)
            {
                MessageBox.Show("Contacto Modificado con Exito!!");
            }
            else
            {
                MessageBox.Show("No se Pudo Modificar el Contacto!!");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            cls_Informacion i_in = new cls_Informacion();
            if (i_in.m_Eliminar_Contacto(txtb_tele_celular.Text) == true)
            {
                MessageBox.Show("Contacto Eliminado con Exito!!");
            }
            else
            {
                MessageBox.Show("Eliminacion Sin Exito!!");
            }
        }
    }
}
