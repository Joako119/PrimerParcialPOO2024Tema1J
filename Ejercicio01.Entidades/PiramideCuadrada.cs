using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Entidades
{
    public class PiramideCuadrada
    {
        private readonly int Lado;
        private readonly int Altura;
        private double Apotema;
        public PiramideCuadrada(int lado, int altura)
        {
            if (lado > 0 && altura > 0)
            {

                Lado = lado;
                Altura = altura;

                Apotema = Math.Sqrt(Math.Pow(lado / 2, 2) + Math.Pow(altura, 2));

                double apotema = Apotema;

            }
            else
            {
                throw new ArgumentException("Valores mal ingresados");
            }

        }
    
    
    public double GetArea()
        {
            return areaBase()+areaLateral();
        }
    
    public double areaBase()
        {
            return Math.Pow(Lado,2);
        }
    
    public double areaLateral()
        {
            return 2 * Lado * Apotema;
        }
    
    public double GetVolumen()
        {
            return (Math.Pow(Lado,2) * Altura) / 3;
        }


        public string MostrarDatos()
        {
          
            return $"\nArea:   {GetArea()}," +
                   $"\nVolumen: {GetVolumen()}" +
                   $"\nApotema: {Apotema} ";
            
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    } 
}
