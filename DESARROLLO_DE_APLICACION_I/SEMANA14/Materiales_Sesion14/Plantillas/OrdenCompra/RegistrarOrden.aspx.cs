using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregar
using System.Data;
using ProyVentas_BE;
using ProyVentas_BL;
using System.Threading;
using System.Globalization;
using System.IO;
namespace SitioVentasWEB_GUI.Transacciones
{
    public partial class RegistrarOrden : System.Web.UI.Page
    {
        DataTable mitb;
        DataColumn Ccodigo;
        DataColumn Cdescripcion;
        DataColumn Ccantidad;
        ProveedorBL objProveedorBL = new ProveedorBL();

        private void CrearTabla()
        {
            mitb = new DataTable("TBCompras");
            //Creando las columnas para la tabla temporal de  detalle de compra
            //Columna Codigo
            DataColumn Ccodigo = new DataColumn("Cod_Pro");
            Ccodigo.DataType = Type.GetType("System.String");
            mitb.Columns.Add(Ccodigo);
            //Columna Descripcion
            DataColumn Cdescripcion = new DataColumn("Des_Pro");
            Cdescripcion.DataType = Type.GetType("System.String");
            mitb.Columns.Add(Cdescripcion);
            //Columna Cantidad
            Ccantidad = new DataColumn("Can_Ped");
            Ccantidad.DataType = Type.GetType("System.Int16");
            mitb.Columns.Add(Ccantidad);
            //definimos la PK
            mitb.PrimaryKey = new DataColumn[] { mitb.Columns["Cod_Pro"] };
            grDetalles.DataSource = mitb;
            grDetalles.DataBind();
            Session["Detalles"] = mitb;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    // Codifique

                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }

        }

        protected void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Codifique

            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
          
        }

        protected void btnGrabarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos el detalle antes de registrarlo en memoria
                if (cboProducto.SelectedValue == "X")
                {
                    throw new Exception("Debe seleccionar un producto");
                }
                if (txtCanPed.Text == "")
                {
                    throw new Exception("Debe ingresar una cantidad");
                }
                // Si todo esta OK casteamos la variable de sesion "Detalles" a DataTable
                mitb = (DataTable)Session["Detalles"];
                //Creamos una fila y la instanciamos como fila de mitb
                DataRow dr;
                dr = mitb.NewRow();
                //Llenamos los campos con lo ingresado en el Popup de detalle
                dr["Cod_Pro"] = cboProducto.SelectedValue.ToString();
                dr["Des_Pro"] = cboProducto.SelectedItem.ToString();
                dr["Can_Ped"] = Convert.ToInt16(txtCanPed.Text);
                //Agregamos la fila a la coleccion de filas de detalle
                mitb.Rows.Add(dr);
                // Lo mostramos en la grilla
                grDetalles.DataSource = mitb;
                grDetalles.DataBind();
            }
            catch (Exception ex)
            {
                lblMensajeDetalle.Text = "Error: " + ex.Message;
                PopDetalle.Show();
            }

        }
        protected void grDetalles_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                // Obtenemos el indice de la fila seleccionada
                int indicefila = Convert.ToInt16(e.CommandArgument);

                // Si se pulso en el boton eliminar , eliminamos el respectivo detalle de OC  de memoria
                if (e.CommandName == "Eliminar")
                {
                    mitb = (DataTable)Session["Detalles"];
                    mitb.Rows.RemoveAt(indicefila);
                    grDetalles.DataSource = mitb;
                    grDetalles.DataBind();
                    Session["Detalles"] = mitb;
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void btnVerGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                mitb = (DataTable)Session["Detalles"];

                // Validamos las fechas...
                if (txtFecOco.Text == "")
                {
                    throw new Exception("Debe ingresar fecha de OC.");
                }

                if (txtFecAte.Text == "")
                {
                    throw new Exception("Debe ingresar fecha de Atencion.");
                }

                if (Convert.ToDateTime(txtFecOco.Text) > Convert.ToDateTime(txtFecAte.Text))
                {
                    throw new Exception("La fecha de orden no puede ser mayor que la de atencion.");

                }
                //Si no hay detalles, no se puede registrar la  orden
                if (mitb.Rows.Count == 0)
                {
                    throw new Exception("No puede registrar una orden sin detalles.");
                }

                // Si todo esta OK mostramos el ModalPopup para el paso final de la generacion de la OC
                lblGrabarOC.Text = "";
                PopOCompra.Show();
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
            
        }

        protected void btnGrabarOC_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique

            }
            catch (Exception ex)
            {
                lblGrabarOC.Text = ex.Message;
                PopOCompra.Show();
            }
        }

        
    }
}
