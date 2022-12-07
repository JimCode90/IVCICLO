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
    public class UsuarioADO
    {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarUsuario()
        {
            try {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarUsuarios";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Usuarios");
                return dts.Tables["Usuarios"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

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
                cmd.Parameters.AddWithValue("@nroCip", strCodigo);

                //Abrir la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();


                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioBE.Cip_usu = dtr["Cip_usu"].ToString();
                    objUsuarioBE.Pass_usu = dtr["Pass_usu"].ToString();
                    objUsuarioBE.Dni_usu = dtr["Dni_usu"].ToString();
                    objUsuarioBE.Nom_usu = dtr["Nom_usu"].ToString();
                    objUsuarioBE.Ape_usu = dtr["Ape_usu"].ToString();
                    objUsuarioBE.Email_usu = dtr["Email_usu"].ToString();
                    objUsuarioBE.Tel_usu = dtr["Tel_usu"].ToString();
                    objUsuarioBE.Est_usu = Convert.ToInt16(dtr["Est_usu"]);
                    objUsuarioBE.Rol_usu = Convert.ToInt16(dtr["Rol_usu"]);
                    objUsuarioBE.Id_Gra = Convert.ToInt16(dtr["Id_Gra"]);
                    objUsuarioBE.Id_Uni = Convert.ToInt16(dtr["Id_Uni"]);
                    
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


        public Boolean InsertarUsuario(UsuarioBE objUsuarioBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroCip", objUsuarioBE.Cip_usu);
                cmd.Parameters.AddWithValue("@Password", objUsuarioBE.Pass_usu);
                cmd.Parameters.AddWithValue("@nroDni", objUsuarioBE.Dni_usu);
                cmd.Parameters.AddWithValue("@nombres", objUsuarioBE.Nom_usu);
                cmd.Parameters.AddWithValue("@apellidos", objUsuarioBE.Ape_usu);
                cmd.Parameters.AddWithValue("@email", objUsuarioBE.Email_usu);
                cmd.Parameters.AddWithValue("@telefono", objUsuarioBE.Tel_usu);
                cmd.Parameters.AddWithValue("@estado", objUsuarioBE.Est_usu);
                cmd.Parameters.AddWithValue("@rol", objUsuarioBE.Rol_usu);
                cmd.Parameters.AddWithValue("@idTipoGrado", objUsuarioBE.Id_Gra);
                cmd.Parameters.AddWithValue("@idUnidad", objUsuarioBE.Id_Uni);
               

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

        //ActualizarUsuario
        public Boolean ActualizarUsuario(UsuarioBE objUsuarioBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroCip", objUsuarioBE.Cip_usu);
                cmd.Parameters.AddWithValue("@Password", objUsuarioBE.Pass_usu);
                cmd.Parameters.AddWithValue("@nroDni", objUsuarioBE.Dni_usu);
                cmd.Parameters.AddWithValue("@nombres", objUsuarioBE.Nom_usu);
                cmd.Parameters.AddWithValue("@apellidos", objUsuarioBE.Ape_usu);
                cmd.Parameters.AddWithValue("@email", objUsuarioBE.Email_usu);
                cmd.Parameters.AddWithValue("@telefono", objUsuarioBE.Tel_usu);
                cmd.Parameters.AddWithValue("@estado", objUsuarioBE.Est_usu);
                cmd.Parameters.AddWithValue("@rol", objUsuarioBE.Rol_usu);
                cmd.Parameters.AddWithValue("@idTipoGrado", objUsuarioBE.Id_Gra);
                cmd.Parameters.AddWithValue("@idUnidad", objUsuarioBE.Id_Uni);


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

        public Boolean EliminarUsuario(String strCodigo)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroCip", strCodigo);

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
