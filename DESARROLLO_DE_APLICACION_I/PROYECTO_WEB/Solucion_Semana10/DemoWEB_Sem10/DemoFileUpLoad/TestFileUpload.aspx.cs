using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem10.DemoFileUpLoad
{
    public partial class TestFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar1_Click(object sender, EventArgs e)
        {
            try
            {
                //Definimos la ruta ...
                String strRuta = Server.MapPath("/") + @"Documentos\";

                //Validamos el ful1 ....
                if (ful1.HasFile == true)
                {
                    String strNombreArchivo = ful1.FileName;

                    //Obtenemos la extensión del nombre de archivo...
                    String strExtension = Path.GetExtension(strNombreArchivo);
                    if (strExtension == ".doc" | strExtension == ".docx" | strExtension == ".xls" | strExtension == ".xlsx")
                    {
                        strRuta += strNombreArchivo;
                        //Posteamos el archivo...
                        ful1.SaveAs(strRuta);
                        //Mandamos el mensaje al usuario...
                        lblMensaje1.ForeColor = System.Drawing.Color.Blue;
                        lblMensaje1.Text = "Archivo enviado con éxito";
                    }
                    else
                    {
                        throw new Exception("No se pudo enviar el archivo, formato incorrecto. Contacte con IT.");
                    }
                }
                else
                {
                    throw new Exception("Por favor seleccione un archivo");
                }
            }
            catch (Exception ex)
            {
                lblMensaje1.ForeColor = System.Drawing.Color.Red;
                lblMensaje1.Text = "Error: " + ex.Message;
            }
        }

        protected void btnEnviar2_Click(object sender, EventArgs e)
        {
            try
            {
                //Definimos la ruta .....
                String strRuta = Server.MapPath("/") + @"Documentos\";

                //Validamos el ful1 ....
                if (ful2.HasFile == true)
                {
                    //Evaluamos el tamaño del archivo a postear...
                    if (ful2.PostedFile.ContentLength <= 4200000)
                    {
                        //Si el tamaño es menor a los 4 MB, evaluamos que tipo de archivo se enviara...
                        List<String> strListaExtensiones = new List<String>();
                        strListaExtensiones.Add(".jpg");
                        strListaExtensiones.Add(".jpeg");
                        strListaExtensiones.Add(".ico");
                        strListaExtensiones.Add(".png");
                        strListaExtensiones.Add(".gif");

                        //Obtenemos la extensión del archivo a postear...
                        String strExtension = Path.GetExtension(ful2.FileName);

                        if (strListaExtensiones.Contains(strExtension) == true)
                        {
                            //Si cumple las condiciones enviamos el archivo...
                            strRuta += ful2.FileName;
                            ful2.SaveAs(strRuta);
                            lblMensaje2.ForeColor = System.Drawing.Color.Blue;
                            lblMensaje2.Text = "Archivo enviado con exito";
                        }
                        else
                        {
                            throw new Exception("No se pudo enviar el archivo, formato incorrecto. Contacte con IT.");
                        }
                    }
                    else
                    {
                        throw new Exception("No se pudo enviar el archivo, tamaño incorrecto. Contacte con IT.");
                    }
                }
                else
                {
                    throw new Exception("Por favor seleccione un archivo");
                }
            }
            catch (Exception ex)
            {
                lblMensaje2.ForeColor = System.Drawing.Color.Red;
                lblMensaje2.Text = "Error: " + ex.Message;
            }
        }

        protected void btnEnviar3_Click(object sender, EventArgs e)
        {
            try
            {
                //Definimos la ruta...
                String strRuta = Server.MapPath("/") + @"Documentos\";

                //Validamos
                if (ful3.HasFile == true)
                {
                    String strNombreArchivo = ful3.FileName;

                    //Evaluamos el tamaño del archivo a postear...|
                    if (ful3.PostedFile.ContentLength <= 4200000)
                    {
                        //Si el tamaño es máximo de 4 MB, evaluamos que tipo de archivo se enviara...
                        String strExtension = Path.GetExtension(strNombreArchivo);
                        if (strExtension == ".pdf")
                        {
                            //Si cumple las condiciones enviamos el archivo...
                            strRuta += strNombreArchivo;
                            ful3.SaveAs(strRuta);
                            lblMensaje3.ForeColor = System.Drawing.Color.Blue;
                            lblMensaje3.Text = "Archivo enviado con exito";
                        }
                        else
                        {
                            throw new Exception("No se pudo enviar el archivo, formato incorrecto. Contacte con IT.");
                        }
                    }
                    else
                    {
                        throw new Exception("No se pudo enviar el archivo, tamaño incorrecto. Contacte con IT.");
                    }
                }
                else
                {
                    throw new Exception("Por favor seleccione un archivo");
                }
            }
            catch (Exception ex)
            {
                lblMensaje3.ForeColor = System.Drawing.Color.Red;
                lblMensaje3.Text = "Error: " + ex.Message;
            }
        }
    }
}