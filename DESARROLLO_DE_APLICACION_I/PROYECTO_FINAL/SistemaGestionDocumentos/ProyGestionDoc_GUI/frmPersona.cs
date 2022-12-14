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


namespace ProyGestionDoc_GUI
{
    public partial class frmPersona : Form
    {
        PersonaBL objPersonaBL = new PersonaBL();
        PersonaBE objPersonaBE = new PersonaBE();
        TipoNacionalidadBL objTipoNacionalidadBL = new TipoNacionalidadBL();
        DataView dtv;

        // Variable para determinar si se a cambiado de foto o no.
        Boolean blnCambio;
        // Array de Bytes para conservar la foto original , por si no se desea cambiarla.
        Byte[] FotoOriginal;

        public frmPersona()
        {
            InitializeComponent();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargamos los combos
                DataTable dt = objTipoNacionalidadBL.ListarNacionalidad();
                DataRow dr;
                dr = dt.NewRow();
                dr["Id_Nac"] = 0;
                dr["Opc_Nac"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboNacPersona.DataSource = dt;
                cboNacPersona.DisplayMember = "Opc_Nac";
                cboNacPersona.ValueMember = "Id_Nac";

                cboEstadoPersona.Items.Add(new OpcionCombo() { Valor = 0, Texto = "--Seleccione--" });
                cboEstadoPersona.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
                cboEstadoPersona.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
                cboEstadoPersona.DisplayMember = "Texto";
                cboEstadoPersona.ValueMember = "Valor";
                cboEstadoPersona.SelectedIndex = 0;

                cboTipoDocPersona.Items.Add(new OpcionCombo() { Valor = 0, Texto = "--Seleccione--" });
                cboTipoDocPersona.Items.Add(new OpcionCombo() { Valor = 1, Texto = "DNI" });
                cboTipoDocPersona.Items.Add(new OpcionCombo() { Valor = 2, Texto = "CÉDULA" });
                cboTipoDocPersona.Items.Add(new OpcionCombo() { Valor = 3, Texto = "PASAPORTE" });
                cboTipoDocPersona.Items.Add(new OpcionCombo() { Valor = 4, Texto = "OTROS" });
                cboTipoDocPersona.DisplayMember = "Texto";
                cboTipoDocPersona.ValueMember = "Valor";
                cboTipoDocPersona.SelectedIndex = 0;

                cboGeneroPersona.Items.Add(new OpcionCombo() { Valor = 0, Texto = "--Seleccione--" });
                cboGeneroPersona.Items.Add(new OpcionCombo() { Valor = 1, Texto = "MASCULINO" });
                cboGeneroPersona.Items.Add(new OpcionCombo() { Valor = 2, Texto = "FEMENINO" });
                cboGeneroPersona.Items.Add(new OpcionCombo() { Valor = 3, Texto = "OTROS" });
                cboGeneroPersona.DisplayMember = "Texto";
                cboGeneroPersona.ValueMember = "Valor";
                cboGeneroPersona.SelectedIndex = 0;

                cboTipoPersona.Items.Add(new OpcionCombo() { Valor = 0, Texto = "--Seleccione--" });
                cboTipoPersona.Items.Add(new OpcionCombo() { Valor = 1, Texto = "PERUANO" });
                cboTipoPersona.Items.Add(new OpcionCombo() { Valor = 2, Texto = "EXTRANJERO" });
                cboTipoPersona.DisplayMember = "Texto";
                cboTipoPersona.ValueMember = "Valor";
                cboTipoPersona.SelectedIndex = 0;

                //Cargamos El filtro combobox de filtro
                foreach (DataGridViewColumn columna in dtgDatos.Columns)
                {
                    if (columna.Visible == true && columna.Name != "btnSeleccionar" && columna.Name != "Foto_per")
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

        private void btnAbrirPcb_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogPersona.Multiselect = false;
                openFileDialogPersona.FileName = "";
                openFileDialogPersona.Filter = "Imagenes(Solo jpg) |*.jpg";
                openFileDialogPersona.ShowDialog();
                if (openFileDialogPersona.FileName != String.Empty)
                {
                    pcbImagenPersona.Image = Image.FromFile(openFileDialogPersona.FileName);
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos...
                validarDatos();
                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objPersonaBE
                objPersonaBE.Nro_doc = txtNroDocPersona.Text;
                objPersonaBE.Nom_per = txtNomPersona.Text;
                objPersonaBE.Ape_per = txtApePersona.Text;
                objPersonaBE.Edad = Convert.ToDateTime(dtpEdadPersona.Value.Date.ToString("yyyy-MM-dd"));
                objPersonaBE.Dir_per = txtDireccPersona.Text;
                objPersonaBE.Id_Nac = Convert.ToInt16(cboNacPersona.SelectedValue);
                objPersonaBE.Est_per = Convert.ToInt16(((OpcionCombo)cboEstadoPersona.SelectedItem).Valor.ToString());
                objPersonaBE.Gen_per = Convert.ToInt16(((OpcionCombo)cboGeneroPersona.SelectedItem).Valor.ToString());

                objPersonaBE.Tip_per = Convert.ToInt16(((OpcionCombo)cboTipoPersona.SelectedItem).Valor.ToString());
              
                objPersonaBE.Doc_ide = Convert.ToInt16(((OpcionCombo)cboTipoDocPersona.SelectedItem).Valor.ToString());
                objPersonaBE.Foto = File.ReadAllBytes(openFileDialogPersona.FileName);
                objPersonaBE.Usu_reg = clsCredenciales.Password;
                //Invocamos al metodo InsertarPersona

                if (objPersonaBL.InsertarPersona(objPersonaBE) == true)
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

        private void CargarDatos(String strFiltro)
        {
            try
            {
                dtv = new DataView(objPersonaBL.ListarPersona());
                dtgDatos.DataSource = dtv;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void limipiarCampos()
        {
            txtNroDocPersona.Text = "";
            txtNomPersona.Text = "";
            txtApePersona.Text = "";
            //txtEdadPersona.Text = "";
            dtpEdadPersona.Value = DateTime.Now;
            txtDireccPersona.Text = "";
            txtNroDocPersona.Text = "";

            cboTipoDocPersona.SelectedIndex = 0;
            cboGeneroPersona.SelectedIndex = 0;
            cboNacPersona.SelectedIndex = 0;
            cboTipoPersona.SelectedIndex = 0;
            cboEstadoPersona.SelectedIndex = 0;

            pcbImagenPersona.Image.Dispose();
            pcbImagenPersona.Image = null;
        }
        private void validarDatos() {

            if (cboTipoDocPersona.SelectedIndex == 0)
            {
                throw new Exception("El tipo de documento es obligatorio");
            }
            if (txtNroDocPersona.Text.Trim() == "")
            {
                throw new Exception("El nro. documento es obligatorios");
            }
            if (txtNomPersona.Text.Trim() == "")
            {
                throw new Exception("Los nombres es obligatorios");
            }
            if (txtApePersona.Text.Trim() == "")
            {
                throw new Exception("Los apellidos es obligatorios");
            }
            /*if (txtEdadPersona.Text.Trim() == "")
            {
                throw new Exception("La edad es obligatorio");
            }*/
            if (txtDireccPersona.Text.Trim() == "")
            {
                throw new Exception("La dirección es obligatorio");
            }


            if (cboGeneroPersona.SelectedIndex == 0)
            {
                throw new Exception("El gñenero es obligatorio");
            }

            if (cboTipoPersona.SelectedIndex == 0)
            {
                throw new Exception("El tipo  de persona es obligatorio");
            }

            if (cboNacPersona.SelectedIndex == 0)
            {
                throw new Exception("La nacionalidad es obligatorio");
            }
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dtgDatos.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    int indice = e.RowIndex;
                    if (indice >= 0)
                    {
                        objPersonaBE = objPersonaBL.ConsultarPersona(dtgDatos.Rows[indice].Cells["Nro_doc"].Value.ToString());

                        txtNomPersona.Text = objPersonaBE.Nom_per.ToString();
                        txtApePersona.Text = objPersonaBE.Ape_per.ToString();
                        txtNroDocPersona.Text = objPersonaBE.Nro_doc.ToString();
                        //Bloqueamos el campo del nro de doc.
                        txtNroDocPersona.ReadOnly = true;
                        txtDireccPersona.Text = objPersonaBE.Dir_per.ToString();
                        //dtpEdadPersona.Value = Convert.ToDateTime(objPersonaBE.Edad.ToString());
                        dtpEdadPersona.Value = Convert.ToDateTime(objPersonaBE.Edad.ToString());
                 
                        cboNacPersona.SelectedIndex = Convert.ToInt16(objPersonaBE.Id_Nac.ToString());

                        foreach (OpcionCombo oc in cboGeneroPersona.Items)
                        {
                            if (Convert.ToInt16(oc.Valor) == Convert.ToInt16(objPersonaBE.Gen_per.ToString()))
                            {
                                int indice_combo = cboGeneroPersona.Items.IndexOf(oc);
                                cboGeneroPersona.SelectedIndex = indice_combo;
                            }
                        }

                        foreach (OpcionCombo oc in cboTipoDocPersona.Items)
                        {
                            if (Convert.ToInt16(oc.Valor) == Convert.ToInt16(objPersonaBE.Doc_ide.ToString()))
                            {
                                int indice_combo = cboTipoDocPersona.Items.IndexOf(oc);
                                cboTipoDocPersona.SelectedIndex = indice_combo;
                            }
                        }

                        foreach (OpcionCombo oc in cboTipoPersona.Items)
                        {
                            if (Convert.ToInt16(oc.Valor) == Convert.ToInt16(objPersonaBE.Tip_per.ToString()))
                            {
                                int indice_combo = cboTipoPersona.Items.IndexOf(oc);
                                cboTipoPersona.SelectedIndex = indice_combo;
                            }
                        }

                        foreach (OpcionCombo oc in cboEstadoPersona.Items)
                        {
                            if (Convert.ToInt16(oc.Valor) == Convert.ToInt16(objPersonaBE.Est_per.ToString()))
                            {
                                int indice_combo = cboEstadoPersona.Items.IndexOf(oc);
                                cboEstadoPersona.SelectedIndex = indice_combo;
                            }
                        }


                        // Si no tiene foto....
                        if (objPersonaBE.Foto.Length == 0)
                        {
                            pcbImagenPersona.Image = null;

                        }
                        else // Pero si tiene foto
                        {
                            MemoryStream fotoStream = new MemoryStream(objPersonaBE.Foto);
                            pcbImagenPersona.Image = Image.FromStream(fotoStream);
                            // Guardamos la foto original , por si no se hace cambios...
                            FotoOriginal = objPersonaBE.Foto;
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

                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objPersonaBE

                objPersonaBE.Nro_doc = txtNroDocPersona.Text;
                objPersonaBE.Nom_per = txtNomPersona.Text;
                objPersonaBE.Ape_per = txtApePersona.Text;
                objPersonaBE.Edad = Convert.ToDateTime(dtpEdadPersona.Value.Date.ToString("yyyy-MM-dd"));
                objPersonaBE.Dir_per = txtDireccPersona.Text;
                objPersonaBE.Id_Nac = Convert.ToInt16(cboNacPersona.SelectedValue);
                objPersonaBE.Est_per = Convert.ToInt16(((OpcionCombo)cboEstadoPersona.SelectedItem).Valor.ToString());
                objPersonaBE.Gen_per = Convert.ToInt16(((OpcionCombo)cboGeneroPersona.SelectedItem).Valor.ToString());
                objPersonaBE.Tip_per = Convert.ToInt16(((OpcionCombo)cboTipoPersona.SelectedItem).Valor.ToString());
                objPersonaBE.Doc_ide = Convert.ToInt16(((OpcionCombo)cboTipoDocPersona.SelectedItem).Valor.ToString());
           
                // Si cambio la foto...
                if (blnCambio == true)
                {
                    objPersonaBE.Foto = File.ReadAllBytes(openFileDialogPersona.FileName);
                }
                else  //Mantenemos la foto original
                {
                    objPersonaBE.Foto = FotoOriginal;
                }



                //Invocamos al metodo ActualizarPersona

                if (objPersonaBL.ActualizarPersona(objPersonaBE) == true)
                {

                    limipiarCampos();
                    CargarDatos("");
                    blnCambio = false;
                    txtNroDocPersona.ReadOnly = false;
                  

                }
                else
                {
                    throw new Exception("No se actualio el registro, contacto con IT");
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
                vrpta = MessageBox.Show("¿Desea eliminar a la persona?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {

                    if (objPersonaBL.EliminarPersona(txtNroDocPersona.Text) == true)
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
                    return;
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
                } else
                {
                    foreach (DataGridViewRow row in dtgDatos.Rows)
                    {
                        row.Visible = false;
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

        private void cboTipoPersona_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt16(((OpcionCombo)cboTipoPersona.SelectedItem).Valor.ToString()) == 1)
            {
                cboNacPersona.SelectedIndex = 145;
                cboNacPersona.Enabled = false;
            }
            else
            {
                cboNacPersona.SelectedIndex = 0;
                cboNacPersona.Enabled = true;
            }
        }
    }
}
