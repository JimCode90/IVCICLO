using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem09
{
    public partial class TestClaseNumero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Double dblFact = 0;
                Double dblValor = 0;
                clsNumero objNumero = new clsNumero();
                dblValor = Convert.ToDouble(txtNumero.Text.Trim());
                dblFact = objNumero.Factorial(dblValor);
                lblFactorial.Text = dblFact.ToString();

                //Determinamos si es primo
                if(objNumero.EsPrimo(dblValor)){
                    lblPrimo.Text = "Si";
                }
                else
                {
                    lblPrimo.Text = "No";
                }

                lblMensaje.ForeColor = System.Drawing.Color.Blue;
                lblMensaje.Text = "Datos calculados con exito";

            }catch(Exception ex)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}