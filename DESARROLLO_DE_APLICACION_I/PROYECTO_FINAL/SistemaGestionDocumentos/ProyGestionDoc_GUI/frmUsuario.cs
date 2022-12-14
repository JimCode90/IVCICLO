using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

//agregar
using ProyGestionDoc_BE;
using ProyGestionDoc_BL;
using ProyGestionDoc_GUI.Utilidades;

namespace ProyGestionDoc_GUI
{
    public partial class frmUsuario : Form
    {
        //Instancias
        TipoGradoBL objTipoGradoBL = new TipoGradoBL();
        UnidadBL objUnidadBL = new UnidadBL();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        UsuarioBE objUsuarioBE = new UsuarioBE();

        DataView dtv;

        public frmUsuario()
        {
            InitializeComponent();
        }


        private void frmUsuario_Load(object sender, EventArgs e)
        {

            try
            {
                //Cargamos los combos
                DataTable dt = objTipoGradoBL.ListarGrado();
                DataRow dr;
                dr = dt.NewRow();
                dr["Id_Gra"] = 0;
                dr["Opc_Gra"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboGrado.DataSource = dt;
                cboGrado.DisplayMember = "Opc_Gra";
                cboGrado.ValueMember = "Id_Gra";

                dt = objUnidadBL.ListarUnidad();
                dr = dt.NewRow();
                dr["Id_Uni"] = 0;
                dr["Opc_Uni"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboUnidad.DataSource = dt;
                cboUnidad.DisplayMember = "Opc_Uni";
                cboUnidad.ValueMember = "Id_Uni";

                cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "--Seleccione--" });
                cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
                cboEstado.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
                cboEstado.DisplayMember = "Texto";
                cboEstado.ValueMember = "Valor";
                cboEstado.SelectedIndex = 0;

                cboRol.Items.Add(new OpcionCombo() { Valor = 0, Texto = "--Seleccione--" });
                cboRol.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Administrador" });
                cboRol.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Comisario" });
                cboRol.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Instructor" });
                cboRol.DisplayMember = "Texto";
                cboRol.ValueMember = "Valor";
                cboRol.SelectedIndex = 0;



                foreach (DataGridViewColumn columna in dtgDatos.Columns)
                {
                    if (columna.Visible == true && columna.Name != "btnSeleccionar")
                    {
                        cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                    }
                }

                cboBusqueda.SelectedIndex = 0;
                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";


                dtgDatos.AutoGenerateColumns = false;
                CargarDatos("");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void CargarDatos(String strFiltro) {
            try
            {
                dtv = new DataView(objUsuarioBL.ListarUsuario());
                dtv.RowFilter = "Nom_usu like '%" + strFiltro + "%'";
                dtgDatos.DataSource = dtv;
                //lblRegistros.Text = dtgDatos.Rows.Count.ToString();
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

                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objUsuarioBE
                objUsuarioBE.Pass_usu = txtPassword.Text;
                objUsuarioBE.Cip_usu = txtNroCarnet.Text;
                objUsuarioBE.Dni_usu = txtNroDni.Text;
                objUsuarioBE.Nom_usu = txtNombres.Text;
                objUsuarioBE.Ape_usu = txtApellidos.Text;
                objUsuarioBE.Email_usu = txtEmail.Text;
                objUsuarioBE.Tel_usu = txtTelefono.Text;
                objUsuarioBE.Est_usu = Convert.ToInt16(((OpcionCombo)cboEstado.SelectedItem).Valor.ToString());
                objUsuarioBE.Rol_usu = Convert.ToInt16(((OpcionCombo)cboRol.SelectedItem).Valor.ToString());
                objUsuarioBE.Id_Gra = Convert.ToInt16(cboGrado.SelectedValue);
                objUsuarioBE.Id_Uni = Convert.ToInt16(cboUnidad.SelectedValue);


                //Invocamos al metodo InsertarUsuario

                if (objUsuarioBL.InsertarUsuario(objUsuarioBE) == true)
                {

                    limipiarCampos();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos...
                validarDatos();

                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objUsuarioBE
                objUsuarioBE.Cip_usu = txtNroCarnet.Text;
                objUsuarioBE.Pass_usu = txtPassword.Text;
                objUsuarioBE.Dni_usu = txtNroDni.Text;
                objUsuarioBE.Nom_usu = txtNombres.Text;
                objUsuarioBE.Ape_usu = txtApellidos.Text;
                objUsuarioBE.Email_usu = txtEmail.Text;
                objUsuarioBE.Tel_usu = txtTelefono.Text;
                objUsuarioBE.Est_usu = Convert.ToInt16(((OpcionCombo)cboEstado.SelectedItem).Valor.ToString());
                objUsuarioBE.Rol_usu = Convert.ToInt16(((OpcionCombo)cboRol.SelectedItem).Valor.ToString());
                objUsuarioBE.Id_Gra = Convert.ToInt16(cboGrado.SelectedValue);
                objUsuarioBE.Id_Uni = Convert.ToInt16(cboUnidad.SelectedValue);

              

                //Invocamos al metodo ActualizarUsuario

                if (objUsuarioBL.ActualizarUsuario(objUsuarioBE) == true)
                {

                    limipiarCampos();
                    CargarDatos("");
                    txtNroCarnet.ReadOnly = false;
                }
                else
                {
                    throw new Exception("No se actualizo el registro, contacto con IT");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                        cboGrado.SelectedValue = dtgDatos.Rows[indice].Cells["Id_Gra"].Value.ToString();
                        cboUnidad.SelectedValue = dtgDatos.Rows[indice].Cells["Id_Uni"].Value.ToString();
                        //Para rol y estado es distinta la logica
                        foreach (OpcionCombo oc in cboEstado.Items)
                        {
                            if (Convert.ToInt16(oc.Valor) == Convert.ToInt16(dtgDatos.Rows[indice].Cells["Est_usu"].Value))
                            {
                                int indice_combo = cboEstado.Items.IndexOf(oc);
                                cboEstado.SelectedIndex = indice_combo;
                            }
                        }

                        foreach (OpcionCombo oc in cboRol.Items)
                        {
                            if (Convert.ToInt16(oc.Valor) == Convert.ToInt16(dtgDatos.Rows[indice].Cells["Rol_usu"].Value))
                            {
                                int indice_combo = cboRol.Items.IndexOf(oc);
                                cboRol.SelectedIndex = indice_combo;
                            }
                        }


                        txtNombres.Text = dtgDatos.Rows[indice].Cells["Nom_usu"].Value.ToString();
                        txtApellidos.Text = dtgDatos.Rows[indice].Cells["Ape_usu"].Value.ToString();
                        txtNroCarnet.Text = dtgDatos.Rows[indice].Cells["Cip_usu"].Value.ToString();
                        txtPassword.Text = dtgDatos.Rows[indice].Cells["Pass_usu"].Value.ToString();
                        //Bloqueamos el campo del nro de cip
                        txtNroCarnet.ReadOnly = true;

                        txtNroDni.Text = dtgDatos.Rows[indice].Cells["Dni_usu"].Value.ToString();
                        txtTelefono.Text = dtgDatos.Rows[indice].Cells["Tel_usu"].Value.ToString();
                        txtEmail.Text = dtgDatos.Rows[indice].Cells["Email_usu"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            
        }


        private void validarDatos() {


            if (cboGrado.SelectedIndex == 0)
            {
                throw new Exception("El grado es obligatorio");
            }


            if (txtNombres.Text.Trim() == "")
            {
                throw new Exception("Los nombres son obligatorios");
            }

            if (txtApellidos.Text.Trim() == "")
            {
                throw new Exception("Los apellidos son obligatorios");
            }

            if (txtNroCarnet.Text.Trim() == "")
            {
                throw new Exception("El número de CIP es obligatorio");
            }

            if (txtNroDni.Text.Trim() == "")
            {
                throw new Exception("El número de DNI es obligatorio");
            }

            if (cboUnidad.SelectedIndex == 0)
            {
                throw new Exception("La unidad es obligatorio");
            }


            if (txtEmail.Text.Trim() == "")
            {
                throw new Exception("El email es obligatorio");
            }


            if (cboRol.SelectedIndex == 0)
            {
                throw new Exception("El rol es obligatorio");
            }


            if (txtPassword.Text.Trim() == "")
            {
                throw new Exception("La contraseña es obligatorio");
            }

            if (cboEstado.SelectedIndex == 0)
            {
                throw new Exception("El estado es obligatorio");
            }
        }

        private void limipiarCampos()
        {
            cboGrado.SelectedIndex = 0;
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtNroCarnet.Text = "";
            txtNroDni.Text = "";
            cboUnidad.SelectedIndex = 0;
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cboRol.SelectedIndex = 0;
            txtPassword.Text = "";
            cboEstado.SelectedIndex = 0;
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

                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

       

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            panelFormUsuario.ScrollControlIntoView(e.Control);
        }


        private void frmUsuario_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult vrpta;
                vrpta = MessageBox.Show("¿Desea eliminar al usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {

                    if (objUsuarioBL.EliminarUsuario(txtNroCarnet.Text) == true)
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
                    foreach(DataGridViewRow row in dtgDatos.Rows)
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
