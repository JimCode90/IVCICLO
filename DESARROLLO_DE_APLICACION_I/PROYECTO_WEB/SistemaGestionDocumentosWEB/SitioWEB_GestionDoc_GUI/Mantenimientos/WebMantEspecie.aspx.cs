using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Agregamos
using ProyGestionDoc_BE;
using ProyGestionDoc_BL;

namespace SitioWEB_GestionDoc_GUI.Mantenimientos
{
    public partial class WebMantEspecie : System.Web.UI.Page
    {
        // Instancias
        EspecieBE objEspecieBE = new EspecieBE();
        EspecieBL objEspecieBL = new EspecieBL();
        TipoEspecieBL objTipoEspecieBL = new TipoEspecieBL();
        DataView dtv;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    CargarDatos("");
                }
            }
            catch (Exception ex)
            {
               lblMensajePopup.Text = "Error Tabla : " + ex.Message;
               PopMensaje.Show();
            }
        }

        private void CargarDatos(String strFiltro)
        {
            // Codifique
            dtv = new DataView(objEspecieBL.ListarEspecie());
            dtv.RowFilter = "Des_espec like '%" + strFiltro + "%'";
            grvEspecies.DataSource = dtv;
            grvEspecies.DataBind();

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje1.Text = String.Empty;
                txtDescripcion1.Text = String.Empty;
                txtMarca1.Text = String.Empty;
                txtModelo1.Text = String.Empty;
                txtColor1.Text = String.Empty;
                txtCantidad1.Text = String.Empty;
                txtNroSerie1.Text = String.Empty;
                chkEstado1.Checked = true;
                //Cargamos los Dropdown
                CargarTipoEspecies(1, "1");
                txtDescripcion1.Focus();
                PopMan01.Show();

            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        private void CargarTipoEspecies(Int16 tipoAccion, String IdEspec)
        {
            if (tipoAccion == 1)
            {
                cboTipoEspecie1.DataSource = objTipoEspecieBL.ListarTipoEspecie();
                cboTipoEspecie1.DataValueField = "Id_tip_espec";
                cboTipoEspecie1.DataTextField = "Opc_espec";
                cboTipoEspecie1.DataBind();
                cboTipoEspecie1.SelectedValue = IdEspec;
            }
            else if (tipoAccion == 2)
            {
                cboTipoEspecie2.DataSource = objTipoEspecieBL.ListarTipoEspecie();
                cboTipoEspecie2.DataValueField = "Id_tip_espec";
                cboTipoEspecie2.DataTextField = "Opc_espec";
                cboTipoEspecie2.DataBind();
                cboTipoEspecie2.SelectedValue = IdEspec;
            }
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text);

            }
            catch (Exception ex)
            {

               lblMensajePopup.Text = ex.Message;
               PopMensaje.Show();
            }
        }

        protected void grvEspecies_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                Int16 fila = Convert.ToInt16(e.CommandArgument);
                if(e.CommandName == "Editar")
                {
                    lblMensaje2.Text = "";
                    //Obtehemos el codigo de la especie seleccionada
                    Int16 strCod = Convert.ToInt16(grvEspecies.Rows[fila].Cells[1].Text);
                    //Obtenemos la instancia del proveedor a actualizar
                    objEspecieBE = objEspecieBL.ConsultarEspecie(strCod);
                    lblCod.Text = objEspecieBE.Id_espec.ToString();
                    txtDescripcion2.Text = objEspecieBE.Des_espec;
                    txtMarca2.Text = objEspecieBE.Mar_espec;
                    txtModelo2.Text = objEspecieBE.Mod_espec;
                    txtColor2.Text = objEspecieBE.Color;
                    txtCantidad2.Text = objEspecieBE.Can_espec.ToString();
                    txtNroSerie2.Text = objEspecieBE.Nro_serie;
                    chkEstado2.Checked = Convert.ToBoolean(objEspecieBE.Est_espec);
                    CargarTipoEspecies(2, Convert.ToString(objEspecieBE.Id_tip_espec));

                    //Mostramos el PopMan02
                    PopMan02.Show();
                }
            }
            catch(Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void grvEspecies_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if(e.Row.RowType == DataControlRowType.DataRow)
                {
                    String estado = e.Row.Cells[8].Text;
                    if(estado == "Inactivo")
                    {
                        e.Row.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }catch(Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void grvEspecies_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvEspecies.PageIndex = e.NewPageIndex;
            CargarDatos(txtFiltro.Text);
        }

        protected void cboTipoEspecie2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboTipoEspecie1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGrabar1_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos

                //Codifique
                objEspecieBE.Des_espec = txtDescripcion1.Text;
                objEspecieBE.Mar_espec = txtMarca1.Text;
                objEspecieBE.Mod_espec = txtModelo1.Text;
                objEspecieBE.Color = txtColor1.Text;
                objEspecieBE.Can_espec = Convert.ToInt16(txtCantidad1.Text);
                objEspecieBE.Nro_serie = txtNroSerie1.Text;
                objEspecieBE.Id_tip_espec = Convert.ToInt16(cboTipoEspecie1.SelectedValue);
                objEspecieBE.Est_espec = Convert.ToInt16(chkEstado1.Checked);
                objEspecieBE.Usu_reg = "31999873";

                if (objEspecieBL.InsertarEspecie(objEspecieBE) == true)
                {

                    CargarDatos(txtFiltro.Text);
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacto con IT");
                }

            }
            catch (Exception ex)
            {
                lblMensaje1.Text = ex.Message;
                PopMan01.Show();// para mantener el popup abierto tras el clic en Grabar1
            }
        }

        protected void btnCerrar1_Click(object sender, EventArgs e)
        {

        }

        protected void btnGrabar2_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos

                //Codifique
                objEspecieBE.Des_espec = txtDescripcion2.Text;
                objEspecieBE.Mar_espec = txtMarca2.Text;
                objEspecieBE.Mod_espec = txtModelo2.Text;
                objEspecieBE.Color = txtColor2.Text;
                objEspecieBE.Can_espec = Convert.ToInt16(txtCantidad2.Text);
                objEspecieBE.Nro_serie = txtNroSerie2.Text;
                objEspecieBE.Id_tip_espec = Convert.ToInt16(cboTipoEspecie2.SelectedValue);
                objEspecieBE.Est_espec = Convert.ToInt16(chkEstado2.Checked);
                objEspecieBE.Usu_reg = "31999873";
                objEspecieBE.Id_espec = Convert.ToInt16(lblCod.Text);

                if (objEspecieBL.ActualizarEspecie(objEspecieBE) == true)
                {

                    CargarDatos(txtFiltro.Text);
                }
                else
                {
                    throw new Exception("No se hizo la actualizacion, contacto con IT");
                }

            }
            catch (Exception ex)
            {
                lblMensaje1.Text = "eRROR: " + ex.Message;
                PopMan01.Show();// para mantener el popup abierto tras el clic en Grabar1
            }
        }

        protected void btnCerrar2_Click(object sender, EventArgs e)
        {

        }
    }
}