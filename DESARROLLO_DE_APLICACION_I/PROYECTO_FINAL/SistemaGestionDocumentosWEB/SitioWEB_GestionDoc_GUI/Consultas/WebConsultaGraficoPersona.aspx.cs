using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProyGestionDoc_BL;

namespace SitioWEB_GestionDoc_GUI.Consultas
{
    public partial class WebConsultaGraficoPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Page.IsPostBack == false)
                {
                    PersonaBL objPersonaBL = new PersonaBL();
                    grvPersonas.DataSource = objPersonaBL.ListarPersonasAnual();
                    grvPersonas.DataBind();

                    //Datos graficos
                    DataTableReader dtReaderCantidades = objPersonaBL.ListarPersonasAnual().CreateDataReader();
                    grafCantidades.Series.Add("Cantidades");
                    grafCantidades.Series["Cantidades"].Points.DataBindXY(dtReaderCantidades, "Año", dtReaderCantidades, "CantPersonas");
                    grafCantidades.Series["Cantidades"].IsValueShownAsLabel = true;
                    grafCantidades.Series["Cantidades"].LabelFormat = "n";
                    
                }   
            }catch(Exception ex)
            {
                lblMensajes.Text = ex.Message;
            }
        }
    }
}