using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem03
{
    public partial class frmVisorImagenes : Form
    {
        public frmVisorImagenes()
        {
            InitializeComponent();
        }

        private void frmVisorImagenes_Load(object sender, EventArgs e)
        {
           

        }

        private void bttnFile_Click(object sender, EventArgs e)
        {
            // establecemos propiedades del openfiledialog
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Text Files (" + txtFiltro.Text + ")|" + txtFiltro.Text; // Alt + 124 |
            openFileDialog1.ShowDialog();

            // Llenar Lista con los nombres de archivos seleccionados en el OpenFileDialog
             foreach (string str in openFileDialog1.FileNames)
            {
                ListBox1.Items.Add(str);
            }

        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pcbFoto.Image = Image.FromFile(ListBox1.SelectedItem.ToString ());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede mostrar el archivo." + ex.Message ,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pcbFoto.Image = null;
            }

        }

     
    }
}
