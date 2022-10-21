using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyVentas_GUI
{
    public partial class frmLogin : Form
    {
        int intentos = 0;
        int tiempo = 20;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtLogin .Text.Trim() != "" & txtPassword.Text.Trim() != "")
             {
                // Por ahora estas seran las credenciales
                if (txtLogin.Text == "User1" & txtPassword.Text == "12345")
                {
                   
                    this.Hide();
                    timer1.Enabled = false;
                    MDIPrincipal mdi = new MDIPrincipal();
                    clsCredenciales.Usuario = txtLogin.Text;
                    clsCredenciales.Password = txtPassword.Text;
                    clsCredenciales.Nivel = 1;
                    mdi.ShowDialog();
                 }
                else
                { 
                    MessageBox.Show ("Usuario o Password incorrectos", 
                    "Mensaje",MessageBoxButtons .OK ,MessageBoxIcon .Error );
                    intentos +=1;
                    if (intentos == 3)
                    {
                        Application.Exit();
                    }
              }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
               intentos +=1;
            }
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }
    }
}
