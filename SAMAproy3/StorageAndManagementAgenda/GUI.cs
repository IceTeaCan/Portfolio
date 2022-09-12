
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
  -------------------     Proyecto SAMA(Storage And Management Agenda) v3.0                                                                   ---------------------
  -------------------     Autor : Jonathan Salazar Rodríguez                                                                                  ---------------------
  -------------------     Profesor : Luis Felipe Fernández Alvarado                                                                           ---------------------
  -------------------     Materia : Programación III                                                    última modificación : 28/2/2021       ---------------------
  -------------------                                                                                                                         ---------------------
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BussinesPry;

namespace StorageAndManagementAgenda
{
    public partial class GUI : Form
    {
        //objeto isntaciado de la capa 
        BusinessCls inf = new BusinessCls();
        //constructor
        public GUI()
        {
            InitializeComponent();
            //Ingreso logueo = new Ingreso();
            //logueo.Show();
            //this.Hide();
        }

        private void option_btn_Click(object sender, EventArgs e)
        {
            if (gb_Options.Visible == true) gb_Options.Visible = false;  else gb_Options.Visible = true; 
        }
        private void btn_lightMode_Click(object sender, EventArgs e)
        {
            if(BackColor == Color.Black)
            {
                BackColor = Color.White;
                lbl_nombre.ForeColor = Color.Black;
                lbl_email.ForeColor = Color.Black;
                lbl_apellido.ForeColor = Color.Black;
                lbl_TelEmp.ForeColor = Color.Black;
                lbl_avisos.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                gb_Mod.ForeColor = Color.Black;
                gb_Options.ForeColor = Color.Black;
                gb_Mod.BackColor = Color.Gray;
            }
            else if (BackColor == Color.White)
            {
                BackColor = Color.Black;
                lbl_nombre.ForeColor = Color.White;
                lbl_email.ForeColor = Color.White;
                lbl_apellido.ForeColor = Color.White;
                lbl_TelEmp.ForeColor = Color.White;
                lbl_avisos.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                gb_Mod.ForeColor = Color.White;
                gb_Options.ForeColor = Color.White;
                gb_Mod.BackColor = Color.Transparent;
            }
        }
        public void Data()
        {
            DataTable dataTbl = inf.GimmeTheContact();
            dataGridView1.DataSource = dataTbl;
        }
        private void GUI_Load(object sender, EventArgs e)
        {
            Data();
        }
        public void Hilo()
        {
            ThreadStart delegado = new ThreadStart(inf.Write); Thread hilo = new Thread(delegado); hilo.Start();
        }
        private void btn_Action_Click(object sender, EventArgs e)
        {
            string el = "Acción: Eliminar",ing = "Acción: Ingreso";
            //inf.SetEj("Acción: Eliminar");inf.SetEj("Acción: Modificar");inf.SetEj("Acción: Ingreso");

            if (rb_Eliminar.Checked) { inf.SetDel(int.Parse(tb_nombre.Text.ToString())); inf.DelContact(); inf.Ejemplo(el); Hilo(); Data();
                lbl_email.Visible = true; lbl_email.Text = "Eliminado con exito"; }

            else if (rb_Modificar.Checked) 
            {
                try
                {
                    if (rb_nombre.Checked) { inf.ModNombre(tb_TelEmp.Text,int.Parse(tb_nombre.Text.ToString())); }
                    else if (rb_usuario.Checked) { inf.ModUsuario(tb_TelEmp.Text, int.Parse(tb_nombre.Text.ToString())); }
                    else if (rb_apellido.Checked) { inf.ModApellido(tb_TelEmp.Text, int.Parse(tb_nombre.Text.ToString())); }
                    else if (rb_email.Checked) { inf.ModEmail(tb_TelEmp.Text, int.Parse(tb_nombre.Text.ToString())); }
                    else if (rb_empresa.Checked) { inf.ModEmpresa(tb_TelEmp.Text, int.Parse(tb_nombre.Text.ToString())); }
                    else if (rb_direccion.Checked) { inf.ModDireccion(tb_TelEmp.Text, int.Parse(tb_nombre.Text.ToString())); }
                    else if (rb_TelEmp.Checked) { inf.ModTelEmp(int.Parse(tb_TelEmp.Text.ToString()), int.Parse(tb_nombre.Text.ToString())); }
                    else if (rb_TelCel.Checked) { inf.ModTelCel(int.Parse(tb_TelEmp.Text.ToString()), int.Parse(tb_nombre.Text.ToString())); }
                }catch(Exception exc)
                {
                    exc.ToString();
                    MessageBox.Show(exc.ToString());
                }
            }

            else if (rb_Ingresar.Checked) { inf.SetValue("usuario", tb_email.Text, tb_nombre.Text, tb_apellido.Text, tb_direccion.Text, tb_Empresa.Text, Convert.ToInt32(tb_TelEmp.Text.ToString()), Convert.ToInt32(tb_TelCel.Text.ToString())); inf.SetContacto(); inf.Ejemplo(ing); Hilo(); Data(); }
            Data();
        }

        private void cb_ShowBD_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_ShowBD.Checked) { dataGridView1.Visible = true; } else { dataGridView1.Visible = false; }
        }

        private void cb_ElimCont_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ElimCont.Checked) { gb_Mod.Visible = true; } else { gb_Mod.Visible = false; }
        }

        private void cb_Image_CheckedChanged(object sender, EventArgs e)
        {
            //Image imagen = this.BackgroundImage,im = imagen;
            if (cb_Image.Checked)
            { 
                this.BackgroundImage = null; btn_lightMode.Enabled = true;
                if (BackColor == Color.White)
                {
                    lbl_nombre.ForeColor = Color.Black;
                    lbl_email.ForeColor = Color.Black;
                    lbl_apellido.ForeColor = Color.Black;
                    lbl_TelEmp.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    gb_Mod.ForeColor = Color.Black;
                    gb_Mod.BackColor = Color.Gray;
                }
            } else 
            { 
                this.BackgroundImage = pictureBox1.Image; btn_lightMode.Enabled = false;
                if (BackColor == Color.White)
                {
                    lbl_nombre.ForeColor = Color.White;
                    lbl_email.ForeColor = Color.White;
                    lbl_apellido.ForeColor = Color.White;
                    lbl_TelEmp.ForeColor = Color.White;
                    lbl_avisos.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    gb_Mod.ForeColor = Color.White;
                    gb_Mod.BackColor = Color.Transparent;
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Ingreso menu = new Ingreso();
            menu.Show();
            this.Close();
        }

        private void rb_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Eliminar.Checked) 
            {
                lbl_nombre.Text = "Teléfono celular:";
                lbl_TelEmp.Visible = false;
                lbl_nombre.Visible = true;
                lbl_email.Visible = false;
                lbl_apellido.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                tb_nombre.Visible = true;
                tb_apellido.Visible = false;
                tb_direccion.Visible = false;
                tb_email.Visible = false;
                tb_Empresa.Visible = false;
                tb_TelEmp.Visible = false;
                tb_TelCel.Visible = false;
            }
            else
            {
                lbl_email.Text = "Email:";
                lbl_nombre.Text = "Nombre:";
                lbl_TelEmp.Text = "Teléfono de empresa:";
                lbl_email.Visible = true;
                lbl_apellido.Visible = true;
                lbl_TelEmp.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                tb_nombre.Visible = true;
                tb_apellido.Visible = true;
                tb_direccion.Visible = true;
                tb_email.Visible = true;
                tb_Empresa.Visible = true;
                tb_TelCel.Visible = true;
                tb_TelEmp.Visible = true;
                tb_nombre.Text = "";
            }
        }

        private void Modificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Modificar.Checked)
            {
                lbl_nombre.Visible = false;
                lbl_email.Visible = false;
                lbl_apellido.Visible = false;
                lbl_TelEmp.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                tb_nombre.Visible = false;
                tb_apellido.Visible = false;
                tb_direccion.Visible = false;
                tb_email.Visible = false;
                tb_Empresa.Visible = false;
                tb_TelCel.Visible = false;
                tb_TelEmp.Visible = false;
                gb_ModDato.Visible = true;
                lbl_Indication.Text = "Escoge el dato que quieres modificar -->\n OJO necesita el teléfono celular para saber \n cual contacto va a cambiar";
            }
            else
            {
                lbl_email.Text = "Email:";
                lbl_nombre.Text = "Nombre:";
                lbl_TelEmp.Text = "Teléfono de empresa:";
                lbl_nombre.Visible = true;
                lbl_email.Visible = true;
                lbl_apellido.Visible = true;
                lbl_TelEmp.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                tb_nombre.Visible = true;
                tb_apellido.Visible = true;
                tb_direccion.Visible = true;
                tb_email.Visible = true;
                tb_Empresa.Visible = true;
                tb_TelCel.Visible = true;
                tb_TelEmp.Visible = true;
                gb_ModDato.Visible = false;
                lbl_Indication.Text = "";
            }
            
        }

        private void rb_TelEmp_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_TelEmp.Checked)
            {
                lbl_nombre.Text = "Teléfono de celular:"; lbl_TelEmp.Text = "Teléfono de empresa nuevo:";
                lbl_nombre.Visible = true; lbl_TelEmp.Visible = true; tb_nombre.Visible = true; tb_TelEmp.Visible = true;
                lbl_email.Visible = true; lbl_email.Text = "Ingrese el nuevo valor";
                lbl_Indication.Text = "";
            }
            else { tb_nombre.Text = ""; tb_TelEmp.Text = ""; }
        }

        private void rb_usuario_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_usuario.Checked)
            {
                lbl_nombre.Text = "Teléfono de celular:"; lbl_TelEmp.Text = "Usuario nuevo:";
                lbl_nombre.Visible = true; lbl_TelEmp.Visible = true; tb_nombre.Visible = true; tb_TelEmp.Visible = true;
                lbl_email.Visible = true; lbl_email.Text = "Ingrese el nuevo valor";
                lbl_Indication.Text = "";
            }
            else { tb_nombre.Text = ""; tb_TelEmp.Text = ""; }
        }

        private void rb_nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nombre.Checked)
            {
                lbl_nombre.Text = "Teléfono de celular:"; lbl_TelEmp.Text = "Nombre nuevo:";
                lbl_nombre.Visible = true; lbl_TelEmp.Visible = true; tb_nombre.Visible = true; tb_TelEmp.Visible = true;
                lbl_email.Visible = true; lbl_email.Text = "Ingrese el nuevo valor";
                lbl_Indication.Text = "";
            }
            else { tb_nombre.Text = ""; tb_TelEmp.Text = ""; }
        }

        private void rb_apellido_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_apellido.Checked)
            {
                lbl_nombre.Text = "Teléfono de celular:"; lbl_TelEmp.Text = "Apellido nuevo:";
                lbl_nombre.Visible = true; lbl_TelEmp.Visible = true; tb_nombre.Visible = true; tb_TelEmp.Visible = true;
                lbl_email.Visible = true; lbl_email.Text = "Ingrese el nuevo valor";
                lbl_Indication.Text = "";
            }
            else { tb_nombre.Text = ""; tb_TelEmp.Text = ""; }
        }

        private void rb_email_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_email.Checked)
            {
                lbl_nombre.Text = "Teléfono de celular:"; lbl_TelEmp.Text = "Email nuevo:";
                lbl_nombre.Visible = true; lbl_TelEmp.Visible = true; tb_nombre.Visible = true; tb_TelEmp.Visible = true;
                lbl_email.Visible = true; lbl_email.Text = "Ingrese el nuevo valor";
                lbl_Indication.Text = "";
            }
            else { tb_nombre.Text = ""; tb_TelEmp.Text = ""; }
        }

        private void rb_empresa_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_empresa.Checked)
            {
                lbl_nombre.Text = "Teléfono de celular:"; lbl_TelEmp.Text = "Empresa nuevo:";
                lbl_nombre.Visible = true; lbl_TelEmp.Visible = true; tb_nombre.Visible = true; tb_TelEmp.Visible = true;
                lbl_email.Visible = true; lbl_email.Text = "Ingrese el nuevo valor";
                lbl_Indication.Text = "";
            }
            else { tb_nombre.Text = ""; tb_TelEmp.Text = ""; }
        }

        private void rb_direccion_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_direccion.Checked)
            {
                lbl_nombre.Text = "Teléfono de celular:"; lbl_TelEmp.Text = "Dirección nuevo:";
                lbl_nombre.Visible = true; lbl_TelEmp.Visible = true; tb_nombre.Visible = true; tb_TelEmp.Visible = true;
                lbl_email.Visible = true; lbl_email.Text = "Ingrese el nuevo valor";
                lbl_Indication.Text = "";
            }
            else { tb_nombre.Text = ""; tb_TelEmp.Text = ""; }
        }

        private void rb_TelCel_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_TelCel.Checked)
            {
                lbl_nombre.Text = "Teléfono de celular:"; lbl_TelEmp.Text = "Teléfono celular nuevo:";
                lbl_nombre.Visible = true; lbl_TelEmp.Visible = true; tb_nombre.Visible = true; tb_TelEmp.Visible = true;
                lbl_email.Visible = true; lbl_email.Text = "Ingrese el nuevo valor";
                lbl_Indication.Text = "";
            }
            else { tb_nombre.Text = ""; tb_TelEmp.Text = ""; }
        }

        private void rb_Ingresar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Ingresar.Checked) 
            {
                lbl_avisos.Text = "No pueden quedar espacios vacíos porfavor si es un número de teléfono coloque < 0 > y si es otro dato < - >";
                tb_nombre.Text = ""; tb_TelEmp.Text = "";
                tb_apellido.Text = ""; tb_email.Text = "";
                tb_direccion.Text = ""; tb_Empresa.Text = "";
                tb_TelCel.Text = "";
            }
            else
            {
                lbl_avisos.Text = "";
            }
        }
    }
}
