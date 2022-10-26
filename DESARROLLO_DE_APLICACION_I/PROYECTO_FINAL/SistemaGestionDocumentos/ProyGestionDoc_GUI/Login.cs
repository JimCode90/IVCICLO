using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar...
using ProyGestionDoc_BE;
using ProyGestionDoc_BL;

namespace ProyGestionDoc_GUI
{
    public partial class Login : Form
    {

        int intentos = 0;
        int tiempo = 20;

        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCip.Text.Trim() != "" & txtPassword.Text.Trim() != "")
                {
                    // Obtenemos los datos del usuario
                    objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtCip.Text);
                    //Si el usuario no existe
                    if (objUsuarioBE.Cip_usu == null) {
                        MessageBox.Show("El usuario no existe",
                            "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        intentos += 1;
                    }
                    else if (objUsuarioBE.Cip_usu == txtCip.Text.Trim() && objUsuarioBE.Pass_usu == txtPassword.Text.Trim())
                    {
                        //Si las credenciales son correctas
                        this.Hide();
                        timer1.Enabled = false;

                        clsCredenciales.Usuario = objUsuarioBE.Nom_usu + " " + objUsuarioBE.Ape_usu;
                        clsCredenciales.Password = objUsuarioBE.Pass_usu;
                        clsCredenciales.Rol = objUsuarioBE.Rol_usu;

                        Inicio form = new Inicio();
                        form.Show();
                        //form.FormClosing += frm_closing;
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta",
                         "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        intentos += 1;
                    }

                }

                else
                {
                    MessageBox.Show("Usuario o Password obligatorios",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                }

                if (intentos == 3)
                {
                    MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
             
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
           

        }

        private void frm_closing(object sender, FormClosingEventArgs e) {
            txtCip.Text = "";
            txtPassword.Text = "";
            this.Show();    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su email y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
