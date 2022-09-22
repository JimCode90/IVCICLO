using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //Mandamos el mensaje
            MessageBox.Show("Bienvenido(a): " + txtNombre.Text, "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Preguntamos si la tecla pulsada en Enter...
            if (e.KeyChar == 13) {
                //Invocamos al evento Click del boton saludar
                btnSaludar.PerformClick();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Ordenamos el cierre del formulario
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta = MessageBox.Show("Seguro que deseas cerrar el formulario", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No) {
                e.Cancel = true;
            }

        }
    }
}
