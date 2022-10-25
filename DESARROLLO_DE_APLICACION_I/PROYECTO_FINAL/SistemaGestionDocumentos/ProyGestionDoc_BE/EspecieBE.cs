using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGestionDoc_BE
{
    public class EspecieBE
    {
        public Int16 Id_espec { get; set; }
        public String Des_espec { get; set; }
        public String Mar_espec { get; set; }
        public String Mod_espec { get; set; }
        public String Color { get; set; }
        public Int16 Can_espec { get; set; }
        public String Nro_serie { get; set; }
        public Int16 Est_espec { get; set; }
        public DateTime Fec_reg { get; set; }
        public Int16 Id_tip_espec { get; set; }
        public String Usu_reg { get; set; }
    }
}
