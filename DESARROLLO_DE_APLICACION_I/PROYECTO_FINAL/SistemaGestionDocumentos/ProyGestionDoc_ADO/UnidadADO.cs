using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using ProyGestionDoc_BE;


namespace ProyGestionDoc_ADO
{
    public class UnidadADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarUnidad()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarUnidades";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Unidades");
                return dts.Tables["Unidades"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
