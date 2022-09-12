
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
  -------------------     Proyecto de facturación de compras                                                                                  ---------------------
  -------------------     Autor : Jonathan Salazar Rodríguez                                                                                  ---------------------
  -------------------                                                                                                                         ---------------------
  -------------------                                                                                   Última modificación : 3/12/2020       ---------------------
  -------------------                                                                                                                         ---------------------
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

using System;
using System.Data;
using System.Windows.Forms;

namespace Factura
{
    public partial class Form1 : Form
    {
        Coneccion dato = new Coneccion();
        private uint i = 0;
        public Form1()
        {
            InitializeComponent();
            ActTable();
            ActTable2();
        }
        private void ActTable()
        {
            DataTable dataTbl = dato.SeeProduct();
            dataGridView1.DataSource = dataTbl;
        }
        private void ActTable2()
        {
            DataTable DetalleTable = dato.SeeDetalle();
            dataGridView2.DataSource = DetalleTable;
        }

        private void btn_opciones_Click(object sender, EventArgs e)
        {
            if(gb_opciones.Visible)   gb_opciones.Visible = false;
            else      gb_opciones.Visible = true;
        }

        private void rb_IngUsu_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_IngUsu.Checked) 
            { gb_barra.Visible = true; lbl_Producto.Text = "Nombre Cliente:"; lbl_Cantidad.Visible = false; tb_cant.Visible = false; } 
        }
        
        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            if (rb_IngUsu.Checked) { dato.SetContacto(long.Parse(tb_Cliente.Text.ToString()),tb_Prod.Text); MessageBox.Show("Ingresado con exito"); }
            else if (rb_Proforma.Checked) 
            {
                if(i == 0 )
                {
                    dato.SetDetalle(dato.SeeIdDeta()+1, Convert.ToInt32(tb_cant.Text.ToString()), long.Parse(tb_Prod.Text.ToString()), long.Parse(tb_Cliente.Text.ToString()), dato.SetPRecTotal(long.Parse(tb_Prod.Text.ToString()), Convert.ToInt32(tb_cant.Text.ToString())));
                    i++;
                }
                else
                {
                    dato.SetDetalle(dato.SeeIdDeta(), Convert.ToInt32(tb_cant.Text.ToString()), long.Parse(tb_Prod.Text.ToString()), long.Parse(tb_Cliente.Text.ToString()), dato.SetPRecTotal(long.Parse(tb_Prod.Text.ToString()), Convert.ToInt32(tb_cant.Text.ToString())));
                }

            }
            else if (rb_Compra.Checked) { i = 0; dato.SetFac(dato.SeeIdFac()+1, dato.SeeIdDeta()); }
            ActTable();
            ActTable2();
        }

        private void rb_Proforma_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Proforma.Checked) { gb_barra.Visible = true; lbl_Producto.Text = "Id Producto:"; tb_cant.Visible = true; tb_Cliente.Visible = true; tb_Prod.Visible = true; lbl_Cantidad.Visible = true; lbl_Cliente.Visible = true; lbl_Producto.Visible = true; }
        }

        private void rb_Compra_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Compra.Checked) { gb_barra.Visible = true; lbl_Producto.Text = "Id Producto:"; tb_cant.Visible = true; tb_Cliente.Visible = true; tb_Prod.Visible = true; lbl_Cantidad.Visible = true; lbl_Cliente.Visible = true; lbl_Producto.Visible = true; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
