using FontAwesome.Sharp;

namespace ProyGestionDoc_GUI


{
    public partial class Inicio : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario) {

            if (menuActivo != null) { 
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkGreen;


            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuario()); 
        }

        private void menuPersonas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmPersona());
        }

        private void menuVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVehiculo());
        }

        private void menuEspecies_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmEspecie());
        }

        private void contenedor_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == contenedor.VerticalScroll.Maximum - contenedor.VerticalScroll.LargeChange + 1)
            {
                if (e.NewValue != e.OldValue) // Checking when the scrollbar is at bottom and user clicks/scrolls the scrollbar      
                {
                    MessageBox.Show("Test"); // Some operation
                }
            }
        }
    }
}