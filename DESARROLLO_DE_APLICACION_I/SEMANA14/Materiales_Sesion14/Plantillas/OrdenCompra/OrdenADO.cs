using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;

namespace ProyVentas_ADO
{
   public  class OrdenADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
       
         
       public String RegistrarOrden(OrdenBE objOrdenBE)
       {
           try
           {
               //Codifique
           }
           catch (Exception ex)
           {
               return String.Empty;
           }
           finally
           {
               if (cnx.State == ConnectionState.Open)
               {
                   cnx.Close();
               }
           }

       }
       
       public DataTable ListarOrden()
        {            
            try
            {

                  // Codifique

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
