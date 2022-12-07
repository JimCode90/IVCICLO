using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Agregar...
using ProyVentas_BL;
using ProyVentas_BE;
namespace ProyVentas_GUI
{
    public partial class ProveedorMan02 : Form
    {
        
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();
            

        public ProveedorMan02()
        {
            InitializeComponent();
        }

        private void ProveedorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                
                // Cargamos los combos de Ubigeo
                // Por defecto elegiremos Lima, Lima , Lima (14,01,01)
                CargarUbigeo("14","01","01");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            
            }
        }

        private void CargarUbigeo(String IdDepa,String IdProv,String IdDist)
        {
            // Codifique
            //LLenamos combos

            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.SelectedValue = IdDist;
          

        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                if(txtRS.Text.Trim() == String.Empty)
                {
                    throw new Exception("La razón social es obligatorio");
                }

                if (mskRuc.MaskFull != true)
                {
                    throw new Exception("El RUC consta de 11 caracteres");
                }

                //Si todo esta OK
                objProveedorBE.Raz_soc_prv = txtRS.Text.Trim();
                objProveedorBE.Dir_prv = txtDir.Text.Trim();
                objProveedorBE.Tel_prv = txtTel.Text.Trim();
                objProveedorBE.Ruc_prv = mskRuc.Text;
                objProveedorBE.Rep_ven = txtRepVen.Text.Trim();
                objProveedorBE.Est_prv = Convert.ToInt16(chkEstado.Checked);
             

                //Ubigeo = es la concatenacion de los valores seleccionados en los combos Departamento-Provincia-Distrito
                objProveedorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();

                objProveedorBE.Usu_Registro = "jimmy";

                //Invocamos al metido insert
                if (objProveedorBL.InsertarProveedor(objProveedorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error al insertar proveedor, contacte con TI");
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }


        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
