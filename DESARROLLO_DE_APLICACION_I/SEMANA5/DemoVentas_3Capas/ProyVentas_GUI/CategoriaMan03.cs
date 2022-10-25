using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyVentas_BL;
using ProyVentas_BE;
using System.IO; // para el MemoryStream de la foto
namespace ProyVentas_GUI
{
    public partial class CategoriaMan03 : Form
    {
        CategoriaBL objCategoriaBL = new CategoriaBL();
        CategoriaBE objCategoriaBE = new CategoriaBE();
        // Variable para determinar si se a cambiado de foto o no.
        Boolean blnCambio;
        // Array de Bytes para conservar la foto original , por si no se desea cambiarla.
        Byte[] FotoOriginal;
        public CategoriaMan03()
        {
            InitializeComponent();
        }
        // Propiedad para obtener desde el formulario CategoriaMan01 el codigo 
        // de la categoria a actualizar.
        private Int16 _Codigo;
        public Int16 Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }
       private void CategoriaMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Mostramos los datos de la Categoria a actualizar
                objCategoriaBE = objCategoriaBL.ConsultarCategoria(this.Codigo);

                lblCod.Text = objCategoriaBE.Id_Cat.ToString ();
                txtDes.Text = objCategoriaBE.Des_Cat ;

                // Si no tiene foto....
                if (objCategoriaBE .Foto_Cat.Length== 0 )
                {
                    pcbFoto.Image = null;

                }
                else // Pero si tiene foto
                {
                    MemoryStream fotoStream = new MemoryStream(objCategoriaBE.Foto_Cat);
                    pcbFoto.Image = Image.FromStream(fotoStream);
                    // Guardamos la foto original , por si no se hace cambios...
                    FotoOriginal = objCategoriaBE.Foto_Cat;
                }
      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box y la variable blnCambio se pone en true
                // Esta variable permitira saber si se cambio la foto en la categoria.
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                    blnCambio = true;
                }
                else // de lo contrario la variable blnCambio se mantiene en falso
                {
                    blnCambio = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar descripcion
                if (txtDes.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria.");
                }
                // Validamos foto
                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }

                // Pasamos los valores a las propiedades de la instancia...
                objCategoriaBE.Id_Cat = Convert.ToInt16(lblCod.Text);
                objCategoriaBE.Des_Cat = txtDes.Text.Trim();

                // Si cambio la foto...
                if (blnCambio == true)
                {
                    objCategoriaBE.Foto_Cat = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else  //Mantenemos la foto original
                {
                    objCategoriaBE.Foto_Cat = FotoOriginal;
                }
               // Actualizamos....
                if (objCategoriaBL.ActualizarCategoria(objCategoriaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo el registro. Contacte con IT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
