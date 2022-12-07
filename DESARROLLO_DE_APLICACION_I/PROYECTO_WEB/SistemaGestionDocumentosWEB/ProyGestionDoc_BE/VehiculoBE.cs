using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGestionDoc_BE
{
    public class VehiculoBE
    {
        public Int16 Id_veh { get; set; }
        public String Mod_veh { get; set; }
        public String Nro_pla { get; set; }
        public String Color { get; set; }
        public Int16 Est_veh { get; set; }
        public DateTime Fec_reg { get; set; }
        public Int16 Id_Mar_veh { get; set; }
        public Byte[] Foto_veh { get; set; }
        public String Usu_reg { get; set; }
        
        
    }
}
