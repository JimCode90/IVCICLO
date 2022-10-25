using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar
using System.Data;
using System.Data.SqlClient;
using ProyGestionDoc_BE;

namespace ProyGestionDoc_ADO
{
    public class TipoGradoADO
    {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarGrado()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarGrados";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Grados");
                return dts.Tables["Grados"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
