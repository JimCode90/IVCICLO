using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar
using ProyGestionDoc_ADO;
using ProyGestionDoc_BE;

namespace ProyGestionDoc_BL
{
    public class PersonaBL
    {
        PersonaADO objPersonaADO = new PersonaADO();
        public DataTable ListarPersona()
        {
            return objPersonaADO.ListarPersona();
        }

        public PersonaBE ConsultarPersona(String strCodigo)
        {
            return objPersonaADO.ConsultarPersona(strCodigo);
        }

        public Boolean InsertarPersona(PersonaBE objPersonaBE)
        {
            return objPersonaADO.InsertarPersona(objPersonaBE);
        }

        public Boolean ActualizarPersona(PersonaBE objPersonaBE)
        {
            return objPersonaADO.ActualizarPersona(objPersonaBE);
        }

        public Boolean EliminarPersona(String strCodigo)
        {
            return objPersonaADO.EliminarPersona(strCodigo);
        }
    }
}
