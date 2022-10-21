using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Agregar...
using ProyVentas_BL;
using ProyVentas_BE;
namespace ProyVentas_GUI
{
    public partial class frmConsFacturasCliente : Form
    {
         // Instancias...
        FacturaBL objFacturaBL = new FacturaBL();
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        public frmConsFacturasCliente()
        {
            InitializeComponent();
        }

        private void frmConsFacturasCliente_Load(object sender, EventArgs e)
        {
            try
            {               

                // Desactivamos la generacion de columnas automaticas del datagrid...
                // dtgFacturas.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void btnConsultar_Click(object sender, EventArgs e)
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

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            try
            {
                                
                // Codifique


            }
            catch (Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
