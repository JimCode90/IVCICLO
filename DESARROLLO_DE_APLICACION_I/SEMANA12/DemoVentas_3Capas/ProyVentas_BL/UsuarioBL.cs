using ProyVentas_ADO;
using ProyVentas_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyVentas_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(String strCodigo)
        {
            return objUsuarioADO.ConsultarUsuario(strCodigo);
        }
    }
}
