using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyVentas_BE
{
    public class OrdenBE
    {
        public String NumOco
        {
            get ;
            set ;
        }
        public System.DateTime FecOco
        {
            get;
            set;
        }
        public String CodPrv
        {
            get;
            set;
        }
        public System.DateTime FecAte
        {
            get;
            set;
        }
        public String EstOco
        {
            get;
            set;
        }

        // Para el detalle
        private DataTable Detalles;
        public DataTable DetallesOC
        {
            get { return Detalles; }
            set { Detalles = value; }

        }

        // Propiedades de Auditoria
      
        public DateTime Fec_Registro
        {
            get;
            set;
        }

       
        public String Usu_Registro
        {
            get;
            set;
        }

       
        public DateTime Fec_Ult_Mod
        {
            get;
            set;
        }

      
        public String Usu_Ult_Mod
        {
            get;
            set;
        }
    }
}
