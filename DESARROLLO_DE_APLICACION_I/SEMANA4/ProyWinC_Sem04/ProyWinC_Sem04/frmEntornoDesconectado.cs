using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProyWinC_Sem04
{
    public partial class frmEntornoDesconectado : Form
    {
        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection("server=DESKTOP-3V9TI4J;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada;

        public frmEntornoDesconectado()
        {
            InitializeComponent();
        }

        private void frmEntornoDesconectado_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCliente";
                cmd.Parameters.Clear();

                // Configurar el adaptador...
                ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Clientes");

                // Enlazamos el cboClientes al dataTable
                //Agregamos una nueva fila al Datable, para luego insertarla como primera fila
                DataRow dr = dts.Tables["Clientes"].NewRow();
                dr["cod_cli"] = "XX";
                dr["raz_soc_cli"] = "Seleccione...";
                dts.Tables["Clientes"].Rows.InsertAt(dr, 0);


                cboCliente.DataSource = dts.Tables["Clientes"];
                cboCliente.ValueMember = "cod_cli";
                cboCliente.DisplayMember = "raz_soc_cli";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que se seleccione un cliente
                if (cboCliente.SelectedIndex == 0) {
                    throw new Exception("Debe seleccionar un cliente");
                }
                // Codifique
                lblCod1.Text = cboCliente.SelectedValue.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                cmd.Parameters.Clear();

                ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Proveedores");

                //Vinculo el dataGrid al datatable Proveedores
                dtgProveedores.DataSource = dts.Tables["Proveedores"];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
