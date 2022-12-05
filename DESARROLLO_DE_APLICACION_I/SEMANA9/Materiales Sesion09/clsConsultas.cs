using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class clsConsultas
{
	   
     SqlConnection Cnx = new SqlConnection
         ("Server=.;Database=VentasLeon; Integrated Security=SSPI");
         
    public DataTable EjecutaSelect(String  cadena) 
    {
    
      // este metodo retorna una tabla con registros de una cadena SQL
       
        DataSet Ds = new DataSet();
        try
        {
            SqlDataAdapter MiAdaptador = new SqlDataAdapter(cadena, Cnx);
             MiAdaptador.Fill(Ds, "Datos");
        }
        catch (Exception Ex)
        {
            throw new Exception("Error en el llenado de datos. Revise su sentencia SQL" + 
                                                           Ex.Message );
        }
       return Ds.Tables["Datos"];
   
    }
      
   

}


