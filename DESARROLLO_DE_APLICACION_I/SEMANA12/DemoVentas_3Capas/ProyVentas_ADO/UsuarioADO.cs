using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;

namespace ProyVentas_ADO
{
    public class UsuarioADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioBE ConsultarUsuario(String strCodigo)
        {
            try
            {
                UsuarioBE objUsuarioBE = new UsuarioBE();
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Login_Usuario", strCodigo);

                //Abrir la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();


                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioBE.Niv_Usuario = Convert.ToInt16(dtr["Niv_Usuario"].ToString());
                    objUsuarioBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"].ToString());
                    objUsuarioBE.Usu_Registro = dtr["Usu_Registro"].ToString();
                   

                }

                return objUsuarioBE;

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

    }
}
