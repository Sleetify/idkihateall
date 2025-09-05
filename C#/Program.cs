using System;
using System.Collections.Generic;
using System.Dynamic;
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
        static void ejer3() 
        {
            Console.Write("Ingrese número 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double divi = x / y;

            Console.WriteLine("\nSuma: " + (x + y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicación: " + (x * y));
            Console.WriteLine("División: " + (x / y));
        }
    }
}
