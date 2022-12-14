namespace ProyGestionDoc_GUI
{
    partial class frmPersona
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpEdadPersona = new System.Windows.Forms.DateTimePicker();
            this.btnAbrirPcb = new FontAwesome.Sharp.IconButton();
            this.pcbImagenPersona = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboNacPersona = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTipoPersona = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGeneroPersona = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroDocPersona = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApePersona = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.cboEstadoPersona = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccPersona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomPersona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoDocPersona = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Foto_per = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nro_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opc_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc_Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc_ide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gen_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialogPersona = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpEdadPersona);
            this.panel1.Controls.Add(this.btnAbrirPcb);
            this.panel1.Controls.Add(this.pcbImagenPersona);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboNacPersona);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cboTipoPersona);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboGeneroPersona);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNroDocPersona);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtApePersona);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.cboEstadoPersona);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDireccPersona);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNomPersona);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTipoDocPersona);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 808);
            this.panel1.TabIndex = 51;
            // 
            // dtpEdadPersona
            // 
            this.dtpEdadPersona.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEdadPersona.Location = new System.Drawing.Point(30, 259);
            this.dtpEdadPersona.Name = "dtpEdadPersona";
            this.dtpEdadPersona.Size = new System.Drawing.Size(230, 23);
            this.dtpEdadPersona.TabIndex = 5;
            // 
            // btnAbrirPcb
            // 
            this.btnAbrirPcb.BackColor = System.Drawing.Color.Gray;
            this.btnAbrirPcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirPcb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAbrirPcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPcb.ForeColor = System.Drawing.Color.White;
            this.btnAbrirPcb.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAbrirPcb.IconColor = System.Drawing.Color.Black;
            this.btnAbrirPcb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrirPcb.Location = new System.Drawing.Point(31, 528);
            this.btnAbrirPcb.Name = "btnAbrirPcb";
            this.btnAbrirPcb.Size = new System.Drawing.Size(229, 23);
            this.btnAbrirPcb.TabIndex = 82;
            this.btnAbrirPcb.Text = "Cargar Imagen";
            this.btnAbrirPcb.UseVisualStyleBackColor = false;
            this.btnAbrirPcb.Click += new System.EventHandler(this.btnAbrirPcb_Click);
            // 
            // pcbImagenPersona
            // 
            this.pcbImagenPersona.Location = new System.Drawing.Point(31, 556);
            this.pcbImagenPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbImagenPersona.Name = "pcbImagenPersona";
            this.pcbImagenPersona.Size = new System.Drawing.Size(228, 130);
            this.pcbImagenPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagenPersona.TabIndex = 80;
            this.pcbImagenPersona.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(30, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 81;
            this.label11.Text = "Imagen";
            // 
            // cboNacPersona
            // 
            this.cboNacPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacPersona.FormattingEnabled = true;
            this.cboNacPersona.Location = new System.Drawing.Point(29, 435);
            this.cboNacPersona.Name = "cboNacPersona";
            this.cboNacPersona.Size = new System.Drawing.Size(229, 23);
            this.cboNacPersona.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 78;
            this.label10.Text = "Nacionalidad";
            // 
            // cboTipoPersona
            // 
            this.cboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPersona.FormattingEnabled = true;
            this.cboTipoPersona.Location = new System.Drawing.Point(29, 390);
            this.cboTipoPersona.Name = "cboTipoPersona";
            this.cboTipoPersona.Size = new System.Drawing.Size(229, 23);
            this.cboTipoPersona.TabIndex = 8;
            this.cboTipoPersona.TextChanged += new System.EventHandler(this.cboTipoPersona_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 76;
            this.label7.Text = "Tipo persona";
            // 
            // cboGeneroPersona
            // 
            this.cboGeneroPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGeneroPersona.FormattingEnabled = true;
            this.cboGeneroPersona.Location = new System.Drawing.Point(30, 347);
            this.cboGeneroPersona.Name = "cboGeneroPersona";
            this.cboGeneroPersona.Size = new System.Drawing.Size(229, 23);
            this.cboGeneroPersona.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 74;
            this.label6.Text = "Genero";
            // 
            // txtNroDocPersona
            // 
            this.txtNroDocPersona.Location = new System.Drawing.Point(30, 128);
            this.txtNroDocPersona.Name = "txtNroDocPersona";
            this.txtNroDocPersona.Size = new System.Drawing.Size(229, 23);
            this.txtNroDocPersona.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 72;
            this.label9.Text = "Nro. documento";
            // 
            // txtApePersona
            // 
            this.txtApePersona.Location = new System.Drawing.Point(31, 218);
            this.txtApePersona.Name = "txtApePersona";
            this.txtApePersona.Size = new System.Drawing.Size(229, 23);
            this.txtApePersona.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(31, 759);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(229, 23);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gold;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(31, 730);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(229, 23);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.Location = new System.Drawing.Point(31, 701);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(229, 23);
            this.btnRegistrar.TabIndex = 68;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboEstadoPersona
            // 
            this.cboEstadoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPersona.FormattingEnabled = true;
            this.cboEstadoPersona.Location = new System.Drawing.Point(31, 479);
            this.cboEstadoPersona.Name = "cboEstadoPersona";
            this.cboEstadoPersona.Size = new System.Drawing.Size(229, 23);
            this.cboEstadoPersona.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Estado";
            // 
            // txtDireccPersona
            // 
            this.txtDireccPersona.Location = new System.Drawing.Point(30, 303);
            this.txtDireccPersona.Name = "txtDireccPersona";
            this.txtDireccPersona.Size = new System.Drawing.Size(229, 23);
            this.txtDireccPersona.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Dirección domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Apellidos";
            // 
            // txtNomPersona
            // 
            this.txtNomPersona.Location = new System.Drawing.Point(30, 172);
            this.txtNomPersona.Name = "txtNomPersona";
            this.txtNomPersona.Size = new System.Drawing.Size(229, 23);
            this.txtNomPersona.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombres";
            // 
            // cboTipoDocPersona
            // 
            this.cboTipoDocPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocPersona.FormattingEnabled = true;
            this.cboTipoDocPersona.Location = new System.Drawing.Point(31, 76);
            this.cboTipoDocPersona.Name = "cboTipoDocPersona";
            this.cboTipoDocPersona.Size = new System.Drawing.Size(229, 23);
            this.cboTipoDocPersona.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tipo Doc. Identidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(48, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 28);
            this.label13.TabIndex = 51;
            this.label13.Text = "DATOS DE PERSONA";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 16;
            this.btnLimpiar.Location = new System.Drawing.Point(1135, 53);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 23);
            this.btnLimpiar.TabIndex = 57;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(1081, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 23);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(855, 53);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(221, 23);
            this.txtBusqueda.TabIndex = 55;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(715, 53);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(134, 23);
            this.cboBusqueda.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(641, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 53;
            this.label15.Text = "Buscar por:";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(319, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(872, 57);
            this.label14.TabIndex = 52;
            this.label14.Text = "LISTA DE PERSONAS";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Foto_per,
            this.Nro_doc,
            this.Nom_per,
            this.Ape_per,
            this.Edad,
            this.Dir_per,
            this.Opc_Nac,
            this.Estado,
            this.Doc_Identidad,
            this.Genero,
            this.Tipo_Persona,
            this.Est_per,
            this.Doc_ide,
            this.Gen_per,
            this.Tip_per,
            this.Id_Nac});
            this.dtgDatos.Location = new System.Drawing.Point(319, 119);
            this.dtgDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDatos.MultiSelect = false;
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDatos.RowHeadersWidth = 51;
            this.dtgDatos.RowTemplate.Height = 28;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(872, 330);
            this.dtgDatos.TabIndex = 58;
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellContentClick);
            this.dtgDatos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgDatos_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // Foto_per
            // 
            this.Foto_per.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foto_per.DataPropertyName = "Foto_per";
            this.Foto_per.HeaderText = "Foto";
            this.Foto_per.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto_per.Name = "Foto_per";
            this.Foto_per.ReadOnly = true;
            this.Foto_per.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto_per.Width = 69;
            // 
            // Nro_doc
            // 
            this.Nro_doc.DataPropertyName = "Nro_doc";
            this.Nro_doc.HeaderText = "Nro. Documento";
            this.Nro_doc.Name = "Nro_doc";
            this.Nro_doc.ReadOnly = true;
            // 
            // Nom_per
            // 
            this.Nom_per.DataPropertyName = "Nom_per";
            this.Nom_per.HeaderText = "Nombres";
            this.Nom_per.Name = "Nom_per";
            this.Nom_per.ReadOnly = true;
            // 
            // Ape_per
            // 
            this.Ape_per.DataPropertyName = "Ape_per";
            this.Ape_per.HeaderText = "Apellidos";
            this.Ape_per.Name = "Ape_per";
            this.Ape_per.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad_per";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Dir_per
            // 
            this.Dir_per.DataPropertyName = "Dir_per";
            this.Dir_per.HeaderText = "Domicilio";
            this.Dir_per.Name = "Dir_per";
            this.Dir_per.ReadOnly = true;
            // 
            // Opc_Nac
            // 
            this.Opc_Nac.DataPropertyName = "Opc_Nac";
            this.Opc_Nac.HeaderText = "Nacionalidad";
            this.Opc_Nac.Name = "Opc_Nac";
            this.Opc_Nac.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Doc_Identidad
            // 
            this.Doc_Identidad.DataPropertyName = "Doc_Identidad";
            this.Doc_Identidad.HeaderText = "Tipo Doc. Identidad";
            this.Doc_Identidad.Name = "Doc_Identidad";
            this.Doc_Identidad.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Tipo_Persona
            // 
            this.Tipo_Persona.DataPropertyName = "Tipo_Persona";
            this.Tipo_Persona.HeaderText = "Tipo Persona";
            this.Tipo_Persona.Name = "Tipo_Persona";
            this.Tipo_Persona.ReadOnly = true;
            // 
            // Est_per
            // 
            this.Est_per.DataPropertyName = "Est_per";
            this.Est_per.HeaderText = "Est_per";
            this.Est_per.Name = "Est_per";
            this.Est_per.ReadOnly = true;
            this.Est_per.Visible = false;
            // 
            // Doc_ide
            // 
            this.Doc_ide.DataPropertyName = "Doc_ide";
            this.Doc_ide.HeaderText = "Doc_ide";
            this.Doc_ide.Name = "Doc_ide";
            this.Doc_ide.ReadOnly = true;
            this.Doc_ide.Visible = false;
            // 
            // Gen_per
            // 
            this.Gen_per.DataPropertyName = "Gen_per";
            this.Gen_per.HeaderText = "Gen_per";
            this.Gen_per.Name = "Gen_per";
            this.Gen_per.ReadOnly = true;
            this.Gen_per.Visible = false;
            // 
            // Tip_per
            // 
            this.Tip_per.DataPropertyName = "Tip_per";
            this.Tip_per.HeaderText = "Tip_per";
            this.Tip_per.Name = "Tip_per";
            this.Tip_per.ReadOnly = true;
            this.Tip_per.Visible = false;
            // 
            // Id_Nac
            // 
            this.Id_Nac.DataPropertyName = "Id_Nac";
            this.Id_Nac.HeaderText = "Id_Nac";
            this.Id_Nac.Name = "Id_Nac";
            this.Id_Nac.ReadOnly = true;
            this.Id_Nac.Visible = false;
            // 
            // openFileDialogPersona
            // 
            this.openFileDialogPersona.FileName = "openFileDialog1";
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 808);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Name = "frmPersona";
            this.Text = "frmPersona";
            this.Load += new System.EventHandler(this.frmPersona_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox txtApePersona;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private ComboBox cboEstadoPersona;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtNomPersona;
        private Label label1;
        private ComboBox cboTipoDocPersona;
        private Label label4;
        private Label label13;
        private ComboBox cboNacPersona;
        private Label label10;
        private ComboBox cboTipoPersona;
        private Label label7;
        private ComboBox cboGeneroPersona;
        private Label label6;
        private TextBox txtNroDocPersona;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnAbrirPcb;
        private PictureBox pcbImagenPersona;
        private Label label11;
        private OpenFileDialog openFileDialogPersona;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusqueda;
        private ComboBox cboBusqueda;
        private Label label15;
        private Label label14;
        private DataGridView dtgDatos;
        private TextBox txtDireccPersona;
        private DateTimePicker dtpEdadPersona;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewImageColumn Foto_per;
        private DataGridViewTextBoxColumn Nro_doc;
        private DataGridViewTextBoxColumn Nom_per;
        private DataGridViewTextBoxColumn Ape_per;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Dir_per;
        private DataGridViewTextBoxColumn Opc_Nac;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Doc_Identidad;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Tipo_Persona;
        private DataGridViewTextBoxColumn Est_per;
        private DataGridViewTextBoxColumn Doc_ide;
        private DataGridViewTextBoxColumn Gen_per;
        private DataGridViewTextBoxColumn Tip_per;
        private DataGridViewTextBoxColumn Id_Nac;
    }
}