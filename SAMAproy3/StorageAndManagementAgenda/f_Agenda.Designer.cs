namespace StorageAndManagementAgenda
{
    partial class f_Agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_atras = new System.Windows.Forms.Button();
            this.data_Agenda = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoPeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet1 = new StorageAndManagementAgenda.AgendaDataSet1();
            this.contactoPeTableAdapter = new StorageAndManagementAgenda.AgendaDataSet1TableAdapters.ContactoPeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoPeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.Ivory;
            this.btn_atras.Location = new System.Drawing.Point(636, 293);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(119, 23);
            this.btn_atras.TabIndex = 33;
            this.btn_atras.Text = "ATRAS";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // data_Agenda
            // 
            this.data_Agenda.AutoGenerateColumns = false;
            this.data_Agenda.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.data_Agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Agenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoCelularDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.apodoDataGridViewTextBoxColumn});
            this.data_Agenda.DataSource = this.contactoPeBindingSource;
            this.data_Agenda.Location = new System.Drawing.Point(14, 26);
            this.data_Agenda.Name = "data_Agenda";
            this.data_Agenda.Size = new System.Drawing.Size(741, 261);
            this.data_Agenda.TabIndex = 32;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // telefonoCelularDataGridViewTextBoxColumn
            // 
            this.telefonoCelularDataGridViewTextBoxColumn.DataPropertyName = "Telefono_Celular";
            this.telefonoCelularDataGridViewTextBoxColumn.HeaderText = "Telefono_Celular";
            this.telefonoCelularDataGridViewTextBoxColumn.Name = "telefonoCelularDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // apodoDataGridViewTextBoxColumn
            // 
            this.apodoDataGridViewTextBoxColumn.DataPropertyName = "Apodo";
            this.apodoDataGridViewTextBoxColumn.HeaderText = "Apodo";
            this.apodoDataGridViewTextBoxColumn.Name = "apodoDataGridViewTextBoxColumn";
            // 
            // contactoPeBindingSource
            // 
            this.contactoPeBindingSource.DataMember = "ContactoPe";
            this.contactoPeBindingSource.DataSource = this.agendaDataSet1;
            // 
            // agendaDataSet1
            // 
            this.agendaDataSet1.DataSetName = "AgendaDataSet1";
            this.agendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactoPeTableAdapter
            // 
            this.contactoPeTableAdapter.ClearBeforeFill = true;
            // 
            // f_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(772, 331);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.data_Agenda);
            this.Name = "f_Agenda";
            this.Text = "f_Agenda";
            this.Load += new System.EventHandler(this.f_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoPeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.DataGridView data_Agenda;
        private AgendaDataSet1 agendaDataSet1;
        private System.Windows.Forms.BindingSource contactoPeBindingSource;
        private AgendaDataSet1TableAdapters.ContactoPeTableAdapter contactoPeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodoDataGridViewTextBoxColumn;
    }
}