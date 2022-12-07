using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem09
{
    public partial class TestAccesoDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Para validar que este proceso se ejecute solo pa primera vex que se postea el webform

            if(Page.IsPostBack == false)
            {
                try
                {
                    clsConsultas objConsultas = new clsConsultas();
                    String strSQL = "";

                    //llenamos el cbo1
                    strSQL = "SELECT cod_cli, raz_soc_cli FROM tb_Cliente ORDER BY raz_soc_cli";
                    cbo1.DataSource = objConsultas.EjecutaSelect(strSQL);
                    cbo1.DataValueField = "cod_cli";
                    cbo1.DataTextField = "raz_soc_cli";
                    cbo1.DataBind();

                    //llenamos el cbo2
                    strSQL = "SELECT cod_prv, raz_soc_prv FROM tb_Proveedor ORDER BY raz_soc_prv";
                    cbo2.DataSource = objConsultas.EjecutaSelect(strSQL);
                    cbo2.DataValueField = "cod_prv";
                    cbo2.DataTextField = "raz_soc_prv";
                    cbo2.DataBind();

                    //LLenamos el grid view
                    strSQL = "SELECT cod_ven, ape_ven+' '+nom_ven AS ApellNombres, sue_ven, tipo, estado FROM vw_VistaVendedores ORDER BY ape_ven";
                    grvDatos.DataSource = objConsultas.EjecutaSelect(strSQL);
                    grvDatos.DataBind();

                }
                catch (Exception ex)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            lblCod1.Text = cbo1.SelectedValue.ToString();
        }

        protected void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCod2.Text = cbo2.SelectedValue.ToString();
        }
    }
}