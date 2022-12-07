namespace ProyGestionDoc_GUI
{
    partial class frmEspecie
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
            this.txtMarcaEspecie = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.cboEstadoEspecie = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSerieEspecie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadEspecie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColorEspecie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModeloEspecie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescEspecie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoEspecie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdEspecie = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opc_espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mar_espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mod_espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Can_espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est_espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_tip_espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtMarcaEspecie);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.cboEstadoEspecie);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSerieEspecie);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCantidadEspecie);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtColorEspecie);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtModeloEspecie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescEspecie);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTipoEspecie);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtIdEspecie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 601);
            this.panel1.TabIndex = 50;
            // 
            // txtMarcaEspecie
            // 
            this.txtMarcaEspecie.Location = new System.Drawing.Point(31, 218);
            this.txtMarcaEspecie.Name = "txtMarcaEspecie";
            this.txtMarcaEspecie.Size = new System.Drawing.Size(229, 23);
            this.txtMarcaEspecie.TabIndex = 3;
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
            this.btnEliminar.Location = new System.Drawing.Point(30, 520);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(229, 23);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(30, 491);
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
            this.btnRegistrar.Location = new System.Drawing.Point(30, 462);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(229, 23);
            this.btnRegistrar.TabIndex = 68;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboEstadoEspecie
            // 
            this.cboEstadoEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoEspecie.FormattingEnabled = true;
            this.cboEstadoEspecie.Location = new System.Drawing.Point(30, 427);
            this.cboEstadoEspecie.Name = "cboEstadoEspecie";
            this.cboEstadoEspecie.Size = new System.Drawing.Size(229, 23);
            this.cboEstadoEspecie.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Estado";
            // 
            // txtSerieEspecie
            // 
            this.txtSerieEspecie.Location = new System.Drawing.Point(30, 385);
            this.txtSerieEspecie.Name = "txtSerieEspecie";
            this.txtSerieEspecie.Size = new System.Drawing.Size(229, 23);
            this.txtSerieEspecie.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Número serie";
            // 
            // txtCantidadEspecie
            // 
            this.txtCantidadEspecie.Location = new System.Drawing.Point(30, 344);
            this.txtCantidadEspecie.Name = "txtCantidadEspecie";
            this.txtCantidadEspecie.Size = new System.Drawing.Size(229, 23);
            this.txtCantidadEspecie.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Cantidad";
            // 
            // txtColorEspecie
            // 
            this.txtColorEspecie.Location = new System.Drawing.Point(30, 303);
            this.txtColorEspecie.Name = "txtColorEspecie";
            this.txtColorEspecie.Size = new System.Drawing.Size(229, 23);
            this.txtColorEspecie.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Color";
            // 
            // txtModeloEspecie
            // 
            this.txtModeloEspecie.Location = new System.Drawing.Point(30, 260);
            this.txtModeloEspecie.Name = "txtModeloEspecie";
            this.txtModeloEspecie.Size = new System.Drawing.Size(229, 23);
            this.txtModeloEspecie.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Marca";
            // 
            // txtDescEspecie
            // 
            this.txtDescEspecie.Location = new System.Drawing.Point(30, 172);
            this.txtDescEspecie.Name = "txtDescEspecie";
            this.txtDescEspecie.Size = new System.Drawing.Size(229, 23);
            this.txtDescEspecie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Descripción";
            // 
            // cboTipoEspecie
            // 
            this.cboTipoEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEspecie.FormattingEnabled = true;
            this.cboTipoEspecie.Location = new System.Drawing.Point(30, 126);
            this.cboTipoEspecie.Name = "cboTipoEspecie";
            this.cboTipoEspecie.Size = new System.Drawing.Size(229, 23);
            this.cboTipoEspecie.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tipo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(43, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 28);
            this.label13.TabIndex = 51;
            this.label13.Text = "DATOS DE ESPECIE";
            // 
            // txtIdEspecie
            // 
            this.txtIdEspecie.Location = new System.Drawing.Point(208, 81);
            this.txtIdEspecie.Name = "txtIdEspecie";
            this.txtIdEspecie.Size = new System.Drawing.Size(50, 23);
            this.txtIdEspecie.TabIndex = 50;
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
            this.btnLimpiar.Location = new System.Drawing.Point(1133, 49);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 23);
            this.btnLimpiar.TabIndex = 56;
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
            this.btnBuscar.Location = new System.Drawing.Point(1079, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 23);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(853, 49);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(221, 23);
            this.txtBusqueda.TabIndex = 54;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(713, 49);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(134, 23);
            this.cboBusqueda.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(640, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 52;
            this.label15.Text = "Buscar por:";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(318, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(872, 57);
            this.label14.TabIndex = 51;
            this.label14.Text = "LISTA DE ESPECIES";
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
            this.Id_espec,
            this.Opc_espec,
            this.Des_espec,
            this.Mar_espec,
            this.Mod_espec,
            this.Color,
            this.Can_espec,
            this.Nro_serie,
            this.Estado,
            this.Est_espec,
            this.Id_tip_espec});
            this.dtgDatos.Location = new System.Drawing.Point(318, 118);
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
            this.dtgDatos.Size = new System.Drawing.Size(872, 330);
            this.dtgDatos.TabIndex = 57;
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
            // Id_espec
            // 
            this.Id_espec.DataPropertyName = "Id_espec";
            this.Id_espec.HeaderText = "Id_espec";
            this.Id_espec.MinimumWidth = 6;
            this.Id_espec.Name = "Id_espec";
            this.Id_espec.ReadOnly = true;
            this.Id_espec.Visible = false;
            this.Id_espec.Width = 125;
            // 
            // Opc_espec
            // 
            this.Opc_espec.DataPropertyName = "Opc_espec";
            this.Opc_espec.HeaderText = "Tipo";
            this.Opc_espec.MinimumWidth = 6;
            this.Opc_espec.Name = "Opc_espec";
            this.Opc_espec.ReadOnly = true;
            this.Opc_espec.Width = 125;
            // 
            // Des_espec
            // 
            this.Des_espec.DataPropertyName = "Des_espec";
            this.Des_espec.HeaderText = "Descripción";
            this.Des_espec.MinimumWidth = 6;
            this.Des_espec.Name = "Des_espec";
            this.Des_espec.ReadOnly = true;
            this.Des_espec.Width = 125;
            // 
            // Mar_espec
            // 
            this.Mar_espec.DataPropertyName = "Mar_espec";
            this.Mar_espec.HeaderText = "Marca";
            this.Mar_espec.MinimumWidth = 6;
            this.Mar_espec.Name = "Mar_espec";
            this.Mar_espec.ReadOnly = true;
            this.Mar_espec.Width = 125;
            // 
            // Mod_espec
            // 
            this.Mod_espec.DataPropertyName = "Mod_espec";
            this.Mod_espec.HeaderText = "Modelo";
            this.Mod_espec.MinimumWidth = 6;
            this.Mod_espec.Name = "Mod_espec";
            this.Mod_espec.ReadOnly = true;
            this.Mod_espec.Width = 125;
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
            // Can_espec
            // 
            this.Can_espec.DataPropertyName = "Can_espec";
            this.Can_espec.HeaderText = "Cantidad";
            this.Can_espec.MinimumWidth = 6;
            this.Can_espec.Name = "Can_espec";
            this.Can_espec.ReadOnly = true;
            this.Can_espec.Width = 125;
            // 
            // Nro_serie
            // 
            this.Nro_serie.DataPropertyName = "Nro_serie";
            this.Nro_serie.HeaderText = "Nro. serie";
            this.Nro_serie.MinimumWidth = 6;
            this.Nro_serie.Name = "Nro_serie";
            this.Nro_serie.ReadOnly = true;
            this.Nro_serie.Width = 125;
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
            // Est_espec
            // 
            this.Est_espec.DataPropertyName = "Est_espec";
            this.Est_espec.HeaderText = "Est_espec";
            this.Est_espec.MinimumWidth = 6;
            this.Est_espec.Name = "Est_espec";
            this.Est_espec.ReadOnly = true;
            this.Est_espec.Visible = false;
            this.Est_espec.Width = 125;
            // 
            // Id_tip_espec
            // 
            this.Id_tip_espec.DataPropertyName = "Id_tip_espec";
            this.Id_tip_espec.HeaderText = "Id_tip_espec";
            this.Id_tip_espec.MinimumWidth = 6;
            this.Id_tip_espec.Name = "Id_tip_espec";
            this.Id_tip_espec.ReadOnly = true;
            this.Id_tip_espec.Visible = false;
            this.Id_tip_espec.Width = 125;
            // 
            // frmEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 601);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Name = "frmEspecie";
            this.Text = "frmEspecie";
            this.Load += new System.EventHandler(this.frmEspecie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox txtIdEspecie;
        private Label label13;
        private ComboBox cboEstadoEspecie;
        private Label label8;
        private TextBox txtSerieEspecie;
        private Label label7;
        private TextBox txtCantidadEspecie;
        private Label label6;
        private TextBox txtColorEspecie;
        private Label label5;
        private TextBox txtModeloEspecie;
        private Label label3;
        private Label label2;
        private TextBox txtDescEspecie;
        private Label label1;
        private ComboBox cboTipoEspecie;
        private Label label4;
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
        private TextBox txtMarcaEspecie;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id_espec;
        private DataGridViewTextBoxColumn Opc_espec;
        private DataGridViewTextBoxColumn Des_espec;
        private DataGridViewTextBoxColumn Mar_espec;
        private DataGridViewTextBoxColumn Mod_espec;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn Can_espec;
        private DataGridViewTextBoxColumn Nro_serie;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Est_espec;
        private DataGridViewTextBoxColumn Id_tip_espec;
    }
}