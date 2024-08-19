using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Entidades
{
    public class ValidarFecha
    {
       
        public static bool Validar(int dia, int mes, int anio)
        {
  
            if (mes < 1 || mes > 12)
            {
                return false;
            }

        
            int[] diasPorMes = { 31, EsBisiesto(anio) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (dia < 1 || dia > diasPorMes[mes - 1])
            {
                return false;
            }

      
            if (anio < 1)
            {
                return false;
            }

            return true;
        }

     
        private static bool EsBisiesto(int anio)
        {
            return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
        }
    }
}
