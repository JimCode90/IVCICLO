using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Importante para el empleo de DataSet y DataTable
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Para el empleo de clases que manejan archivos y directorios.

namespace ProyWinC_Sem03
{
    public partial class frmRegistroPersonal : Form
    {
        // Creamos las instancias de DataSet y DataTable
        DataSet dts = new DataSet();
        DataTable tabla = new DataTable();

        // Variables para las columnas y las filas
        DataColumn column;
        DataRow row;

        
        public frmRegistroPersonal()
        {
            InitializeComponent();
        }

        private void frmRegistroPersonal_Load(object sender, EventArgs e)
        {
            try
            {
		 // Se invoca al procedimiento CrearTabla, para construir un DataTable en memoria
                CrearTabla();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void CrearTabla()
        {
            // Codifique...

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

   
        private void Limpiar()
        {
            // Recorremos las cajas de texto del formulario actual y las limpiamos.
            foreach (Control c in this.Controls)
            {
                if (c is TextBox | c is MaskedTextBox)
                {
                    c.Text = String.Empty;
                }
               
            }
            // Ademas limpiamos el picturebox de la foto, el label con la ruta de la misma
            // y colocamos la fecha actual en el dateTimePicker
            lblRuta.Text = String.Empty;
            pcbFoto.Image = null;
            dtpFechaReg.Value = DateTime.Now.Date;

            // Enviamos el enfoque a la maskedTextBox del DNI
            mskDNI.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
