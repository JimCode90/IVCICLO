using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar...
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;

namespace ProyVentas_ADO
{
  public   class CategoriaADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        public Boolean InsertarCategoria(CategoriaBE objCategoriaBE)
        {           
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCategoria";
                //Agregamos parametros 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Des_Cat", objCategoriaBE.Des_Cat);
                cmd.Parameters.AddWithValue("@Foto_Cat", objCategoriaBE.Foto_Cat);
                
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

        public Boolean ActualizarCategoria(CategoriaBE objCategoriaBE)
        {
            
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCategoria";
                //Agregamos parametros 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Cat", objCategoriaBE.Id_Cat);
                cmd.Parameters.AddWithValue("@Des_Cat", objCategoriaBE.Des_Cat);
                cmd.Parameters.AddWithValue("@Foto_Cat", objCategoriaBE.Foto_Cat);
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

        public Boolean EliminarCategoria(Int16 strCod)
        {
            

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarCategoria";
                //Agregamos parametros 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Cat", strCod);
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

        public CategoriaBE ConsultarCategoria(Int16 strCod)
        {
         
            try
            {
                CategoriaBE objCategoriaBE = new CategoriaBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCategoria";
                // Agregamos el parametro...
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Cat", strCod);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objCategoriaBE.Id_Cat = Convert.ToInt16( dtr["Id_Cat"]);
                    objCategoriaBE.Des_Cat = dtr["Des_Cat"].ToString();
                    // Convertimos la imagen a mapa de bytes y lo cargamos a la propiedad Foto de la entidad de negocios
                    objCategoriaBE.Foto_Cat = (Byte[])( dtr["Foto_Cat"]);
                  
                }
                dtr.Close();
                return objCategoriaBE;
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
        public DataTable ListarCategoria()
        {            
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCategoria";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Categorias");
                return dts.Tables["Categorias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

    }
}
