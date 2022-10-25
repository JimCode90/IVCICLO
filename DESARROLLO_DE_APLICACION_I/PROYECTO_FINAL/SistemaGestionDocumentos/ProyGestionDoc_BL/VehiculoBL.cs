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

        public Boolean InsertarVehiculo(VehiculoBE objVehiculoBE)
        {
            return objVehiculoADO.InsertarVehiculo(objVehiculoBE);
        }

        public Boolean ActualizarVehiculo(VehiculoBE objVehiculoBE)
        {
            return objVehiculoADO.ActualizarVehiculo(objVehiculoBE);
        }
    }
}
