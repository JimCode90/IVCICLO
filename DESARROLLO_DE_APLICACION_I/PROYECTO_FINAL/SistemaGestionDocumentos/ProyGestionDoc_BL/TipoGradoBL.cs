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
    public class TipoGradoBL
    {
        TipoGradoADO objTipoGradoADO = new TipoGradoADO();

        public DataTable ListarGrado()
        {
            return objTipoGradoADO.ListarGrado(); 
        }

    }
}
