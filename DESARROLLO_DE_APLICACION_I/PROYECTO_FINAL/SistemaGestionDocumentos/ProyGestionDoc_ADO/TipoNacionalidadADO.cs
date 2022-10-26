using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGestionDoc_ADO
{
    public class TipoNacionalidadADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        public DataTable ListarNacionalidad()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Nacionalidades";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Nacionalidades");
                return dts.Tables["Nacionalidades"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
