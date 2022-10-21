using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; // Para emplear la clase StringWriter
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class frmXMLDemo_01 : Form
    {
        FacturaBL objFacturaBL = new FacturaBL();
        ProveedorBL objProveedorBL = new ProveedorBL();
        DataTable dtb = new DataTable();
        StringWriter obj1XML = new StringWriter();

        public frmXMLDemo_01()
        {
            InitializeComponent();
        }

        private void btnGenerarXMLProveedores_Click(object sender, EventArgs e)
        {
            try
            {
               // Codifique
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGenerarXMLFacturacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnConsumirXML_Click(object sender, EventArgs e)
        {
            frmXMLDemo_02 frmxml02 = new frmXMLDemo_02();
            frmxml02.ShowDialog();
        }

    
    }
}