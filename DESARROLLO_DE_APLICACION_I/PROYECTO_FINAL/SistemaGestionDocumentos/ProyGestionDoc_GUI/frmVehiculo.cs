using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar...
using ProyGestionDoc_BE;
using ProyGestionDoc_BL;
using ProyGestionDoc_GUI.Utilidades;
using System.Text;

namespace ProyGestionDoc_GUI
{
    public partial class frmVehiculo : Form
    {
        VehiculoBL objVehiculoBL = new VehiculoBL();

        VehiculoBE objVehiculoBE = new VehiculoBE();
        TipoMarcaVehiculoBL objTipoMarcaVehiculoBL = new TipoMarcaVehiculoBL();
        DataView dtv;


        // Variable para determinar si se a cambiado de foto o no.
        Boolean blnCambio;
        // Array de Bytes para conservar la foto original , por si no se desea cambiarla.
        Byte[] FotoOriginal;


        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void btnAbrirPcb_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Imagenes(Solo jpg) |*.jpg";
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbImagen.Image = Image.FromFile(openFileDialog1.FileName);
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

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargamos los combos
                DataTable dt = objTipoMarcaVehiculoBL.ListarMarca();
                DataRow dr;
                dr = dt.NewRow();
                dr["Id_Mar_veh"] = 0;
                dr["Opc_Mar_veh"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboMarca.DataSource = dt;
                cboMarca.DisplayMember = "Opc_Mar_veh";
                cboMarca.ValueMember = "Id_Mar_veh";


                cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "--Seleccione--" });
                cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
                cboEstado.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
                cboEstado.DisplayMember = "Texto";
                cboEstado.ValueMember = "Valor";
                cboEstado.SelectedIndex = 0;

                //Cargamos los combos para el filtro
                foreach (DataGridViewColumn columna in dtgDatos.Columns)
                {
                    if (columna.Visible == true && columna.Name != "btnSeleccionar" && columna.Name != "Foto_veh")
                    {
                        cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                    }
                }

                cboBusqueda.SelectedIndex = 0;
                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";

                //Cargamos los datos al DataGridView
                dtgDatos.AutoGenerateColumns = false;
                CargarDatos("");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarDatos(String strFiltro)
        {
            try
            {
                dtv = new DataView(objVehiculoBL.ListarVehiculo());
                dtgDatos.DataSource = dtv;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtgDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                if (e.ColumnIndex == 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    var w = Properties.Resources.check.Width - 110;
                    var h = Properties.Resources.check.Height - 110;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                    e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            try
            {
                //Validamos...
                validarDatos();

                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objVehiculoBE
                objVehiculoBE.Id_Mar_veh = Convert.ToInt16(cboMarca.SelectedValue);
                objVehiculoBE.Mod_veh = txtModelo.Text;
                objVehiculoBE.Nro_pla = txtPlaca.Text;
                objVehiculoBE.Color = txtColor.Text;
                objVehiculoBE.Est_veh = Convert.ToInt16(((OpcionCombo)cboEstado.SelectedItem).Valor.ToString());
                objVehiculoBE.Foto_veh = File.ReadAllBytes(openFileDialog1.FileName);

                //Invocamos al metodo insertarProducto

                if (objVehiculoBL.InsertarVehiculo(objVehiculoBE) == true)
                {

                    limipiarCampos();
                    blnCambio = false;
                    CargarDatos("");
            
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacto con IT");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void limipiarCampos()
        {
            cboMarca.SelectedIndex = 0;
            txtIdVeh.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtColor.Text = "";
            cboEstado.SelectedIndex = 0;
            pcbImagen.Image.Dispose();
            pcbImagen.Image = null;
        }

        private void validarDatos()
        {


            if (cboMarca.SelectedIndex == 0)
            {
                throw new Exception("La marca es obligatorio");
            }


            if (txtModelo.Text.Trim() == "")
            {
                throw new Exception("El modelo es obligatorios");
            }

            if (txtPlaca.Text.Trim() == "")
            {
                throw new Exception("La placa son obligatorios");
            }

            if (txtColor.Text.Trim() == "")
            {
                throw new Exception("El color es obligatorio");
            }

            if (cboEstado.SelectedIndex == 0)
            {
                throw new Exception("El estado es obligatorio");
            }
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgDatos.Columns[e.ColumnIndex].Name == "btnSeleccionar") {
                int indice = e.RowIndex;
                if (indice >= 0)
                {

                        objVehiculoBE = objVehiculoBL.ConsultarVehiculo(Convert.ToInt16(dtgDatos.Rows[indice].Cells["Id_veh"].Value.ToString()));

                        cboMarca.SelectedIndex = Convert.ToInt16(objVehiculoBE.Id_Mar_veh);

                        foreach (OpcionCombo oc in cboEstado.Items)
                        {
                            if (Convert.ToInt16(oc.Valor) == Convert.ToInt16(objVehiculoBE.Est_veh))
                            {
                                int indice_combo = cboEstado.Items.IndexOf(oc);
                                cboEstado.SelectedIndex = indice_combo;
                            }
                        }

                        txtModelo.Text = objVehiculoBE.Mod_veh.ToString();
                        txtPlaca.Text = objVehiculoBE.Nro_pla.ToString();
                        txtColor.Text = objVehiculoBE.Color.ToString();
                        txtIdVeh.Text = objVehiculoBE.Id_veh.ToString();

                        // Si no tiene foto....
                        if (objVehiculoBE.Foto_veh.Length == 0)
                        {
                            pcbImagen.Image = null;

                        }
                        else // Pero si tiene foto
                        {
                            MemoryStream fotoStream = new MemoryStream(objVehiculoBE.Foto_veh);
                            pcbImagen.Image = Image.FromStream(fotoStream);
                            // Guardamos la foto original , por si no se hace cambios...
                            FotoOriginal = objVehiculoBE.Foto_veh;
                        }

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos...
                validarDatos();

                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objVehiculoBE
                objVehiculoBE.Id_veh = Convert.ToInt16(txtIdVeh.Text);
                objVehiculoBE.Id_Mar_veh = Convert.ToInt16(cboMarca.SelectedValue);
                objVehiculoBE.Mod_veh = txtModelo.Text;
                objVehiculoBE.Nro_pla = txtPlaca.Text;
                objVehiculoBE.Color = txtColor.Text;
                objVehiculoBE.Est_veh = Convert.ToInt16(((OpcionCombo)cboEstado.SelectedItem).Valor.ToString());
            

                if (blnCambio == true)
                {
                    objVehiculoBE.Foto_veh = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else  //Mantenemos la foto original
                {
                    objVehiculoBE.Foto_veh = FotoOriginal;
                }

                //Actualizamos

                if (objVehiculoBL.ActualizarVehiculo(objVehiculoBE) == true)
                {

                    limipiarCampos();
                    CargarDatos("");
                    blnCambio = false;
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacto con IT");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult vrpta;
                vrpta = MessageBox.Show("¿Desea eliminar el vehiculo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(vrpta == DialogResult.Yes)
                {
                   
                    if (objVehiculoBL.EliminarVehiculo(Convert.ToInt16(txtIdVeh.Text)) == true)
                    {

                        limipiarCampos();
                        CargarDatos("");
                       
                    }
                    else
                    {
                        throw new Exception("No se elimino el registro, contacto con IT");
                    }
                }
                else
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                String columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
                dtgDatos.CurrentCell = null;
                if (dtgDatos.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dtgDatos.Rows)
                    {
                        if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Text = "";
                foreach (DataGridViewRow row in dtgDatos.Rows)
                {
                    row.Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
