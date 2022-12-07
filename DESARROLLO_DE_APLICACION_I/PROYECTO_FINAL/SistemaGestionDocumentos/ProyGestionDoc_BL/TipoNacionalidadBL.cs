using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar...
using ProyGestionDoc_ADO;
using ProyGestionDoc_BE;

namespace ProyGestionDoc_BL
{
    public class TipoNacionalidadBL
    {
        TipoNacionalidadADO objTipoNacionalidadADO = new TipoNacionalidadADO();

        public DataTable ListarNacionalidad()
        {
            return objTipoNacionalidadADO.ListarNacionalidad();
        }
    }
}
