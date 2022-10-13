using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;
namespace ProyVentas_ADO
{
    public  class ProductoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarProducto()
        {
            
            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProducto";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Productos");
                return dts.Tables["Productos"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public ProductoBE ConsultarProducto (String strCodigo)
        {
            
            try
            {
                ProductoBE objProductoBE = new ProductoBE();
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);

                //Abrir la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();


                if(dtr.HasRows == true)
                {
                    dtr.Read();
                    objProductoBE.Cod_pro = dtr["Cod_pro"].ToString();
                    objProductoBE.Des_pro = dtr["Des_pro"].ToString();
                    objProductoBE.Pre_pro = Convert.ToSingle(dtr["Pre_pro"]);
                    objProductoBE.Stk_act = Convert.ToInt16(dtr["Stk_act"]);
                    objProductoBE.Stk_min = Convert.ToInt16(dtr["Stk_min"]);
                    objProductoBE.Id_Cat = Convert.ToInt16(dtr["Id_cat"]);
                    objProductoBE.Id_UM = Convert.ToInt16(dtr["Id_UM"]);
                    objProductoBE.Importado = Convert.ToInt16(dtr["Importado"]);
                    objProductoBE.Est_pro = Convert.ToInt16(dtr["Est_pro"]);

                }

                return objProductoBE;



            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }



        }

        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {
          
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdes", objProductoBE.Des_pro);
                cmd.Parameters.AddWithValue("@vpre", objProductoBE.Pre_pro);
                cmd.Parameters.AddWithValue("@vstka", objProductoBE.Stk_act);
                cmd.Parameters.AddWithValue("@vstkm", objProductoBE.Stk_min);
                cmd.Parameters.AddWithValue("@vId_UM", objProductoBE.Id_UM);
                cmd.Parameters.AddWithValue("@vId_Cat", objProductoBE.Id_Cat);
                cmd.Parameters.AddWithValue("@vimp", objProductoBE.Importado);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objProductoBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vEst_pro", objProductoBE.Est_pro);

                // Abrimos la conexion y la ejecutamos
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public Boolean ActualizarProducto(ProductoBE objProductoBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", objProductoBE.Cod_pro);
                cmd.Parameters.AddWithValue("@vdes", objProductoBE.Des_pro);
                cmd.Parameters.AddWithValue("@vpre", objProductoBE.Pre_pro);
                cmd.Parameters.AddWithValue("@vstka", objProductoBE.Stk_act);
                cmd.Parameters.AddWithValue("@vstkm", objProductoBE.Stk_min);

                cmd.Parameters.AddWithValue("@vId_UM", objProductoBE.Id_UM);
                cmd.Parameters.AddWithValue("@vId_Cat", objProductoBE.Id_Cat);
                cmd.Parameters.AddWithValue("@vimp", objProductoBE.Importado);
                cmd.Parameters.AddWithValue("@vUsu_ult_mod", objProductoBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vEst_pro", objProductoBE.Est_pro);

                // Abrimos la conexion y la ejecutamos
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

        public Boolean EliminarProducto(String strCodigo)
        {
           

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);

                // Abrimos la conexion y la ejecutamos
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
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
