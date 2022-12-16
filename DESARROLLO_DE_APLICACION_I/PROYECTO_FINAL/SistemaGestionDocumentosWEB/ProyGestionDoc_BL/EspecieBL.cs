using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar
using ProyGestionDoc_ADO;
using ProyGestionDoc_BE;

namespace ProyGestionDoc_BL
{
    public class EspecieBL
    {
        EspecieADO objEspecieADO = new EspecieADO();
        public DataTable ListarEspecie()
        {
            return objEspecieADO.ListarEspecie();
        }

        public Boolean InsertarEspecie(EspecieBE objEspecieBE)
        {
            return objEspecieADO.InsertarEspecie(objEspecieBE);
        }

        public Boolean ActualizarEspecie(EspecieBE objEspecieBE)
         {
             return objEspecieADO.ActualizarEspecie(objEspecieBE);
         }

        public Boolean EliminarEspecie(Int16 strCodigo)
        {
            return objEspecieADO.EliminarEspecie(strCodigo);
        }

        public EspecieBE ConsultarEspecie(Int16 strCodigo)
        {
            return objEspecieADO.ConsultarEspecie(strCodigo);
        }
    }
}
