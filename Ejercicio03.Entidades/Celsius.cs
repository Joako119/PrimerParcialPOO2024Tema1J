using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio03.Entidades
{
    public class Celsius
    {
        private float grados;

        public float Grados { get => grados; set => grados = value; }

        public Celsius(float grados)
        {
            if (grados >0)
            {
                Grados = grados; 
            }throw new ArgumentException("Valor mal ingresado.");
        }

        public Celsius() : this(5)
        { }


        public float GetGrados()
        {
            return Grados;
        }

        public static explicit operator Fahrenheit(Celsius celsius)
        {
            if (celsius is null)
            {
                throw new ArgumentException("Valor no Ingresado");
            }
            float grado = celsius.Grados*(9/5)+32;
            Fahrenheit fahrenheit = new Fahrenheit(grado);
            return fahrenheit;
        }

     




        public static bool operator ==(Celsius celsius, Celsius celsius1)
        {
            if (celsius is null || celsius1 is null)
            {
                return false;
            }

            if (celsius.Grados == celsius1.Grados)
            {
                return true;
            }

            return false;
        }


        public static bool operator !=(Celsius celsius,Celsius celsius1)
        {
            return !(celsius == celsius1);
        }



        public static Celsius operator +(Celsius celsius, Celsius celsius1)
        {
            int grado1 = (int)celsius.grados;

            int grado2 = (int)celsius1.grados;
            int grados = grado1 + grado2;
            Celsius celsius2 = new Celsius(grados);
            return celsius2 ;

        }



    }
}
