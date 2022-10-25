using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregamos
using System.Data;
using System.Data.SqlClient;
using ProyGestionDoc_BE;


namespace ProyGestionDoc_ADO
{
    public class EspecieADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEspecie()
        {
            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEspecies";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Especies");
                return dts.Tables["Especies"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarEspecie(EspecieBE objEspecieBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEspecies";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", objEspecieBE.Des_espec);
                cmd.Parameters.AddWithValue("@marca", objEspecieBE.Mar_espec);
                cmd.Parameters.AddWithValue("@modelo", objEspecieBE.Mod_espec);
                cmd.Parameters.AddWithValue("@color", objEspecieBE.Color);
                cmd.Parameters.AddWithValue("@cantidad", objEspecieBE.Can_espec);
                cmd.Parameters.AddWithValue("@nroSerie", objEspecieBE.Nro_serie);
                cmd.Parameters.AddWithValue("@idTipoEspecie", objEspecieBE.Id_tip_espec);
                cmd.Parameters.AddWithValue("@nroCipUsuarioReg", "31999873");
                cmd.Parameters.AddWithValue("@estado", objEspecieBE.Est_espec);

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

        public Boolean ActualizarEspecie(EspecieBE objEspecieBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEspecies";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEspecie", objEspecieBE.Id_espec);
                cmd.Parameters.AddWithValue("@descripcion", objEspecieBE.Des_espec);
                cmd.Parameters.AddWithValue("@marca", objEspecieBE.Mar_espec);
                cmd.Parameters.AddWithValue("@modelo", objEspecieBE.Mod_espec);
                cmd.Parameters.AddWithValue("@color", objEspecieBE.Color);
                cmd.Parameters.AddWithValue("@cantidad", objEspecieBE.Can_espec);
                cmd.Parameters.AddWithValue("@nroSerie", objEspecieBE.Nro_serie);
                cmd.Parameters.AddWithValue("@idTipoEspecie", objEspecieBE.Id_tip_espec);
                cmd.Parameters.AddWithValue("@estado", objEspecieBE.Est_espec);

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
