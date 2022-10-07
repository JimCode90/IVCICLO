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
    public partial class frmUMedida : Form
    {

        SqlConnection cnx = new SqlConnection("server=DESKTOP-3V9TI4J;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada;
        

        public frmUMedida()
        {
            InitializeComponent();
        }

        private void frmDistritos1_Load(object sender, EventArgs e)
        {
            try
            {
                
                // LLenamos el grid...
                Listar();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
               // Codifique...
               //Validamos
               if(txtNomUM.Text.Trim() == "")
                {
                    throw new Exception("Debe ingresar un nombre para la Unidad de medida");

                }

                // Si todo Ok
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarUM";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdes", txtNomUM.Text.Trim());

                //Abrir la conexion y ejecutar
                cnx.Open();
                cmd.ExecuteNonQuery();
                txtNomUM.Text = "";
                txtNomUM.Focus();

                //Refrescamos la grilla
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();

                }

            }

        }
        private void Listar()
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarUM";
            cmd.Parameters.Clear();

            ada = new SqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            ada.Fill(dts, "Unidades");
            dtgUnidades.DataSource = dts.Tables["Unidades"];

            //Muestro la cantidad de filas
            lblRegistros.Text = dts.Tables["Unidades"].Rows.Count.ToString();
            

        }
    }
}
