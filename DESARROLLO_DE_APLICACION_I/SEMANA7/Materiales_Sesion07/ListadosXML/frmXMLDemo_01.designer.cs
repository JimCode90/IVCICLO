namespace ProyVentas_GUI
{
    partial class frmXMLDemo_01
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
            this.btnGenerarXMLFacturacion = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.btnGenerarXMLProveedores = new System.Windows.Forms.Button();
            this.btnConsumirXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarXMLFacturacion
            // 
            this.btnGenerarXMLFacturacion.Location = new System.Drawing.Point(128, 73);
            this.btnGenerarXMLFacturacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerarXMLFacturacion.Name = "btnGenerarXMLFacturacion";
            this.btnGenerarXMLFacturacion.Size = new System.Drawing.Size(244, 36);
            this.btnGenerarXMLFacturacion.TabIndex = 7;
            this.btnGenerarXMLFacturacion.Text = "Generar XML Facturación";
            this.btnGenerarXMLFacturacion.UseVisualStyleBackColor = true;
            this.btnGenerarXMLFacturacion.Click += new System.EventHandler(this.btnGenerarXMLFacturacion_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(65, 128);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 15);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Documento XML:";
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(69, 163);
            this.txtXML.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.ReadOnly = true;
            this.txtXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXML.Size = new System.Drawing.Size(356, 324);
            this.txtXML.TabIndex = 4;
            // 
            // btnGenerarXMLProveedores
            // 
            this.btnGenerarXMLProveedores.Location = new System.Drawing.Point(128, 30);
            this.btnGenerarXMLProveedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerarXMLProveedores.Name = "btnGenerarXMLProveedores";
            this.btnGenerarXMLProveedores.Size = new System.Drawing.Size(244, 36);
            this.btnGenerarXMLProveedores.TabIndex = 8;
            this.btnGenerarXMLProveedores.Text = "Generar XML Proveedores";
            this.btnGenerarXMLProveedores.UseVisualStyleBackColor = true;
            this.btnGenerarXMLProveedores.Click += new System.EventHandler(this.btnGenerarXMLProveedores_Click);
            // 
            // btnConsumirXML
            // 
            this.btnConsumirXML.Location = new System.Drawing.Point(166, 500);
            this.btnConsumirXML.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsumirXML.Name = "btnConsumirXML";
            this.btnConsumirXML.Size = new System.Drawing.Size(152, 36);
            this.btnConsumirXML.TabIndex = 9;
            this.btnConsumirXML.Text = "Consumir XML";
            this.btnConsumirXML.UseVisualStyleBackColor = true;
            this.btnConsumirXML.Click += new System.EventHandler(this.btnConsumirXML_Click);
            // 
            // frmXMLDemo_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 549);
            this.Controls.Add(this.btnConsumirXML);
            this.Controls.Add(this.btnGenerarXMLProveedores);
            this.Controls.Add(this.btnGenerarXMLFacturacion);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtXML);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmXMLDemo_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generando Listados XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGenerarXMLFacturacion;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.Button btnGenerarXMLProveedores;
        private System.Windows.Forms.Button btnConsumirXML;
    }
}