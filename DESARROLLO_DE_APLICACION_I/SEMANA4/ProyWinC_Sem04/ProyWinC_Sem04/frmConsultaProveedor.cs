using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Importamos las clases de acceso a SQL Server
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmConsultaProveedor : Form
    {

        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection("server=DESKTOP-3V9TI4J;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public frmConsultaProveedor()
        {
            InitializeComponent();
        }
        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Codifique
            try
            {
                if (e.KeyChar == 13)
                {

                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_ConsultarProveedor";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@vcod", txtcod.Text.Trim());
                    //Abrimos la conexion y ejecutamos...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    //Validamos si la consulta devolvio valores...
                    if (dtr.HasRows == true)
                    {
                        //Leemos los resultados de la fila...
                        dtr.Read();
                        //Pintamos Valores del proveedor...
                        lblRaz.Text = dtr["Raz_soc_prv"].ToString();
                        lblDir.Text = dtr["Dir_prv"].ToString();
                        lblDepartamento.Text = dtr["Departamento"].ToString();
                        lblProvincia.Text = dtr["Provincia"].ToString();
                        lblDistrito.Text = dtr["Distrito"].ToString();
                        lblTel.Text = dtr["Tel_prv"].ToString();
                        lblRepVen.Text = dtr["Rep_ven"].ToString();
                        //Cerramos el DataReader de la consulta de datos de proveedor, para ejecutar la siguiente consulta.
                        dtr.Close();


                        //Preparamos la configuración para realizar la siguiente consulta.
                        cmd.CommandText = "usp_ConsultarProductosProveedor";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@cod_prv", txtcod.Text.Trim());
                        dtr = cmd.ExecuteReader();

                        //Limpiamos el listView de productos
                        lstProductos.Items.Clear();
                        while (dtr.Read() == true)
                        {
                            //Mostramos los productos en el listView de productos
                            lstProductos.Items.Add(dtr["des_pro"].ToString() + " - " + Convert.ToSingle(dtr["pre_aba"]).ToString("###,##0.00 soles"));
                        }
                       
                    }
                    else
                    {
                        //Limpiamos los datos del proveedor
                        lblRaz.Text = "";
                        lblDir.Text = "";
                        lblDepartamento.Text = "";
                        lblProvincia.Text = "";
                        lblDistrito.Text = "";
                        lblTel.Text = "";
                        lblRepVen.Text = "";
                        //Limpiamos el contenido del listView de Productos
                        lstProductos.Items.Clear();

                        throw new Exception("El código ingresado no esta asociado a un proveedor");
                    }

                    dtr.Close();


                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

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
