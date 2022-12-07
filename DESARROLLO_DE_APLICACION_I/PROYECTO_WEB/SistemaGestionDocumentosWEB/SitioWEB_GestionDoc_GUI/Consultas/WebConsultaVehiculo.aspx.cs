using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProyGestionDoc_BL;
using ProyGestionDoc_BE;

namespace SitioWEB_GestionDoc_GUI.Consultas
{
    public partial class WebConsultaVehiculo : System.Web.UI.Page
    {
     
        VehiculoBE objVehiculoBE = new VehiculoBE();
        VehiculoBL objVehiculoBL = new VehiculoBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                objVehiculoBE = objVehiculoBL.ConsultarVehiculoPlaca(txtNroPlaca.Text.Trim());
                //Validamos
                if (objVehiculoBE.Nro_pla == null)
                {
                    txtModelo.Text = String.Empty;
                    txtMarca.Text = String.Empty;
                    txtColor.Text = String.Empty;
                    txtEstado.Text = String.Empty;
                    throw new Exception("El Nro. de placa no existe");
                }
                else
                {
                    txtModelo.Text = objVehiculoBE.Mod_veh;
                    txtMarca.Text = objVehiculoBE.Opc_Mar_veh;
                    txtColor.Text = objVehiculoBE.Color;
                    txtEstado.Text = objVehiculoBE.Estado;
                  
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }
    }
}