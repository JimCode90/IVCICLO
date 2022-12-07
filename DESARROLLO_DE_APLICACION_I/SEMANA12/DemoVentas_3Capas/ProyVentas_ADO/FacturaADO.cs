using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProyVentas_ADO
{
    public class FacturaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataView dtv;

       /* public DataTable ListarFacturasClienteFechas(String strCodCli, 
                                                              DateTime FecIni, DateTime FecFin)
        {
            
            try
            {
                // Codifique
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en el listado:" + ex.Message);
            }
        }

     */

    }
}
