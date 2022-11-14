using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.PasandoDatos
{
    public partial class Origen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar1_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos una variable con la URL y los parametros a enviar...
                String strURL = "Destino1.aspx?CP1=" + txtNombre.Text + "&CP2=" + txtApellido.Text;
                Response.Redirect(strURL);
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnEnviar2_Click(object sender, EventArgs e)
        {
            try
            {
                // Enviamos los datos en variables de sesión...
                Session["Nombre"] = txtNombre.Text.Trim();
                Session["Apellido"] = txtApellido.Text.Trim();

                Response.Redirect("Destino2.aspx");
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}