
namespace ProyVentas_GUI
{
    partial class CategoriaMan01
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
            this.dtgCategoria = new System.Windows.Forms.DataGridView();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto_cat = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCategoria
            // 
            this.dtgCategoria.AllowUserToAddRows = false;
            this.dtgCategoria.AllowUserToDeleteRows = false;
            this.dtgCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cat,
            this.Des_cat,
            this.Foto_cat});
            this.dtgCategoria.Location = new System.Drawing.Point(14, 81);
            this.dtgCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgCategoria.Name = "dtgCategoria";
            this.dtgCategoria.ReadOnly = true;
            this.dtgCategoria.RowHeadersVisible = false;
            this.dtgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategoria.Size = new System.Drawing.Size(632, 282);
            this.dtgCategoria.TabIndex = 0;
            this.dtgCategoria.DoubleClick += new System.EventHandler(this.dtgCategoria_DoubleClick);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(583, 374);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(63, 26);
            this.lblRegistros.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registros:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(546, 420);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 27);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(451, 420);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 27);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(357, 420);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(88, 27);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(240, 14);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(330, 23);
            this.txtFiltro.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese iniciales de descripcion:";
            // 
            // Id_Cat
            // 
            this.Id_Cat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id_Cat.DataPropertyName = "Id_cat";
            this.Id_Cat.HeaderText = "Id Categoria";
            this.Id_Cat.Name = "Id_Cat";
            this.Id_Cat.ReadOnly = true;
            this.Id_Cat.Width = 210;
            // 
            // Des_cat
            // 
            this.Des_cat.DataPropertyName = "Des_cat";
            this.Des_cat.HeaderText = "Descripcion";
            this.Des_cat.Name = "Des_cat";
            this.Des_cat.ReadOnly = true;
            // 
            // Foto_cat
            // 
            this.Foto_cat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Foto_cat.DataPropertyName = "Foto_cat";
            this.Foto_cat.HeaderText = "Foto";
            this.Foto_cat.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto_cat.Name = "Foto_cat";
            this.Foto_cat.ReadOnly = true;
            // 
            // CategoriaMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 475);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoriaMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Categorias";
            this.Load += new System.EventHandler(this.CategoriaMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategoria;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn Id_Cat;
        private DataGridViewTextBoxColumn Des_cat;
        private DataGridViewImageColumn Foto_cat;
    }
}