using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.DemoValidaciones
{
    public partial class TestRangeValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las variables....
                Int16 n1 = 0;
                Int16 n2 = 0;
                Int16 n3 = 0;
                // Leemos los valores desde los textbox....
                n1 = Convert.ToInt16(txtN1.Text);
                n2 = Convert.ToInt16(txtN2.Text);

                if (txtN3.Text.Trim() == "")
                {
                    n3 = 0;
                }
                else
                {
                    n3 = Convert.ToInt16(txtN3.Text);
                }
                // Calculamos ....
                Single prom = (n1 + n2 + n3) / 3;
                lblPromedio.Text = prom.ToString("#0.00");
                // Manejamos colores para indicar status
                if (prom >= 13)
                {
                    lblPromedio.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    lblPromedio.ForeColor = System.Drawing.Color.Red;

                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}