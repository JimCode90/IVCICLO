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
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public DataTable ListarUsuario()
        {
            return objUsuarioADO.ListarUsuario();
        }

        public Boolean InsertarUsuario(UsuarioBE objUsuarioBE)
        {
            return objUsuarioADO.InsertarUsuario(objUsuarioBE);
        }

        public Boolean ActualizarUsuario(UsuarioBE objUsuarioBE)
        {
            return objUsuarioADO.ActualizarUsuario(objUsuarioBE);
        }

    }
}
