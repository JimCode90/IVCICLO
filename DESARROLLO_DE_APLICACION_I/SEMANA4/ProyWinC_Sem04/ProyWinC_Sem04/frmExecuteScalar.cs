using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;


namespace ProyWinC_Sem04
{
    public partial class frmExecuteScalar : Form
    {
        //Creamos las intacias
        SqlConnection cnx = new SqlConnection("server=DESKTOP-3V9TI4J;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();


        public frmExecuteScalar()
        {
            InitializeComponent();
        }

        private void btnObtenerMaxinoPrecio_Click(object sender, EventArgs e)
        {
            try
            {

                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_MaximoPrecioProducto";

                //Abrimos la conexion y ejecutamos
                cnx.Open();
                Single sngMaximo = Convert.ToSingle(cmd.ExecuteScalar());
                MessageBox.Show("El precio maximo del producto es: " + sngMaximo.ToString("##,##0.00"), "Mensaje");

            }catch(SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Error");
            }
            finally
            {
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        private void btnObtenerVentaAnual_Click(object sender, EventArgs e)
        {
            try
            {

                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_VentaAnual";
                //Manejos los parámetros
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@año", mskAño.Text);


                //Abrimos la conexion y ejecutamos
                cnx.Open();
                Single sngVentaAnual = Convert.ToSingle(cmd.ExecuteScalar());
                MessageBox.Show("Las Ventas en el año " +mskAño.Text + " fueron: " + sngVentaAnual.ToString("##,###.##0.00"), "Mensaje");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Error");
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
