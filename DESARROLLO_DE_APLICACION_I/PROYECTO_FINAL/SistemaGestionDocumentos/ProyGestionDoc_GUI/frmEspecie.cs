﻿using ProyGestionDoc_GUI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//agregar
using ProyGestionDoc_BE;
using ProyGestionDoc_BL;
using ProyGestionDoc_GUI.Utilidades;

namespace ProyGestionDoc_GUI
{
    public partial class frmEspecie : Form
    {
        //Instancias
        EspecieBL objEspecieBL = new EspecieBL();
        EspecieBE objEspecieBE = new EspecieBE();
        TipoEspecieBL objTipoEspecieBL = new TipoEspecieBL();
        DataView dtv;
        public frmEspecie()
        {
            InitializeComponent();
        }

        private void frmEspecie_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargamos los combos
                DataTable dt = objTipoEspecieBL.ListarTipoEspecie();
                DataRow dr;
                dr = dt.NewRow();
                dr["Id_tip_espec"] = 0;
                dr["Opc_espec"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboTipoEspecie.DataSource = dt;
                cboTipoEspecie.DisplayMember = "Opc_espec";
                cboTipoEspecie.ValueMember = "Id_tip_espec";


                cboEstadoEspecie.Items.Add(new OpcionCombo() { Valor = 0, Texto = "--Seleccione--" });
                cboEstadoEspecie.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
                cboEstadoEspecie.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
                cboEstadoEspecie.DisplayMember = "Texto";
                cboEstadoEspecie.ValueMember = "Valor";
                cboEstadoEspecie.SelectedIndex = 0;

                //Cargamos los datos al DataGridView
                dtgDatos.AutoGenerateColumns = false;
                CargarDatos("");
               

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

                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objEspecieBE
                objEspecieBE.Des_espec = txtDescEspecie.Text;
                objEspecieBE.Mar_espec = txtMarcaEspecie.Text;
                objEspecieBE.Mod_espec = txtModeloEspecie.Text;
                objEspecieBE.Color = txtColorEspecie.Text;
                objEspecieBE.Can_espec = Convert.ToInt16(txtCantidadEspecie.Text);
                objEspecieBE.Nro_serie = txtSerieEspecie.Text;
                //Por ahora ponemos en duro el usu_registro
                objEspecieBE.Usu_reg = "31999873";
                objEspecieBE.Est_espec = Convert.ToInt16(((OpcionCombo)cboEstadoEspecie.SelectedItem).Valor.ToString());
                objEspecieBE.Id_tip_espec = Convert.ToInt16(cboTipoEspecie.SelectedValue);

           
                //Invocamos al metodo insertarEspcie

                if (objEspecieBL.InsertarEspecie(objEspecieBE) == true)
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

        private void CargarDatos(String strFiltro)
        {
            try
            {
                dtv = new DataView(objEspecieBL.ListarEspecie());
                dtgDatos.DataSource = dtv;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void validarDatos()
        {


            if (cboTipoEspecie.SelectedIndex == 0)
            {
                throw new Exception("El Tipo de especie es obligatorio");
            }


            if (txtDescEspecie.Text.Trim() == "")
            {
                throw new Exception("La descripción es obligatorio");
            }

            if (txtMarcaEspecie.Text.Trim() == "")
            {
                throw new Exception("El marca obligatorio");
            }

            if (txtModeloEspecie.Text.Trim() == "")
            {
                throw new Exception("El modelo obligatorio");
            }

            if (txtColorEspecie.Text.Trim() == "")
            {
                throw new Exception("El color es obligatorio");
            }

            if (txtCantidadEspecie.Text.Trim() == "")
            {
                throw new Exception("La cantidad es obligatorio");
            }


            if (txtSerieEspecie.Text.Trim() == "")
            {
                throw new Exception("El número de serie es obligatorio");
            }


            if (cboEstadoEspecie.SelectedIndex == 0)
            {
                throw new Exception("El estado es obligatorio");
            }
        }

        private void limipiarCampos()
        {
            cboTipoEspecie.SelectedIndex = 0;
            txtDescEspecie.Text = "";
            txtMarcaEspecie.Text = "";
            txtModeloEspecie.Text = "";
            txtColorEspecie.Text = "";
            txtCantidadEspecie.Text = "";
            txtSerieEspecie.Text = "";
            cboEstadoEspecie.SelectedIndex = 0;
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
                        cboTipoEspecie.SelectedIndex = Convert.ToInt16(dtgDatos.Rows[indice].Cells["Id_tip_espec"].Value.ToString());
                        foreach (OpcionCombo oc in cboEstadoEspecie.Items)
                        {
                            if (Convert.ToInt16(oc.Valor) == Convert.ToInt16(dtgDatos.Rows[indice].Cells["Est_espec"].Value))
                            {
                                int indice_combo = cboEstadoEspecie.Items.IndexOf(oc);
                                cboEstadoEspecie.SelectedIndex = indice_combo;
                            }
                        }

                        txtIdEspecie.Text = dtgDatos.Rows[indice].Cells["Id_espec"].Value.ToString();
                        txtDescEspecie.Text = dtgDatos.Rows[indice].Cells["Des_espec"].Value.ToString();
                        txtModeloEspecie.Text = dtgDatos.Rows[indice].Cells["Mod_espec"].Value.ToString();
                        txtMarcaEspecie.Text = dtgDatos.Rows[indice].Cells["Mar_espec"].Value.ToString();
                        txtColorEspecie.Text = dtgDatos.Rows[indice].Cells["Color"].Value.ToString();
                        txtCantidadEspecie.Text = dtgDatos.Rows[indice].Cells["Can_espec"].Value.ToString();
                        txtSerieEspecie.Text = dtgDatos.Rows[indice].Cells["Nro_serie"].Value.ToString();


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos...
                validarDatos();

                //Si todo esta ok, procedemos a asignar las propiedades a la instancia objEspecieBE
                objEspecieBE.Id_espec = Convert.ToInt16(txtIdEspecie.Text);
                objEspecieBE.Des_espec = txtDescEspecie.Text;
                objEspecieBE.Mar_espec = txtMarcaEspecie.Text;
                objEspecieBE.Mod_espec = txtModeloEspecie.Text;
                objEspecieBE.Color = txtColorEspecie.Text;
                objEspecieBE.Can_espec = Convert.ToInt16(txtCantidadEspecie.Text);
                objEspecieBE.Nro_serie = txtSerieEspecie.Text;
                //Por ahora ponemos en duro el usu_registro
                //objEspecieBE.Usu_reg = "31999873";
                objEspecieBE.Est_espec = Convert.ToInt16(((OpcionCombo)cboEstadoEspecie.SelectedItem).Valor.ToString());
                objEspecieBE.Id_tip_espec = Convert.ToInt16(cboTipoEspecie.SelectedValue);


                //Invocamos al metodo actualizarEspecie

                if (objEspecieBL.ActualizarEspecie(objEspecieBE) == true)
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
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
