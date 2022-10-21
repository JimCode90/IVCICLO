using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGestionDoc_BE
{
    public class UsuarioBE
    {
        public string nroCip { get; set; }
        public Int16 idTipoGrado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string nroDNI { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public Int16 idRol { get; set; }
        public Int16 idUnidad { get; set; }
        public Int16 estado { get; set; }
        /*public DateTime fechaRegistro { get; set; }
        public string usuRegistro { get; set; }
        */



    }
}
