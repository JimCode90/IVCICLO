using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.DemoValidaciones
{
    public partial class TestRequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            // Codifique
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            // Codifique
        }

        protected void btnGrabar_Click1(object sender, EventArgs e)
        {
            lblMensaje.Text = "Datos grabados con exito!";
        }

        protected void btnSalir_Click1(object sender, EventArgs e)
        {
            lblMensaje.Text = "Proceso cancelado";
            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;
            TextBox3.Text = String.Empty;
            TextBox4.Text = String.Empty;
            TextBox5.Text = String.Empty;

            TextBox1.Focus();
        }
    }
}