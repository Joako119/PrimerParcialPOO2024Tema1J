using Ejercicio01.Entidades;
using MiDLL;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = ConsoleExtensions.ReadInt("Ingresar el valor de la altura: ");
            int lado = ConsoleExtensions.ReadInt("Ingresar e lvalor del lado: ");
            PiramideCuadrada piramideCuadrada=new PiramideCuadrada(lado, altura);
            Console.WriteLine(piramideCuadrada.MostrarDatos().ToString());
        }
    }
}
