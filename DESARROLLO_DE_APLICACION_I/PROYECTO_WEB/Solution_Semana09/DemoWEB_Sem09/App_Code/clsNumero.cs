using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    public class clsNumero 
    {
      public double Factorial(double valor)
        {
            double vfact = 1;
            long z = 0;
            try
            {
                for (z = 1; z <= valor; z++)
                {
                    vfact = vfact * z;
                }
                return vfact;
            }
            catch (Exception ex)
            {
                throw new 
                Exception("Valor muy Grande" + ex.Message);
            }
        }
      
        public bool EsPrimo(double valor)
        {
            double  x = 0;
            for (x = 1; x <= valor; x++)
            {
                if (x != 1 & x != valor)
                {
                    if (valor % x == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


    }


