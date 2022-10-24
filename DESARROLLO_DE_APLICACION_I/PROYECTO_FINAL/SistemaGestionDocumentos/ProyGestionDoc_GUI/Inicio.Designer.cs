namespace ProyGestionDoc_GUI
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuDocumentos = new FontAwesome.Sharp.IconMenuItem();
            this.menuPersonas = new FontAwesome.Sharp.IconMenuItem();
            this.menuVehiculos = new FontAwesome.Sharp.IconMenuItem();
            this.menuArmamentos = new FontAwesome.Sharp.IconMenuItem();
            this.menuEspecies = new FontAwesome.Sharp.IconMenuItem();
            this.menuConsultas = new FontAwesome.Sharp.IconMenuItem();
            this.menuConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitle = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuDocumentos,
            this.menuPersonas,
            this.menuVehiculos,
            this.menuArmamentos,
            this.menuEspecies,
            this.menuConsultas,
            this.menuConfiguracion});
            this.menu.Location = new System.Drawing.Point(0, 72);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1098, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(100, 69);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuDocumentos
            // 
            this.menuDocumentos.AutoSize = false;
            this.menuDocumentos.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.menuDocumentos.IconColor = System.Drawing.Color.Black;
            this.menuDocumentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuDocumentos.IconSize = 50;
            this.menuDocumentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDocumentos.Name = "menuDocumentos";
            this.menuDocumentos.Size = new System.Drawing.Size(100, 69);
            this.menuDocumentos.Text = "Documentos";
            this.menuDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuPersonas
            // 
            this.menuPersonas.AutoSize = false;
            this.menuPersonas.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menuPersonas.IconColor = System.Drawing.Color.Black;
            this.menuPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuPersonas.IconSize = 50;
            this.menuPersonas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPersonas.Name = "menuPersonas";
            this.menuPersonas.Size = new System.Drawing.Size(100, 69);
            this.menuPersonas.Text = "Personas";
            this.menuPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuPersonas.Click += new System.EventHandler(this.menuPersonas_Click);
            // 
            // menuVehiculos
            // 
            this.menuVehiculos.AutoSize = false;
            this.menuVehiculos.IconChar = FontAwesome.Sharp.IconChar.Automobile;
            this.menuVehiculos.IconColor = System.Drawing.Color.Black;
            this.menuVehiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVehiculos.IconSize = 50;
            this.menuVehiculos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVehiculos.Name = "menuVehiculos";
            this.menuVehiculos.Size = new System.Drawing.Size(100, 69);
            this.menuVehiculos.Text = "Vehiculos";
            this.menuVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuVehiculos.Click += new System.EventHandler(this.menuVehiculos_Click);
            // 
            // menuArmamentos
            // 
            this.menuArmamentos.AutoSize = false;
            this.menuArmamentos.IconChar = FontAwesome.Sharp.IconChar.Gun;
            this.menuArmamentos.IconColor = System.Drawing.Color.Black;
            this.menuArmamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuArmamentos.IconSize = 50;
            this.menuArmamentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuArmamentos.Name = "menuArmamentos";
            this.menuArmamentos.Size = new System.Drawing.Size(100, 69);
            this.menuArmamentos.Text = "Armamentos";
            this.menuArmamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuEspecies
            // 
            this.menuEspecies.AutoSize = false;
            this.menuEspecies.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.menuEspecies.IconColor = System.Drawing.Color.Black;
            this.menuEspecies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEspecies.IconSize = 50;
            this.menuEspecies.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEspecies.Name = "menuEspecies";
            this.menuEspecies.Size = new System.Drawing.Size(100, 69);
            this.menuEspecies.Text = "Especies";
            this.menuEspecies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuEspecies.Click += new System.EventHandler(this.menuEspecies_Click);
            // 
            // menuConsultas
            // 
            this.menuConsultas.AutoSize = false;
            this.menuConsultas.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.menuConsultas.IconColor = System.Drawing.Color.Black;
            this.menuConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuConsultas.IconSize = 50;
            this.menuConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConsultas.Name = "menuConsultas";
            this.menuConsultas.Size = new System.Drawing.Size(100, 69);
            this.menuConsultas.Text = "Consultas";
            this.menuConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.AutoSize = false;
            this.menuConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.menuConfiguracion.IconColor = System.Drawing.Color.Black;
            this.menuConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuConfiguracion.IconSize = 50;
            this.menuConfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(100, 69);
            this.menuConfiguracion.Text = "Configuración";
            this.menuConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = false;
            this.menuTitle.BackColor = System.Drawing.Color.DarkGreen;
            this.menuTitle.Location = new System.Drawing.Point(0, 0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitle.Size = new System.Drawing.Size(1098, 72);
            this.menuTitle.TabIndex = 1;
            this.menuTitle.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Consultas y Gestión de Documentos Policiales";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 145);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1098, 682);
            this.contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 827);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuDocumentos;
        private FontAwesome.Sharp.IconMenuItem menuPersonas;
        private FontAwesome.Sharp.IconMenuItem menuVehiculos;
        private FontAwesome.Sharp.IconMenuItem menuArmamentos;
        private FontAwesome.Sharp.IconMenuItem menuEspecies;
        private FontAwesome.Sharp.IconMenuItem menuConsultas;
        private FontAwesome.Sharp.IconMenuItem menuConfiguracion;
        private MenuStrip menuTitle;
        private Label label1;
        private Panel contenedor;
    }
}