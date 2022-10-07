using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;
namespace ProyVentas_ADO
{
    public class ProveedorADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
          
        
        // Metodos de mantenimiento
        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            
            try
            {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarProveedor";
            //Agregamos parametros 
                //Codifique
               


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
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            
            try
            {
             cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarProveedor";
            //Agregamos parametros 
                //Codifique
               
              

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

        public Boolean EliminarProveedor(String strcod)
        {
            
            try
            {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarProveedor";
            //Agregamos parametros 
                
           //Codifique
               

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

        public ProveedorBE ConsultarProveedor(String strCod)
        {
            
            try
            {

            ProveedorBE objProveedorBE = new ProveedorBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarProveedor";
            //Agregamos parametros 
                //Codifique
               
                

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

        public DataTable ListarProveedor()
        {
            
            try
            {

                //Codifique
               
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

       

    }
}
