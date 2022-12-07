
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para los objetos DataTable, DataRow y DataView
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProductoMan01 : Form
    {
        // Instancias
        ProductoBL objProductoBL = new ProductoBL();
        DataView dtv;

        public ProductoMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
        
            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            //  e invocamos al metodo CargarDatos pasandole una cadena vacia ,
            //  lo cual hara que se muestren todos los proveedores por defecto al momento de cargar el formulario

            dtv = new DataView(objProductoBL.ListarProducto());
            dtv.RowFilter = "des_pro like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                ProductoMan02 objMan02 = new ProductoMan02();
                objMan02.ShowDialog(); //Carga el formulario de manera modal

                //Refresacamos el DataGrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                ProductoMan03 objMan03 = new ProductoMan03();
                //Asignamos el codigo del producto seleccionado en el datagrid
                objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();

                //Abrimos el formulario de actualizacion
                objMan03.ShowDialog();

                //Refrescamos el Datagrid
                CargarDatos(txtFiltro.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
    }
}
