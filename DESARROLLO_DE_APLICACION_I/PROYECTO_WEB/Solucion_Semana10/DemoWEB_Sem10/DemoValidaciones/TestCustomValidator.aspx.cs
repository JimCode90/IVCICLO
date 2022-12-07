using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.DemoValidaciones
{
    public partial class TestCustomValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {

            // Codifique
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // Codifique
        }
        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // Codifique
        }

        protected void btnValidar_Click1(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            //El codigo de afiliacion debe inicar con a y finalizar con 0
            if(txtCod.Text.StartsWith("A") && txtCod.Text.EndsWith("0"))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid=false;
            }
        }

        protected void CustomValidator2_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            // Validar longotud de numero de documento
            if (txtDNI.Text.Length == 8) { 
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;

            }
        }
    }
}