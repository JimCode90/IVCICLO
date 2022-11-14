using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregar
using System.IO;
using System.Data;
namespace DemoWEB_Sem10.DemoFileUpLoad
{
    public partial class TestDescargar : System.Web.UI.Page
    {
        DataTable tabla = new DataTable();
        DataColumn column ;
        DataRow row;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos la lista de archivos de la carpeta Documentos
                String strRuta = Server.MapPath("/") + @"Documentos\";
                DirectoryInfo dir = new DirectoryInfo(strRuta);
                FileInfo [] archivos = dir.GetFiles("*.*");
                
                // Creamos la tabla con los archivos
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "NombreArchivo";
                tabla.Columns.Add(column);
                // LLenamos la tabla con los archivos de la carpeta Documentos
                foreach (var file in archivos)
                {
                    row = tabla.NewRow();
                    row["NombreArchivo"] = file.Name;
                    tabla.Rows.Add(row);
                }
                // Enlazamos a la grilla...
                grvArchivos.DataSource = tabla;
                grvArchivos.DataBind();
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }
        }

        protected void grvArchivos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                // Obtenemos la fila donde se hizo click en el boton Descargar
                Int16 fila = Convert.ToInt16(e.CommandArgument);

                // Si se  invoco a la columna Descargar
                if (e.CommandName == "Descargar")
                {
                    // Se obtiene el nombre de archivo a descargar
                    String NomArchivo = grvArchivos.Rows[fila].Cells[0].Text;

                    // Se codifica los eventos en el cliente para la descarga del archivo
                    Response.Clear();

                    Response.AddHeader("content-disposition", string.Format("attachment;filename={0}", NomArchivo));
                    Response.ContentType = "application/octet-stream";

                    Response.WriteFile(Server.MapPath(Path.Combine("~/Documentos", NomArchivo)));
                    Response.End();


                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }
        }
    }
}