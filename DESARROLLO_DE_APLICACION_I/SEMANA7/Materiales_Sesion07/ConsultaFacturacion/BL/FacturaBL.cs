using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Agregar...
using ProyVentas_ADO;
using System.Data;
namespace ProyVentas_BL
{
    public class FacturaBL
    {
        FacturaADO objFacturaADO = new FacturaADO();

        public DataTable ListarFacturasClienteFechas(String strCodCli,DateTime FecIni, 
                                                                                   DateTime FecFin)
        {
            return objFacturaADO.ListarFacturasClienteFechas(strCodCli,FecIni,FecFin);
        }

      


    }
}
