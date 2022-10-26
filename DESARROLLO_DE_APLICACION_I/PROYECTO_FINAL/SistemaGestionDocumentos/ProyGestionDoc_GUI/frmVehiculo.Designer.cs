namespace ProyGestionDoc_GUI
{
    partial class frmVehiculo
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
            this.label13 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mod_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_pla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opc_Mar_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto_veh = new System.Windows.Forms.DataGridViewImageColumn();
            this.Est_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Mar_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdVeh = new System.Windows.Forms.TextBox();
            this.btnAbrirPcb = new FontAwesome.Sharp.IconButton();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(23, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 28);
            this.label13.TabIndex = 27;
            this.label13.Text = "DATOS DEL VEHICULO";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(29, 84);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(229, 23);
            this.cboMarca.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(29, 130);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(229, 23);
            this.txtModelo.TabIndex = 31;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(29, 176);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(229, 23);
            this.txtPlaca.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nro. Placa";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(29, 223);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(229, 23);
            this.txtColor.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Color";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(29, 270);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(229, 23);
            this.cboEstado.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Estado";
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
            this.btnEliminar.Location = new System.Drawing.Point(29, 554);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(229, 23);
            this.btnEliminar.TabIndex = 40;
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
            this.btnEditar.Location = new System.Drawing.Point(29, 525);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(229, 23);
            this.btnEditar.TabIndex = 39;
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
            this.btnRegistrar.Location = new System.Drawing.Point(29, 496);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(229, 23);
            this.btnRegistrar.TabIndex = 38;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(1122, 60);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 23);
            this.btnLimpiar.TabIndex = 46;
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
            this.btnBuscar.Location = new System.Drawing.Point(1068, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 23);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(842, 60);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(221, 23);
            this.txtBusqueda.TabIndex = 44;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(702, 60);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(134, 23);
            this.cboBusqueda.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(628, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "Buscar por:";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(306, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(872, 57);
            this.label14.TabIndex = 41;
            this.label14.Text = "LISTA DE VEHICULOS";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
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
            this.Id_veh,
            this.Mod_veh,
            this.Nro_pla,
            this.Color,
            this.Opc_Mar_veh,
            this.Fec_reg,
            this.Foto_veh,
            this.Est_veh,
            this.Estado,
            this.Id_Mar_veh});
            this.dtgDatos.Location = new System.Drawing.Point(306, 124);
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
            this.dtgDatos.TabIndex = 47;
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellContentClick);
            this.dtgDatos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgDatos_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 125;
            // 
            // Id_veh
            // 
            this.Id_veh.DataPropertyName = "Id_veh";
            this.Id_veh.HeaderText = "Id_veh";
            this.Id_veh.MinimumWidth = 6;
            this.Id_veh.Name = "Id_veh";
            this.Id_veh.ReadOnly = true;
            this.Id_veh.Visible = false;
            this.Id_veh.Width = 125;
            // 
            // Mod_veh
            // 
            this.Mod_veh.DataPropertyName = "Mod_veh";
            this.Mod_veh.HeaderText = "Modelo";
            this.Mod_veh.MinimumWidth = 6;
            this.Mod_veh.Name = "Mod_veh";
            this.Mod_veh.ReadOnly = true;
            this.Mod_veh.Width = 125;
            // 
            // Nro_pla
            // 
            this.Nro_pla.DataPropertyName = "Nro_pla";
            this.Nro_pla.HeaderText = "Nro. Placa";
            this.Nro_pla.MinimumWidth = 6;
            this.Nro_pla.Name = "Nro_pla";
            this.Nro_pla.ReadOnly = true;
            this.Nro_pla.Width = 125;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 125;
            // 
            // Opc_Mar_veh
            // 
            this.Opc_Mar_veh.DataPropertyName = "Opc_Mar_veh";
            this.Opc_Mar_veh.HeaderText = "Marca";
            this.Opc_Mar_veh.MinimumWidth = 6;
            this.Opc_Mar_veh.Name = "Opc_Mar_veh";
            this.Opc_Mar_veh.ReadOnly = true;
            this.Opc_Mar_veh.Width = 125;
            // 
            // Fec_reg
            // 
            this.Fec_reg.DataPropertyName = "Fec_reg";
            this.Fec_reg.HeaderText = "Fecha Registro";
            this.Fec_reg.MinimumWidth = 6;
            this.Fec_reg.Name = "Fec_reg";
            this.Fec_reg.ReadOnly = true;
            this.Fec_reg.Visible = false;
            this.Fec_reg.Width = 125;
            // 
            // Foto_veh
            // 
            this.Foto_veh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Foto_veh.DataPropertyName = "Foto_veh";
            this.Foto_veh.HeaderText = "Foto";
            this.Foto_veh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto_veh.MinimumWidth = 6;
            this.Foto_veh.Name = "Foto_veh";
            this.Foto_veh.ReadOnly = true;
            this.Foto_veh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Est_veh
            // 
            this.Est_veh.DataPropertyName = "Est_veh";
            this.Est_veh.HeaderText = "Est_veh";
            this.Est_veh.MinimumWidth = 6;
            this.Est_veh.Name = "Est_veh";
            this.Est_veh.ReadOnly = true;
            this.Est_veh.Visible = false;
            this.Est_veh.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // Id_Mar_veh
            // 
            this.Id_Mar_veh.DataPropertyName = "Id_Mar_veh";
            this.Id_Mar_veh.HeaderText = "Id_Mar_veh";
            this.Id_Mar_veh.MinimumWidth = 6;
            this.Id_Mar_veh.Name = "Id_Mar_veh";
            this.Id_Mar_veh.ReadOnly = true;
            this.Id_Mar_veh.Visible = false;
            this.Id_Mar_veh.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Imagen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtIdVeh);
            this.panel1.Controls.Add(this.btnAbrirPcb);
            this.panel1.Controls.Add(this.pcbImagen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 601);
            this.panel1.TabIndex = 49;
            // 
            // txtIdVeh
            // 
            this.txtIdVeh.Location = new System.Drawing.Point(207, 60);
            this.txtIdVeh.Name = "txtIdVeh";
            this.txtIdVeh.Size = new System.Drawing.Size(50, 23);
            this.txtIdVeh.TabIndex = 50;
            this.txtIdVeh.Visible = false;
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
            this.btnAbrirPcb.Location = new System.Drawing.Point(29, 332);
            this.btnAbrirPcb.Name = "btnAbrirPcb";
            this.btnAbrirPcb.Size = new System.Drawing.Size(229, 23);
            this.btnAbrirPcb.TabIndex = 50;
            this.btnAbrirPcb.Text = "Cargar Imagen";
            this.btnAbrirPcb.UseVisualStyleBackColor = false;
            this.btnAbrirPcb.Click += new System.EventHandler(this.btnAbrirPcb_Click);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Location = new System.Drawing.Point(29, 360);
            this.pcbImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(228, 130);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 0;
            this.pcbImagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1351, 601);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Name = "frmVehiculo";
            this.Text = "frmVehiculo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label13;
        private ComboBox cboMarca;
        private Label label4;
        private Label label1;
        private TextBox txtModelo;
        private TextBox txtPlaca;
        private Label label3;
        private TextBox txtColor;
        private Label label5;
        private ComboBox cboEstado;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusqueda;
        private ComboBox cboBusqueda;
        private Label label15;
        private Label label14;
        private DataGridView dtgDatos;
        private Label label7;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAbrirPcb;
        private PictureBox pcbImagen;
        private OpenFileDialog openFileDialog1;
        private TextBox txtIdVeh;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id_veh;
        private DataGridViewTextBoxColumn Mod_veh;
        private DataGridViewTextBoxColumn Nro_pla;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn Opc_Mar_veh;
        private DataGridViewTextBoxColumn Fec_reg;
        private DataGridViewImageColumn Foto_veh;
        private DataGridViewTextBoxColumn Est_veh;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Id_Mar_veh;
    }
}