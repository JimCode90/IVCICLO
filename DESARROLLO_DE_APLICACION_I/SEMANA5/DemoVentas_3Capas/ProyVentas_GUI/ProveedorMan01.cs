using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Agregar...
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProveedorMan01 : Form
    {
       
        ProveedorBL objProveedorBL = new ProveedorBL();
        DataView dtv;
       
       
        public ProveedorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            //Construimos el dataview en funcion del DataTable ListarProveedor
            dtv = new DataView(objProveedorBL.ListarProveedor());
            //Filtramos el DataView
            dtv.RowFilter = "raz_soc_prv like '%" + strFiltro + "%'";
            dtgProveedor.DataSource = dtv;
            lblRegistros.Text = dtgProveedor.Rows.Count.ToString();


        }

        private void ProveedorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                CargarDatos(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           try
            {
               //Codifique
               ProveedorMan02 objMan02 = new ProveedorMan02();
                objMan02.ShowDialog();

                //Refresacmos el datagrid
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            try
            {
               //Codifique
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //Codifique
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
