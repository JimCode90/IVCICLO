using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyVentas_GUI
{
    public partial class frmXMLDemo_02 : Form
    {
      
        public frmXMLDemo_02()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                // Para la lectura del XML lo hacemos con un DataSet...
                DataSet dts = new DataSet();
                dts.ReadXml(@"C:\XML\ListadoProveedores.xml");
                dtgDatos.DataSource = dts.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
