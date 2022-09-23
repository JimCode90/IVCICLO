using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem04
{
    public partial class frmConsultaCliente : Form
    {
       
        public frmConsultaCliente()
        {
            InitializeComponent();
        }
        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection("server=DESKTOP-3V9TI4J;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Codifique
            try
            {

                if (e.KeyChar == 13)
                {
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_ConsultarCliente";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@vcod", txtcod.Text.Trim());

                    //Abrir y ejecutar
                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    //Validamos si la consulta devolvio valores
                    if(dtr.HasRows == true)
                    {
                        //Leemos la fila
                        dtr.Read();
                        //Pintamos Valores
                        lblRaz.Text = dtr["Raz_soc_cli"].ToString();
                        lblDir.Text = dtr["Dir_cli"].ToString();
                        lblTel.Text = dtr["Tel_cli"].ToString();
                        lblRuc.Text = dtr["Ruc_cli"].ToString();
                        lblDeuda.Text = Convert.ToSingle(dtr["Deuda"]).ToString("###,##0.00 soles");
                    }
                    else
                    {
                        lblRaz.Text = "";
                        lblDir.Text = "";
                        lblTel.Text = "";
                        lblRuc.Text = "";
                        lblDeuda.Text = "";

                        throw new Exception("No existe el cliente");
                    }

                    dtr.Close();    

                }


            }catch(SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error");
            }catch(Exception ex1)
            {
                MessageBox.Show("Error SQL: " + ex1.Message, "Error");
            }finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            

        }
    }
}
