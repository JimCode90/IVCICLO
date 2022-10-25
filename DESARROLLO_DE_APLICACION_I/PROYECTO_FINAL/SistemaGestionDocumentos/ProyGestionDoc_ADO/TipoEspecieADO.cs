using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using System.Data;
using System.Data.SqlClient;
using ProyGestionDoc_BE;

namespace ProyGestionDoc_ADO
{
    public class TipoEspecieADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarTipoEspecie()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarTipoEspecies";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "TipoEspecies");
                return dts.Tables["TipoEspecies"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
