using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03.Entidades
{
    public class Fahrenheit
    {
        private float grados;

        public float Grados { get => grados; set => grados = value; }

        public Fahrenheit(float grados)
        {
            Grados = grados;
        }

        public Fahrenheit():this(5)
        { }

        
        public float GetGrados()
        {
            return Grados;
        }


        

        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            if (fahrenheit is null)
            {
                throw new ArgumentException("Valor no Ingresado");
            }
            float grados = (fahrenheit.Grados - 32) * 5 / 9;
            Celsius celsius = new Celsius(grados);

            return celsius;
        }

        public static bool operator ==(Fahrenheit fahrenheit, Fahrenheit fahrenheit1)
        {
            if (fahrenheit is null || fahrenheit1 is null)
            {
                return false;
            }

            if (fahrenheit.Grados == fahrenheit1.Grados)
            {
                return true;
            }

            return false;
        }
        public static Fahrenheit operator +(Fahrenheit fahrenheit, Fahrenheit fahrenheit1)
        {
            int grado1 =(int) fahrenheit.grados;

            int grado2 = (int)fahrenheit1.grados;
            int grados = grado1 = grado2;
            Fahrenheit fahrenheit2= new Fahrenheit(grados);
            return fahrenheit2;

        }

        public static bool operator !=(Fahrenheit fahrenheit,Fahrenheit fahrenheit1)
        {
            return !( fahrenheit== fahrenheit1 );
        }


    }
}
