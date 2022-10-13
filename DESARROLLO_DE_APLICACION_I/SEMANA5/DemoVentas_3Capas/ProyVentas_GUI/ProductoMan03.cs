using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using ProyVentas_BE;
using ProyVentas_BL;
namespace ProyVentas_GUI
{
    public partial class ProductoMan03 : Form
    {
        // Instancias...
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        CategoriaBL objCategoriaBL = new CategoriaBL();

        public ProductoMan03()
        {
            InitializeComponent();
        }

        // Propiedad que recibe el codigo del producto que se actualizara, enviado
        // desde el ProductoMan01

        public String Codigo { get; set; }

        private void ProductoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos...
                DataTable dt = objCategoriaBL.ListarCategoria();
                DataRow dr;

                dr = dt.NewRow();
                dr["Id_cat"] = 0;
                dr["Des_cat"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboCategoria.DataSource = dt;
                cboCategoria.ValueMember = "Id_cat";
                cboCategoria.DisplayMember = "Des_cat";

                dt = objUnidadMedidaBL.ListarUM();
                dr = dt.NewRow();
                dr["Id_UM"] = 0;
                dr["Des_UM"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboUM.DataSource = dt;
                cboUM.DisplayMember = "Des_UM";
                cboUM.ValueMember = "Id_UM";

                // Codifique
                // Consultamos el producto que se va a actualizar
                objProductoBE = objProductoBL.ConsultarProducto(this.Codigo);

                lblCodigo.Text = objProductoBE.Cod_pro;

                txtDescripcion.Text = objProductoBE.Des_pro;
                txtPrecio.Text = objProductoBE.Pre_pro.ToString();
                txtStkAct.Text = objProductoBE.Stk_act.ToString();
                txtStkMin.Text =objProductoBE.Stk_min.ToString();

                chkImportado.Checked = Convert.ToBoolean(objProductoBE.Importado);
                chkActivo.Checked = Convert.ToBoolean(objProductoBE.Est_pro);

                cboCategoria.SelectedValue = objProductoBE.Id_Cat.ToString();
                cboUM.SelectedValue = objProductoBE.Id_UM.ToString();





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
                //Codifique
                //Validamos...
                if (txtDescripcion.Text.Trim() == "")
                {
                    throw new Exception("La descripcion es obligatorio");
                }

                if (cboUM.SelectedIndex == 0 || cboCategoria.SelectedIndex == 0)
                {
                    throw new Exception("La unidad de medida y la categoria son obligatorias");
                }

                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objProductoBE
                objProductoBE.Cod_pro = lblCodigo.Text;
                objProductoBE.Des_pro = txtDescripcion.Text;
                objProductoBE.Pre_pro = Convert.ToSingle(txtPrecio.Text.Trim());
                objProductoBE.Stk_act = Convert.ToInt16(txtStkAct.Text.Trim());
                objProductoBE.Stk_min = Convert.ToInt16(txtStkMin.Text.Trim());
                objProductoBE.Importado = Convert.ToInt16(chkImportado.Checked);
                objProductoBE.Est_pro = Convert.ToInt16(chkActivo.Checked);
                objProductoBE.Id_Cat = Convert.ToInt16(cboCategoria.SelectedValue);
                objProductoBE.Id_UM = Convert.ToInt16(cboUM.SelectedValue);

                //Por ahora ponemos en duro el usu_ult_mod
                objProductoBE.Usu_Ult_Mod = "jleon";

                //Invocamos al metodo insertarProducto
                if (objProductoBL.ActualizarProducto(objProductoBE) == true)
                {
                    this.Close();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtStkAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
