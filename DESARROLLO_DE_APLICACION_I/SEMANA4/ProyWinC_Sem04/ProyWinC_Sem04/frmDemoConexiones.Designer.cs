namespace ProyWinC_Sem04
{
    partial class frmDemoConexiones
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
            this.grpConexion = new System.Windows.Forms.GroupBox();
            this.btnCerrarConexion = new System.Windows.Forms.Button();
            this.btnAbrirConexion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConexion
            // 
            this.grpConexion.Controls.Add(this.btnCerrarConexion);
            this.grpConexion.Controls.Add(this.btnAbrirConexion);
            this.grpConexion.Location = new System.Drawing.Point(113, 64);
            this.grpConexion.Name = "grpConexion";
            this.grpConexion.Size = new System.Drawing.Size(770, 295);
            this.grpConexion.TabIndex = 0;
            this.grpConexion.TabStop = false;
            this.grpConexion.Text = "Manejo de conexion";
            // 
            // btnCerrarConexion
            // 
            this.btnCerrarConexion.Enabled = false;
            this.btnCerrarConexion.Image = global::ProyWinC_Sem04.Properties.Resources.Cancelar;
            this.btnCerrarConexion.Location = new System.Drawing.Point(408, 160);
            this.btnCerrarConexion.Name = "btnCerrarConexion";
            this.btnCerrarConexion.Size = new System.Drawing.Size(298, 60);
            this.btnCerrarConexion.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCerrarConexion, "Cierra la conexion a VentasLeon");
            this.btnCerrarConexion.UseVisualStyleBackColor = true;
            this.btnCerrarConexion.Click += new System.EventHandler(this.btnCerrarConexion_Click);
            // 
            // btnAbrirConexion
            // 
            this.btnAbrirConexion.Image = global::ProyWinC_Sem04.Properties.Resources.Aceptar;
            this.btnAbrirConexion.Location = new System.Drawing.Point(85, 160);
            this.btnAbrirConexion.Name = "btnAbrirConexion";
            this.btnAbrirConexion.Size = new System.Drawing.Size(298, 60);
            this.btnAbrirConexion.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAbrirConexion, "Abre la conexion a VentasLeon");
            this.btnAbrirConexion.UseVisualStyleBackColor = true;
            this.btnAbrirConexion.Click += new System.EventHandler(this.btnAbrirConexion_Click);
            // 
            // frmDemoConexiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 459);
            this.Controls.Add(this.grpConexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDemoConexiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Conexiones";
            this.grpConexion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpConexion;
        private Button btnCerrarConexion;
        private ToolTip toolTip1;
        private Button btnAbrirConexion;
    }
}