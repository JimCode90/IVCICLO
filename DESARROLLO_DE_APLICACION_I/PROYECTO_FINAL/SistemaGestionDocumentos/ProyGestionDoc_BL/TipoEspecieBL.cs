using ProyGestionDoc_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGestionDoc_BL
{
    public class TipoEspecieBL
    {
        TipoEspecieADO objTipoEspecieADO = new TipoEspecieADO();

        public DataTable ListarTipoEspecie()
        {
            return objTipoEspecieADO.ListarTipoEspecie();
        }
    }
}
