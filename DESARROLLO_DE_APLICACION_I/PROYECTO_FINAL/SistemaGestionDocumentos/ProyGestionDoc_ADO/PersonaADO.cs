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
    public class PersonaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarPersona()
        {
            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarPersonas";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Personas");
                return dts.Tables["Personas"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PersonaBE ConsultarPersona(String strCodigo)
        {

            try
            {
                PersonaBE objPersonaBE = new PersonaBE();
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarPersona";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocumento", strCodigo);

                //Abrir la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();


                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objPersonaBE.Nro_doc = dtr["Nro_doc"].ToString();
                    objPersonaBE.Nom_per = dtr["Nom_per"].ToString();
                    objPersonaBE.Ape_per = dtr["Ape_per"].ToString();
                    objPersonaBE.Edad = Convert.ToDateTime(dtr["Edad"].ToString());
                    objPersonaBE.Dir_per = dtr["Dir_per"].ToString();
                    objPersonaBE.Est_per = Convert.ToInt16(dtr["Est_per"]);
                    objPersonaBE.Doc_ide = Convert.ToInt16(dtr["Doc_ide"]);
                    objPersonaBE.Gen_per = Convert.ToInt16(dtr["Gen_per"]);
                    objPersonaBE.Tip_per = Convert.ToInt16(dtr["Tip_per"]);
                    objPersonaBE.Id_Nac = Convert.ToInt16(dtr["Id_Nac"]);
                    objPersonaBE.Foto = (Byte[]) (dtr["Foto_per"]);
                    objPersonaBE.Usu_reg = dtr["Usu_reg"].ToString();

                }

                return objPersonaBE;



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

        public Boolean InsertarPersona(PersonaBE objPersonaBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarPersona";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocumento", objPersonaBE.Nro_doc);
                cmd.Parameters.AddWithValue("@nombres", objPersonaBE.Nom_per);
                cmd.Parameters.AddWithValue("@apellidos", objPersonaBE.Ape_per);
                cmd.Parameters.AddWithValue("@edad", objPersonaBE.Edad);
                cmd.Parameters.AddWithValue("@direccion", objPersonaBE.Dir_per);
                cmd.Parameters.AddWithValue("@tipoDocumentoIdentidad", objPersonaBE.Doc_ide);
                cmd.Parameters.AddWithValue("@tipoGenero", objPersonaBE.Gen_per);
                cmd.Parameters.AddWithValue("@tipoPersona", objPersonaBE.Tip_per);
                cmd.Parameters.AddWithValue("@idTipoNacionalidad", objPersonaBE.Id_Nac);
                cmd.Parameters.AddWithValue("@foto", objPersonaBE.Foto);
                cmd.Parameters.AddWithValue("@nroCipUsuarioReg", "31999873");
                cmd.Parameters.AddWithValue("@estado", objPersonaBE.Est_per);

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

        public Boolean ActualizarPersona(PersonaBE objPersonaBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarPersona";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocumento", objPersonaBE.Nro_doc);
                cmd.Parameters.AddWithValue("@nombres", objPersonaBE.Nom_per);
                cmd.Parameters.AddWithValue("@apellidos", objPersonaBE.Ape_per);
                cmd.Parameters.AddWithValue("@edad", objPersonaBE.Edad);
                cmd.Parameters.AddWithValue("@direccion", objPersonaBE.Dir_per);
                cmd.Parameters.AddWithValue("@tipoDocumentoIdentidad", objPersonaBE.Doc_ide);
                cmd.Parameters.AddWithValue("@tipoGenero", objPersonaBE.Gen_per);
                cmd.Parameters.AddWithValue("@tipoPersona", objPersonaBE.Tip_per);
                cmd.Parameters.AddWithValue("@idTipoNacionalidad", objPersonaBE.Id_Nac);
                cmd.Parameters.AddWithValue("@foto", objPersonaBE.Foto);
                cmd.Parameters.AddWithValue("@estado", objPersonaBE.Est_per);

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

        public Boolean EliminarPersona(String strCodigo)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarPersona";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocumento", strCodigo);

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
