using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregamos el paquete para SqlClient
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmDemoConexiones : Form
    {
        //Creamos una instancia de SqlConexion
        SqlConnection cnx = new SqlConnection("server=DESKTOP-3V9TI4J;Database=VentasLeon;Integrated Security=true");

        public frmDemoConexiones()
        {
            InitializeComponent();
        }

        private void btnAbrirConexion_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                MessageBox.Show("Conexion a VentasLeon exitosa!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAbrirConexion.Enabled = false;
                btnCerrarConexion.Enabled = true;
            }
            catch(SqlException ex1)
            {
                MessageBox.Show("Error: " + ex1.Message, "Error");
            }
            catch(Exception ex2)
            {
                MessageBox.Show("Error " + ex2.Message, "Error");
            }
        }

        private void btnCerrarConexion_Click(object sender, EventArgs e)
        {
            cnx.Close();
            MessageBox.Show("Conexion a VentasLeon cerrada exitosamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAbrirConexion.Enabled = true;
            btnCerrarConexion.Enabled = false;
        }
    }
}
