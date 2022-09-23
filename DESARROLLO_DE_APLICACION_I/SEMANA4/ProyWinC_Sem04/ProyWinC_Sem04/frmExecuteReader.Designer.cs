namespace ProyWinC_Sem04
{
    partial class frmExecuteReader
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
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnListarProveedores = new System.Windows.Forms.Button();
            this.lstProveedores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(114, 32);
            this.btnListarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(219, 36);
            this.btnListarProductos.TabIndex = 0;
            this.btnListarProductos.Text = "Listar Productos";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 15;
            this.lstProductos.Location = new System.Drawing.Point(444, 32);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(387, 124);
            this.lstProductos.TabIndex = 1;
            // 
            // btnListarProveedores
            // 
            this.btnListarProveedores.Location = new System.Drawing.Point(114, 179);
            this.btnListarProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarProveedores.Name = "btnListarProveedores";
            this.btnListarProveedores.Size = new System.Drawing.Size(219, 36);
            this.btnListarProveedores.TabIndex = 0;
            this.btnListarProveedores.Text = "Listar Proveedores";
            this.btnListarProveedores.UseVisualStyleBackColor = true;
            this.btnListarProveedores.Click += new System.EventHandler(this.btnListarProveedores_Click);
            // 
            // lstProveedores
            // 
            this.lstProveedores.FormattingEnabled = true;
            this.lstProveedores.ItemHeight = 15;
            this.lstProveedores.Location = new System.Drawing.Point(444, 179);
            this.lstProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProveedores.Name = "lstProveedores";
            this.lstProveedores.Size = new System.Drawing.Size(387, 124);
            this.lstProveedores.TabIndex = 1;
            // 
            // frmExecuteReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 338);
            this.Controls.Add(this.lstProveedores);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnListarProveedores);
            this.Controls.Add(this.btnListarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExecuteReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Execute Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListarProductos;
        private ListBox lstProductos;
        private Button btnListarProveedores;
        private ListBox lstProveedores;
    }
}