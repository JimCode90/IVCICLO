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
    public class VehiculoBL
    {
        VehiculoADO objVehiculoADO = new VehiculoADO();
        public DataTable ListarVehiculo()
        {
            return objVehiculoADO.ListarVehiculo();
        }

        public VehiculoBE ConsultarVehiculo(Int16 strCodigo)
        {
            return objVehiculoADO.ConsultarVehiculo(strCodigo);
        }

        public VehiculoBE ConsultarVehiculoPlaca(String strCodigo)
        {
            return objVehiculoADO.ConsultarVehiculoPlaca(strCodigo);
        }


        public Boolean InsertarVehiculo(VehiculoBE objVehiculoBE)
        {
            return objVehiculoADO.InsertarVehiculo(objVehiculoBE);
        }

        public Boolean ActualizarVehiculo(VehiculoBE objVehiculoBE)
        {
            return objVehiculoADO.ActualizarVehiculo(objVehiculoBE);
        }

        public Boolean EliminarVehiculo(Int16 strCodigo)
        {
            return objVehiculoADO.EliminarVehiculo(strCodigo);
        }
    }
}
