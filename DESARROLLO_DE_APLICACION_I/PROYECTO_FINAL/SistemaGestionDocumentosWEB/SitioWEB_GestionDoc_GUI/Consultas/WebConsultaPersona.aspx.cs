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
    public partial class WebConsultaPersona : System.Web.UI.Page
    {
        PersonaBL objPersonaBL = new PersonaBL();
        PersonaBE objPersonaBE = new PersonaBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
              
            }

        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                objPersonaBE = objPersonaBL.ConsultarPersona(txtDni.Text.Trim());
                //Validamos
                if(objPersonaBE.Nro_doc == null)
                {
                    txtNombres.Text = String.Empty;
                    txtApellidos.Text = String.Empty;
                    txtEdad.Text = String.Empty;
                    txtDireccion.Text = String.Empty;
                    txtTipoDocumento.Text = String.Empty;
                    txtGenero.Text = String.Empty;
                    txtTipoPersona.Text = String.Empty;
                    txtNacionalidad.Text = String.Empty;
                    throw new Exception("El Dni de la persona no existe");
                }
                else
                {
                    txtNombres.Text = objPersonaBE.Nom_per;
                    txtApellidos.Text = objPersonaBE.Ape_per;
                    txtEdad.Text = objPersonaBE.Edad_per.ToString();
                    txtDireccion.Text = objPersonaBE.Dir_per;
                    txtTipoDocumento.Text = objPersonaBE.Doc_Identidad;
                    txtGenero.Text = objPersonaBE.Genero;
                    txtTipoPersona.Text = objPersonaBE.Tipo_Persona;
                    txtNacionalidad.Text = objPersonaBE.Opc_Nac;
                    txtEstado.Text = objPersonaBE.Estado;
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