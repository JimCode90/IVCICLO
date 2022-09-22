namespace ProyWinC_Sem02
{
    partial class frmCombos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCargos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstEC = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomApe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCodDistrito = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione estado civil:";
            // 
            // cboCargos
            // 
            this.cboCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargos.FormattingEnabled = true;
            this.cboCargos.Location = new System.Drawing.Point(262, 119);
            this.cboCargos.Name = "cboCargos";
            this.cboCargos.Size = new System.Drawing.Size(208, 23);
            this.cboCargos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bonificacion:";
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBonificacion.Location = new System.Drawing.Point(262, 424);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(123, 23);
            this.lblBonificacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione cargo:";
            // 
            // lstEC
            // 
            this.lstEC.FormattingEnabled = true;
            this.lstEC.ItemHeight = 15;
            this.lstEC.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Viudo",
            "Conviviente"});
            this.lstEC.Location = new System.Drawing.Point(262, 162);
            this.lstEC.Name = "lstEC";
            this.lstEC.Size = new System.Drawing.Size(178, 109);
            this.lstEC.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ingrese nombre y apellido:";
            // 
            // txtNomApe
            // 
            this.txtNomApe.Location = new System.Drawing.Point(262, 80);
            this.txtNomApe.Name = "txtNomApe";
            this.txtNomApe.Size = new System.Drawing.Size(259, 23);
            this.txtNomApe.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sueldo:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSueldo.Location = new System.Drawing.Point(262, 381);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(123, 23);
            this.lblSueldo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ingrese DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(262, 41);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(137, 23);
            this.txtDNI.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(262, 329);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cod. Distrito:";
            // 
            // lblCodDistrito
            // 
            this.lblCodDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodDistrito.Location = new System.Drawing.Point(262, 468);
            this.lblCodDistrito.Name = "lblCodDistrito";
            this.lblCodDistrito.Size = new System.Drawing.Size(123, 23);
            this.lblCodDistrito.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccione distrito:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(262, 291);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(208, 23);
            this.cboDistrito.TabIndex = 4;
            // 
            // frmCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 522);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNomApe);
            this.Controls.Add(this.lstEC);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCodDistrito);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBonificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDistrito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCargos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmCombos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Combos y Listas ";
            this.Load += new System.EventHandler(this.frmCombos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboCargos;
        private Label label2;
        private Label lblBonificacion;
        private Label label4;
        private ListBox lstEC;
        private Label label5;
        private TextBox txtNomApe;
        private Label label6;
        private Label lblSueldo;
        private Label label8;
        private TextBox txtDNI;
        private Button btnCalcular;
        private Label label9;
        private Label lblCodDistrito;
        private Label label3;
        private ComboBox cboDistrito;
    }
}