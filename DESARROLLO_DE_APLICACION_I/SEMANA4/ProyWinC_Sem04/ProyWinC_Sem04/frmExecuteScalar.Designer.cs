namespace ProyWinC_Sem04
{
    partial class frmExecuteScalar
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
            this.btnObtenerMaxinoPrecio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskAño = new System.Windows.Forms.MaskedTextBox();
            this.btnObtenerVentaAnual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObtenerMaxinoPrecio
            // 
            this.btnObtenerMaxinoPrecio.Location = new System.Drawing.Point(76, 74);
            this.btnObtenerMaxinoPrecio.Name = "btnObtenerMaxinoPrecio";
            this.btnObtenerMaxinoPrecio.Size = new System.Drawing.Size(301, 42);
            this.btnObtenerMaxinoPrecio.TabIndex = 0;
            this.btnObtenerMaxinoPrecio.Text = "Obtener Maximo Precio";
            this.btnObtenerMaxinoPrecio.UseVisualStyleBackColor = true;
            this.btnObtenerMaxinoPrecio.Click += new System.EventHandler(this.btnObtenerMaxinoPrecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año";
            // 
            // mskAño
            // 
            this.mskAño.Location = new System.Drawing.Point(252, 150);
            this.mskAño.Mask = "9999";
            this.mskAño.Name = "mskAño";
            this.mskAño.Size = new System.Drawing.Size(125, 27);
            this.mskAño.TabIndex = 2;
            // 
            // btnObtenerVentaAnual
            // 
            this.btnObtenerVentaAnual.Location = new System.Drawing.Point(76, 204);
            this.btnObtenerVentaAnual.Name = "btnObtenerVentaAnual";
            this.btnObtenerVentaAnual.Size = new System.Drawing.Size(301, 46);
            this.btnObtenerVentaAnual.TabIndex = 3;
            this.btnObtenerVentaAnual.Text = "Obtener Venta Anual";
            this.btnObtenerVentaAnual.UseVisualStyleBackColor = true;
            this.btnObtenerVentaAnual.Click += new System.EventHandler(this.btnObtenerVentaAnual_Click);
            // 
            // frmExecuteScalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObtenerVentaAnual);
            this.Controls.Add(this.mskAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerMaxinoPrecio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExecuteScalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Execute Sacalar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnObtenerMaxinoPrecio;
        private Label label1;
        private MaskedTextBox mskAño;
        private Button btnObtenerVentaAnual;
    }
}