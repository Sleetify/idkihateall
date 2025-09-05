using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        static void ejer1()
        {
            string nombre, carrera;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso de FA de {carrera}");
        }
        static void ejer2()
        {
            Console.WriteLine("\"Yordan\"");
        }
    }
}
