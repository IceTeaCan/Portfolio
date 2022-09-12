namespace StorageAndManagementAgenda
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_TelEmp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_Empresa = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_TelCel = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_TelEmp = new System.Windows.Forms.TextBox();
            this.btn_Action = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_lightMode = new System.Windows.Forms.Button();
            this.option_btn = new System.Windows.Forms.Button();
            this.gb_Mod = new System.Windows.Forms.GroupBox();
            this.gb_ModDato = new System.Windows.Forms.GroupBox();
            this.rb_usuario = new System.Windows.Forms.RadioButton();
            this.rb_empresa = new System.Windows.Forms.RadioButton();
            this.rb_direccion = new System.Windows.Forms.RadioButton();
            this.rb_TelEmp = new System.Windows.Forms.RadioButton();
            this.rb_TelCel = new System.Windows.Forms.RadioButton();
            this.rb_apellido = new System.Windows.Forms.RadioButton();
            this.rb_nombre = new System.Windows.Forms.RadioButton();
            this.rb_email = new System.Windows.Forms.RadioButton();
            this.lbl_Indication = new System.Windows.Forms.Label();
            this.rb_Ingresar = new System.Windows.Forms.RadioButton();
            this.rb_Modificar = new System.Windows.Forms.RadioButton();
            this.rb_Eliminar = new System.Windows.Forms.RadioButton();
            this.lbl_avisos = new System.Windows.Forms.Label();
            this.gb_Options = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cb_Image = new System.Windows.Forms.CheckBox();
            this.cb_ElimCont = new System.Windows.Forms.CheckBox();
            this.cb_ShowBD = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Mod.SuspendLayout();
            this.gb_ModDato.SuspendLayout();
            this.gb_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_nombre.Location = new System.Drawing.Point(15, 23);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(67, 19);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_email.Location = new System.Drawing.Point(132, 82);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 19);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_apellido.Location = new System.Drawing.Point(132, 23);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(64, 19);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_TelEmp
            // 
            this.lbl_TelEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TelEmp.AutoSize = true;
            this.lbl_TelEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_TelEmp.Location = new System.Drawing.Point(237, 23);
            this.lbl_TelEmp.Name = "lbl_TelEmp";
            this.lbl_TelEmp.Size = new System.Drawing.Size(135, 19);
            this.lbl_TelEmp.TabIndex = 3;
            this.lbl_TelEmp.Text = "Teléfono de empresa:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(309, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono celular:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(376, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(15, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Empresa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 233);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // tb_apellido
            // 
            this.tb_apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_apellido.Location = new System.Drawing.Point(135, 49);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(100, 27);
            this.tb_apellido.TabIndex = 10;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_nombre.Location = new System.Drawing.Point(15, 49);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 27);
            this.tb_nombre.TabIndex = 11;
            // 
            // tb_Empresa
            // 
            this.tb_Empresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Empresa.Location = new System.Drawing.Point(15, 108);
            this.tb_Empresa.Name = "tb_Empresa";
            this.tb_Empresa.Size = new System.Drawing.Size(100, 27);
            this.tb_Empresa.TabIndex = 12;
            // 
            // tb_email
            // 
            this.tb_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_email.Location = new System.Drawing.Point(135, 108);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(143, 27);
            this.tb_email.TabIndex = 13;
            // 
            // tb_TelCel
            // 
            this.tb_TelCel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_TelCel.Location = new System.Drawing.Point(313, 108);
            this.tb_TelCel.Name = "tb_TelCel";
            this.tb_TelCel.Size = new System.Drawing.Size(100, 27);
            this.tb_TelCel.TabIndex = 14;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_direccion.Location = new System.Drawing.Point(370, 49);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(100, 27);
            this.tb_direccion.TabIndex = 15;
            // 
            // tb_TelEmp
            // 
            this.tb_TelEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_TelEmp.Location = new System.Drawing.Point(250, 49);
            this.tb_TelEmp.Name = "tb_TelEmp";
            this.tb_TelEmp.Size = new System.Drawing.Size(100, 27);
            this.tb_TelEmp.TabIndex = 16;
            // 
            // btn_Action
            // 
            this.btn_Action.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Action.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Action.Font = new System.Drawing.Font("Vivaldi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Action.ForeColor = System.Drawing.Color.Black;
            this.btn_Action.Location = new System.Drawing.Point(693, 93);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(77, 39);
            this.btn_Action.TabIndex = 17;
            this.btn_Action.Text = "Aceptar";
            this.btn_Action.UseVisualStyleBackColor = false;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 18;
            // 
            // btn_lightMode
            // 
            this.btn_lightMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lightMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_lightMode.BackgroundImage")));
            this.btn_lightMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_lightMode.Enabled = false;
            this.btn_lightMode.Location = new System.Drawing.Point(755, 51);
            this.btn_lightMode.Name = "btn_lightMode";
            this.btn_lightMode.Size = new System.Drawing.Size(33, 33);
            this.btn_lightMode.TabIndex = 8;
            this.btn_lightMode.UseVisualStyleBackColor = true;
            this.btn_lightMode.Click += new System.EventHandler(this.btn_lightMode_Click);
            // 
            // option_btn
            // 
            this.option_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.option_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option_btn.BackgroundImage")));
            this.option_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.option_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.option_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.option_btn.Location = new System.Drawing.Point(754, 12);
            this.option_btn.Name = "option_btn";
            this.option_btn.Size = new System.Drawing.Size(34, 33);
            this.option_btn.TabIndex = 7;
            this.option_btn.UseVisualStyleBackColor = true;
            this.option_btn.Click += new System.EventHandler(this.option_btn_Click);
            // 
            // gb_Mod
            // 
            this.gb_Mod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Mod.BackColor = System.Drawing.Color.Transparent;
            this.gb_Mod.Controls.Add(this.gb_ModDato);
            this.gb_Mod.Controls.Add(this.lbl_Indication);
            this.gb_Mod.Controls.Add(this.rb_Ingresar);
            this.gb_Mod.Controls.Add(this.rb_Modificar);
            this.gb_Mod.Controls.Add(this.rb_Eliminar);
            this.gb_Mod.Controls.Add(this.tb_apellido);
            this.gb_Mod.Controls.Add(this.lbl_nombre);
            this.gb_Mod.Controls.Add(this.btn_Action);
            this.gb_Mod.Controls.Add(this.lbl_email);
            this.gb_Mod.Controls.Add(this.tb_TelEmp);
            this.gb_Mod.Controls.Add(this.lbl_apellido);
            this.gb_Mod.Controls.Add(this.tb_direccion);
            this.gb_Mod.Controls.Add(this.lbl_TelEmp);
            this.gb_Mod.Controls.Add(this.tb_TelCel);
            this.gb_Mod.Controls.Add(this.label5);
            this.gb_Mod.Controls.Add(this.tb_email);
            this.gb_Mod.Controls.Add(this.label6);
            this.gb_Mod.Controls.Add(this.tb_Empresa);
            this.gb_Mod.Controls.Add(this.label7);
            this.gb_Mod.Controls.Add(this.tb_nombre);
            this.gb_Mod.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Mod.ForeColor = System.Drawing.Color.White;
            this.gb_Mod.Location = new System.Drawing.Point(12, 303);
            this.gb_Mod.Name = "gb_Mod";
            this.gb_Mod.Size = new System.Drawing.Size(776, 144);
            this.gb_Mod.TabIndex = 19;
            this.gb_Mod.TabStop = false;
            this.gb_Mod.Text = "Modificación";
            this.gb_Mod.Visible = false;
            // 
            // gb_ModDato
            // 
            this.gb_ModDato.Controls.Add(this.rb_usuario);
            this.gb_ModDato.Controls.Add(this.rb_empresa);
            this.gb_ModDato.Controls.Add(this.rb_direccion);
            this.gb_ModDato.Controls.Add(this.rb_TelEmp);
            this.gb_ModDato.Controls.Add(this.rb_TelCel);
            this.gb_ModDato.Controls.Add(this.rb_apellido);
            this.gb_ModDato.Controls.Add(this.rb_nombre);
            this.gb_ModDato.Controls.Add(this.rb_email);
            this.gb_ModDato.ForeColor = System.Drawing.Color.White;
            this.gb_ModDato.Location = new System.Drawing.Point(454, 32);
            this.gb_ModDato.Name = "gb_ModDato";
            this.gb_ModDato.Size = new System.Drawing.Size(218, 106);
            this.gb_ModDato.TabIndex = 22;
            this.gb_ModDato.TabStop = false;
            this.gb_ModDato.Text = "Dato a modificar";
            this.gb_ModDato.Visible = false;
            // 
            // rb_usuario
            // 
            this.rb_usuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_usuario.AutoSize = true;
            this.rb_usuario.Location = new System.Drawing.Point(6, 15);
            this.rb_usuario.Name = "rb_usuario";
            this.rb_usuario.Size = new System.Drawing.Size(82, 23);
            this.rb_usuario.TabIndex = 26;
            this.rb_usuario.TabStop = true;
            this.rb_usuario.Text = "Usuario";
            this.rb_usuario.UseVisualStyleBackColor = true;
            this.rb_usuario.CheckedChanged += new System.EventHandler(this.rb_usuario_CheckedChanged);
            // 
            // rb_empresa
            // 
            this.rb_empresa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_empresa.AutoSize = true;
            this.rb_empresa.Location = new System.Drawing.Point(120, 15);
            this.rb_empresa.Name = "rb_empresa";
            this.rb_empresa.Size = new System.Drawing.Size(85, 23);
            this.rb_empresa.TabIndex = 25;
            this.rb_empresa.TabStop = true;
            this.rb_empresa.Text = "Empresa";
            this.rb_empresa.UseVisualStyleBackColor = true;
            this.rb_empresa.CheckedChanged += new System.EventHandler(this.rb_empresa_CheckedChanged);
            // 
            // rb_direccion
            // 
            this.rb_direccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_direccion.AutoSize = true;
            this.rb_direccion.Location = new System.Drawing.Point(118, 36);
            this.rb_direccion.Name = "rb_direccion";
            this.rb_direccion.Size = new System.Drawing.Size(90, 23);
            this.rb_direccion.TabIndex = 24;
            this.rb_direccion.TabStop = true;
            this.rb_direccion.Text = "Dirección";
            this.rb_direccion.UseVisualStyleBackColor = true;
            this.rb_direccion.CheckedChanged += new System.EventHandler(this.rb_direccion_CheckedChanged);
            // 
            // rb_TelEmp
            // 
            this.rb_TelEmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_TelEmp.AutoSize = true;
            this.rb_TelEmp.Location = new System.Drawing.Point(96, 76);
            this.rb_TelEmp.Name = "rb_TelEmp";
            this.rb_TelEmp.Size = new System.Drawing.Size(114, 23);
            this.rb_TelEmp.TabIndex = 23;
            this.rb_TelEmp.TabStop = true;
            this.rb_TelEmp.Text = "Tel.Empresa";
            this.rb_TelEmp.UseVisualStyleBackColor = true;
            this.rb_TelEmp.CheckedChanged += new System.EventHandler(this.rb_TelEmp_CheckedChanged);
            // 
            // rb_TelCel
            // 
            this.rb_TelCel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_TelCel.AutoSize = true;
            this.rb_TelCel.Location = new System.Drawing.Point(96, 58);
            this.rb_TelCel.Name = "rb_TelCel";
            this.rb_TelCel.Size = new System.Drawing.Size(102, 23);
            this.rb_TelCel.TabIndex = 22;
            this.rb_TelCel.TabStop = true;
            this.rb_TelCel.Text = "Tel.Celular";
            this.rb_TelCel.UseVisualStyleBackColor = true;
            this.rb_TelCel.CheckedChanged += new System.EventHandler(this.rb_TelCel_CheckedChanged);
            // 
            // rb_apellido
            // 
            this.rb_apellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_apellido.AutoSize = true;
            this.rb_apellido.Location = new System.Drawing.Point(6, 55);
            this.rb_apellido.Name = "rb_apellido";
            this.rb_apellido.Size = new System.Drawing.Size(78, 23);
            this.rb_apellido.TabIndex = 21;
            this.rb_apellido.TabStop = true;
            this.rb_apellido.Text = "Apellido";
            this.rb_apellido.UseVisualStyleBackColor = true;
            this.rb_apellido.CheckedChanged += new System.EventHandler(this.rb_apellido_CheckedChanged);
            // 
            // rb_nombre
            // 
            this.rb_nombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_nombre.AutoSize = true;
            this.rb_nombre.Location = new System.Drawing.Point(6, 36);
            this.rb_nombre.Name = "rb_nombre";
            this.rb_nombre.Size = new System.Drawing.Size(81, 23);
            this.rb_nombre.TabIndex = 20;
            this.rb_nombre.TabStop = true;
            this.rb_nombre.Text = "Nombre";
            this.rb_nombre.UseVisualStyleBackColor = true;
            this.rb_nombre.CheckedChanged += new System.EventHandler(this.rb_nombre_CheckedChanged);
            // 
            // rb_email
            // 
            this.rb_email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_email.AutoSize = true;
            this.rb_email.Location = new System.Drawing.Point(6, 76);
            this.rb_email.Name = "rb_email";
            this.rb_email.Size = new System.Drawing.Size(71, 23);
            this.rb_email.TabIndex = 19;
            this.rb_email.TabStop = true;
            this.rb_email.Text = "Email";
            this.rb_email.UseVisualStyleBackColor = true;
            this.rb_email.CheckedChanged += new System.EventHandler(this.rb_email_CheckedChanged);
            // 
            // lbl_Indication
            // 
            this.lbl_Indication.AutoSize = true;
            this.lbl_Indication.Font = new System.Drawing.Font("Vivaldi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Indication.Location = new System.Drawing.Point(9, 41);
            this.lbl_Indication.Name = "lbl_Indication";
            this.lbl_Indication.Size = new System.Drawing.Size(0, 25);
            this.lbl_Indication.TabIndex = 21;
            // 
            // rb_Ingresar
            // 
            this.rb_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_Ingresar.AutoSize = true;
            this.rb_Ingresar.Location = new System.Drawing.Point(678, 63);
            this.rb_Ingresar.Name = "rb_Ingresar";
            this.rb_Ingresar.Size = new System.Drawing.Size(85, 23);
            this.rb_Ingresar.TabIndex = 20;
            this.rb_Ingresar.TabStop = true;
            this.rb_Ingresar.Text = "Ingresar";
            this.rb_Ingresar.UseVisualStyleBackColor = true;
            this.rb_Ingresar.CheckedChanged += new System.EventHandler(this.rb_Ingresar_CheckedChanged);
            // 
            // rb_Modificar
            // 
            this.rb_Modificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_Modificar.AutoSize = true;
            this.rb_Modificar.Location = new System.Drawing.Point(677, 40);
            this.rb_Modificar.Name = "rb_Modificar";
            this.rb_Modificar.Size = new System.Drawing.Size(93, 23);
            this.rb_Modificar.TabIndex = 19;
            this.rb_Modificar.TabStop = true;
            this.rb_Modificar.Text = "Modificar";
            this.rb_Modificar.UseVisualStyleBackColor = true;
            this.rb_Modificar.CheckedChanged += new System.EventHandler(this.Modificar_CheckedChanged);
            // 
            // rb_Eliminar
            // 
            this.rb_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rb_Eliminar.AutoSize = true;
            this.rb_Eliminar.Location = new System.Drawing.Point(678, 16);
            this.rb_Eliminar.Name = "rb_Eliminar";
            this.rb_Eliminar.Size = new System.Drawing.Size(87, 23);
            this.rb_Eliminar.TabIndex = 18;
            this.rb_Eliminar.TabStop = true;
            this.rb_Eliminar.Text = "Eliminar";
            this.rb_Eliminar.UseVisualStyleBackColor = true;
            this.rb_Eliminar.CheckedChanged += new System.EventHandler(this.rb_Eliminar_CheckedChanged);
            // 
            // lbl_avisos
            // 
            this.lbl_avisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_avisos.AutoSize = true;
            this.lbl_avisos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_avisos.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avisos.ForeColor = System.Drawing.Color.White;
            this.lbl_avisos.Location = new System.Drawing.Point(18, 279);
            this.lbl_avisos.Name = "lbl_avisos";
            this.lbl_avisos.Size = new System.Drawing.Size(0, 20);
            this.lbl_avisos.TabIndex = 23;
            // 
            // gb_Options
            // 
            this.gb_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Options.Controls.Add(this.btn_Exit);
            this.gb_Options.Controls.Add(this.cb_Image);
            this.gb_Options.Controls.Add(this.cb_ElimCont);
            this.gb_Options.Controls.Add(this.cb_ShowBD);
            this.gb_Options.ForeColor = System.Drawing.Color.White;
            this.gb_Options.Location = new System.Drawing.Point(590, 14);
            this.gb_Options.Name = "gb_Options";
            this.gb_Options.Size = new System.Drawing.Size(158, 116);
            this.gb_Options.TabIndex = 24;
            this.gb_Options.TabStop = false;
            this.gb_Options.Text = "Options";
            this.gb_Options.Visible = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(98, 84);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(54, 26);
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cb_Image
            // 
            this.cb_Image.AutoSize = true;
            this.cb_Image.Location = new System.Drawing.Point(6, 53);
            this.cb_Image.Name = "cb_Image";
            this.cb_Image.Size = new System.Drawing.Size(136, 17);
            this.cb_Image.TabIndex = 27;
            this.cb_Image.Text = "Quitar imagen de fondo";
            this.cb_Image.UseVisualStyleBackColor = true;
            this.cb_Image.CheckedChanged += new System.EventHandler(this.cb_Image_CheckedChanged);
            // 
            // cb_ElimCont
            // 
            this.cb_ElimCont.AutoSize = true;
            this.cb_ElimCont.Location = new System.Drawing.Point(6, 37);
            this.cb_ElimCont.Name = "cb_ElimCont";
            this.cb_ElimCont.Size = new System.Drawing.Size(114, 17);
            this.cb_ElimCont.TabIndex = 26;
            this.cb_ElimCont.Text = "Modificar contacto";
            this.cb_ElimCont.UseVisualStyleBackColor = true;
            this.cb_ElimCont.CheckedChanged += new System.EventHandler(this.cb_ElimCont_CheckedChanged);
            // 
            // cb_ShowBD
            // 
            this.cb_ShowBD.AutoSize = true;
            this.cb_ShowBD.Location = new System.Drawing.Point(6, 19);
            this.cb_ShowBD.Name = "cb_ShowBD";
            this.cb_ShowBD.Size = new System.Drawing.Size(147, 17);
            this.cb_ShowBD.TabIndex = 25;
            this.cb_ShowBD.Text = "Mostrar lista de contactos";
            this.cb_ShowBD.UseVisualStyleBackColor = true;
            this.cb_ShowBD.CheckedChanged += new System.EventHandler(this.cb_ShowBD_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_avisos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_Options);
            this.Controls.Add(this.gb_Mod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_lightMode);
            this.Controls.Add(this.option_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.Text = "Enterprice menú";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Mod.ResumeLayout(false);
            this.gb_Mod.PerformLayout();
            this.gb_ModDato.ResumeLayout(false);
            this.gb_ModDato.PerformLayout();
            this.gb_Options.ResumeLayout(false);
            this.gb_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_TelEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button option_btn;
        private System.Windows.Forms.Button btn_lightMode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_Empresa;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_TelCel;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.TextBox tb_TelEmp;
        private System.Windows.Forms.Button btn_Action;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb_Mod;
        private System.Windows.Forms.GroupBox gb_Options;
        private System.Windows.Forms.CheckBox cb_ElimCont;
        private System.Windows.Forms.CheckBox cb_ShowBD;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.CheckBox cb_Image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_Ingresar;
        private System.Windows.Forms.RadioButton rb_Modificar;
        private System.Windows.Forms.RadioButton rb_Eliminar;
        private System.Windows.Forms.GroupBox gb_ModDato;
        private System.Windows.Forms.RadioButton rb_empresa;
        private System.Windows.Forms.RadioButton rb_direccion;
        private System.Windows.Forms.RadioButton rb_TelEmp;
        private System.Windows.Forms.RadioButton rb_TelCel;
        private System.Windows.Forms.RadioButton rb_apellido;
        private System.Windows.Forms.RadioButton rb_nombre;
        private System.Windows.Forms.RadioButton rb_email;
        private System.Windows.Forms.Label lbl_Indication;
        private System.Windows.Forms.RadioButton rb_usuario;
        private System.Windows.Forms.Label lbl_avisos;
    }
}

