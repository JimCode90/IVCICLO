using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem03
{
    public partial class frmFoto : Form
    {
        // Propiedad para asignar desde el formulario frmVistaPersonal el 
        // DNI de la persona seleccionada y se pueda mostrar su foto
        
       public String DNI { get; set; }
       

       public frmFoto()
        {
            InitializeComponent();
        }

        private void frmFoto_Load(object sender, EventArgs e)
        {
            try
            {	
		// Codifique
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message ) ;
            }
        }
    }
}
