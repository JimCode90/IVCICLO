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
    public partial class frmVistaPersonal : Form
    {
        public frmVistaPersonal()
        {
            InitializeComponent();
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
                            
                try
                {
                  // Codifique


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
          
      
        private void dtgPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

     
    }
}
