using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGestionDoc_BE
{
    public class PersonaBE
    {
        public String Nro_doc { get; set; }
        public String Nom_per { get; set; }
        public String Ape_per { get; set; }
        public String Edad { get; set; }
        public String Dir_per { get; set; }
        public DateTime Fec_reg { get; set; }

        public Int16 Est_per { get; set; }

        public Int16 Doc_ide { get; set; }
        public Int16 Gen_per { get; set; }
        public Int16 Tip_per { get; set; }
        public Int16 Id_Nac { get; set; }
        public Byte[] Foto { get; set; }
        public String Usu_reg { get; set; }
    }
}
