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
    public partial class frmExecuteReader : Form
    {

        //Creamos las intacias
        SqlConnection cnx = new SqlConnection("server=DESKTOP-3V9TI4J;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public frmExecuteReader()
        {
            InitializeComponent();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProducto";
                cmd.Parameters.Clear();
                //Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                //Consumimos el dtr....
                lstProductos.Items.Clear(); 
                while (dtr.Read() == true)
                {
                    lstProductos.Items.Add(dtr["Des_pro"].ToString());
                }

                dtr.Close();

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                cmd.Parameters.Clear();
                //Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                //Consumimos el dtr....
                lstProveedores.Items.Clear();
                while (dtr.Read() == true)
                {
                    lstProveedores.Items.Add(dtr["Raz_soc_prv"].ToString() + " - " + dtr["Dir_prv"].ToString());
                }

                dtr.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
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
