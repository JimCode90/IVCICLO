﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos
using System.Data;
using System.Data.SqlClient;

using ProyGestionDoc_BE;


namespace ProyGestionDoc_ADO
{
    
    public class VehiculoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarVehiculo()
        {
            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarVehiculos";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Vehiculos");
                return dts.Tables["Vehiculos"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarVehiculo(VehiculoBE objVehiculoBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarVehiculo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@modelo", objVehiculoBE.Mod_veh);
                cmd.Parameters.AddWithValue("@nroPlaca", objVehiculoBE.Nro_pla);
                cmd.Parameters.AddWithValue("@color", objVehiculoBE.Color);
                cmd.Parameters.AddWithValue("@idTipoMarcaVehiculo", objVehiculoBE.Id_Mar_veh);
                cmd.Parameters.AddWithValue("@foto", objVehiculoBE.Foto_veh);
                cmd.Parameters.AddWithValue("@nroCipUsuarioReg", "31999873");
                cmd.Parameters.AddWithValue("@estado", objVehiculoBE.Est_veh);
   
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

        public Boolean ActualizarVehiculo(VehiculoBE objVehiculoBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarVehiculo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idVehiculo", objVehiculoBE.Id_veh);
                cmd.Parameters.AddWithValue("@modelo", objVehiculoBE.Mod_veh);
                cmd.Parameters.AddWithValue("@nroPlaca", objVehiculoBE.Nro_pla);
                cmd.Parameters.AddWithValue("@color", objVehiculoBE.Color);
                cmd.Parameters.AddWithValue("@idTipoMarcaVehiculo", objVehiculoBE.Id_Mar_veh);
                cmd.Parameters.AddWithValue("@foto", objVehiculoBE.Foto_veh);
                cmd.Parameters.AddWithValue("@estado", objVehiculoBE.Est_veh);
                // TODO: Falta agregar ultimo usuario que actualiza

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
