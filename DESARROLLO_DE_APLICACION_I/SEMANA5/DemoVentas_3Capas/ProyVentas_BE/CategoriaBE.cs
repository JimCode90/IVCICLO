using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyVentas_BE
{
    public class CategoriaBE
    {

        public Int16 Id_Cat { get; set; } 
       
        public String Des_Cat { get; set; } 
        
        // Propiedad tipo Array de Bytes para la foto
       
        public Byte[] Foto_Cat { get; set; } 
        

    }
}
