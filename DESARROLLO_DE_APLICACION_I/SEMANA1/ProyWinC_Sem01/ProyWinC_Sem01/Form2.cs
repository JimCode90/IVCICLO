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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //Validamos ...
            if (lstPaises.Items.Contains(txtPais.Text.Trim()) == true | txtPais.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Elemento repetido o en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPais.SelectAll();
            }
            else 
            {
                //Agregamos el texto del txtPais a la lista
                lstPaises.Items.Add(txtPais.Text.Trim());
                txtPais.Clear();
            }

            //Enviamos el cursor al txtPais
            txtPais.Focus();
            
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            //Preguntamos si es Scape la tecla pulsada
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
