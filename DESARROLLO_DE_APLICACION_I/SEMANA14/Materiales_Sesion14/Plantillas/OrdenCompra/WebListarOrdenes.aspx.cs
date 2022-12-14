using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregar
using ProyVentas_BL;
using System.IO;

namespace SitioVentasWEB_GUI.Transacciones
{
    public partial class WebListarOrdenes : System.Web.UI.Page
    {
        OrdenBL objOrdenBL = new OrdenBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();

            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }

        }
        private void CargarDatos()
        {
            grvOC.DataSource = objOrdenBL.ListarOrden();
            grvOC.DataBind();
        }

        protected void grvOC_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvOC.PageIndex = e.NewPageIndex;
            CargarDatos();
        }

        protected void grvOC_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                // Codifique

            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }
    }
}