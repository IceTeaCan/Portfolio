namespace Factura
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Factura.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_opciones = new System.Windows.Forms.Button();
            this.gb_opciones = new System.Windows.Forms.GroupBox();
            this.rb_Compra = new System.Windows.Forms.RadioButton();
            this.rb_Proforma = new System.Windows.Forms.RadioButton();
            this.rb_IngUsu = new System.Windows.Forms.RadioButton();
            this.gb_barra = new System.Windows.Forms.GroupBox();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.tb_cant = new System.Windows.Forms.TextBox();
            this.tb_Prod = new System.Windows.Forms.TextBox();
            this.tb_Cliente = new System.Windows.Forms.TextBox();
            this.lbl_out = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new Factura.DataSet1TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_opciones.SuspendLayout();
            this.gb_barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(891, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(358, 333);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.Size = new System.Drawing.Size(545, 256);
            this.dataGridView2.TabIndex = 1;
            // 
            // btn_opciones
            // 
            this.btn_opciones.ForeColor = System.Drawing.Color.Black;
            this.btn_opciones.Location = new System.Drawing.Point(834, 182);
            this.btn_opciones.Name = "btn_opciones";
            this.btn_opciones.Size = new System.Drawing.Size(69, 23);
            this.btn_opciones.TabIndex = 2;
            this.btn_opciones.Text = "Opciones";
            this.btn_opciones.UseVisualStyleBackColor = true;
            this.btn_opciones.Click += new System.EventHandler(this.btn_opciones_Click);
            // 
            // gb_opciones
            // 
            this.gb_opciones.Controls.Add(this.rb_Compra);
            this.gb_opciones.Controls.Add(this.rb_Proforma);
            this.gb_opciones.Controls.Add(this.rb_IngUsu);
            this.gb_opciones.ForeColor = System.Drawing.Color.White;
            this.gb_opciones.Location = new System.Drawing.Point(702, 182);
            this.gb_opciones.Name = "gb_opciones";
            this.gb_opciones.Size = new System.Drawing.Size(126, 124);
            this.gb_opciones.TabIndex = 3;
            this.gb_opciones.TabStop = false;
            this.gb_opciones.Text = "Opciones";
            this.gb_opciones.Visible = false;
            // 
            // rb_Compra
            // 
            this.rb_Compra.AutoSize = true;
            this.rb_Compra.Location = new System.Drawing.Point(6, 61);
            this.rb_Compra.Name = "rb_Compra";
            this.rb_Compra.Size = new System.Drawing.Size(103, 17);
            this.rb_Compra.TabIndex = 2;
            this.rb_Compra.TabStop = true;
            this.rb_Compra.Text = "Ejecutar Compra";
            this.rb_Compra.UseVisualStyleBackColor = true;
            this.rb_Compra.CheckedChanged += new System.EventHandler(this.rb_Compra_CheckedChanged);
            // 
            // rb_Proforma
            // 
            this.rb_Proforma.AutoSize = true;
            this.rb_Proforma.Location = new System.Drawing.Point(6, 38);
            this.rb_Proforma.Name = "rb_Proforma";
            this.rb_Proforma.Size = new System.Drawing.Size(67, 17);
            this.rb_Proforma.TabIndex = 1;
            this.rb_Proforma.TabStop = true;
            this.rb_Proforma.Text = "Proforma";
            this.rb_Proforma.UseVisualStyleBackColor = true;
            this.rb_Proforma.CheckedChanged += new System.EventHandler(this.rb_Proforma_CheckedChanged);
            // 
            // rb_IngUsu
            // 
            this.rb_IngUsu.AutoSize = true;
            this.rb_IngUsu.Location = new System.Drawing.Point(6, 15);
            this.rb_IngUsu.Name = "rb_IngUsu";
            this.rb_IngUsu.Size = new System.Drawing.Size(112, 17);
            this.rb_IngUsu.TabIndex = 0;
            this.rb_IngUsu.TabStop = true;
            this.rb_IngUsu.Text = "Ingreso de usuario";
            this.rb_IngUsu.UseVisualStyleBackColor = true;
            this.rb_IngUsu.CheckedChanged += new System.EventHandler(this.rb_IngUsu_CheckedChanged);
            // 
            // gb_barra
            // 
            this.gb_barra.Controls.Add(this.btn_Ejecutar);
            this.gb_barra.Controls.Add(this.lbl_Cantidad);
            this.gb_barra.Controls.Add(this.lbl_Producto);
            this.gb_barra.Controls.Add(this.lbl_Cliente);
            this.gb_barra.Controls.Add(this.tb_cant);
            this.gb_barra.Controls.Add(this.tb_Prod);
            this.gb_barra.Controls.Add(this.tb_Cliente);
            this.gb_barra.ForeColor = System.Drawing.Color.White;
            this.gb_barra.Location = new System.Drawing.Point(12, 182);
            this.gb_barra.Name = "gb_barra";
            this.gb_barra.Size = new System.Drawing.Size(684, 135);
            this.gb_barra.TabIndex = 4;
            this.gb_barra.TabStop = false;
            this.gb_barra.Text = "Barra de Ejecución";
            this.gb_barra.Visible = false;
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.ForeColor = System.Drawing.Color.Black;
            this.btn_Ejecutar.Location = new System.Drawing.Point(597, 105);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ejecutar.TabIndex = 8;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(388, 17);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(52, 13);
            this.lbl_Cantidad.TabIndex = 6;
            this.lbl_Cantidad.Text = "Cantidad:";
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(196, 19);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(80, 13);
            this.lbl_Producto.TabIndex = 5;
            this.lbl_Producto.Text = "Id de Producto:";
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(16, 17);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(78, 13);
            this.lbl_Cliente.TabIndex = 4;
            this.lbl_Cliente.Text = "Cedula Cliente:";
            // 
            // tb_cant
            // 
            this.tb_cant.Location = new System.Drawing.Point(364, 38);
            this.tb_cant.Name = "tb_cant";
            this.tb_cant.Size = new System.Drawing.Size(100, 20);
            this.tb_cant.TabIndex = 2;
            // 
            // tb_Prod
            // 
            this.tb_Prod.Location = new System.Drawing.Point(187, 38);
            this.tb_Prod.Name = "tb_Prod";
            this.tb_Prod.Size = new System.Drawing.Size(100, 20);
            this.tb_Prod.TabIndex = 1;
            // 
            // tb_Cliente
            // 
            this.tb_Cliente.Location = new System.Drawing.Point(6, 38);
            this.tb_Cliente.Name = "tb_Cliente";
            this.tb_Cliente.Size = new System.Drawing.Size(100, 20);
            this.tb_Cliente.TabIndex = 0;
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.ForeColor = System.Drawing.Color.White;
            this.lbl_out.Location = new System.Drawing.Point(83, 524);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(0, 13);
            this.lbl_out.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 63;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Factura.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 333);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(340, 256);
            this.reportViewer1.TabIndex = 6;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(915, 601);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.gb_barra);
            this.Controls.Add(this.gb_opciones);
            this.Controls.Add(this.btn_opciones);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_opciones.ResumeLayout(false);
            this.gb_opciones.PerformLayout();
            this.gb_barra.ResumeLayout(false);
            this.gb_barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_opciones;
        private System.Windows.Forms.GroupBox gb_opciones;
        private System.Windows.Forms.RadioButton rb_Compra;
        private System.Windows.Forms.RadioButton rb_Proforma;
        private System.Windows.Forms.RadioButton rb_IngUsu;
        private System.Windows.Forms.GroupBox gb_barra;
        private System.Windows.Forms.TextBox tb_cant;
        private System.Windows.Forms.TextBox tb_Prod;
        private System.Windows.Forms.TextBox tb_Cliente;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_out;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}

