using Ejercicio02.Entidades;
using MiDLL;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int dia = ConsoleExtensions.ReadInt("Ingrese el día:");

            Console.WriteLine("Ingrese el mes:");
            int mes = ConsoleExtensions.ReadInt("Ingrese el mes:");

            Console.WriteLine("Ingrese el año:");
            int anio = ConsoleExtensions.ReadInt("Ingrese el año:");

            
            if (ValidarFecha.Validar(dia, mes, anio))
            {
                Console.WriteLine("La fecha es válida.");
            }
            else
            {
                Console.WriteLine("La fecha no es válida.");
            }
        }
    }
}
