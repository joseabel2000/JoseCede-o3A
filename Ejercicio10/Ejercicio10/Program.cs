using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int option, n1, n2, SUMATORIA = 0;
            do
            {
                Console.WriteLine("Escoja la opción que desee");
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Sumatorio");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Elija la opción");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingrese el número");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        int factorial = 1;
                        while (n1 != 0)
                        {
                            factorial *= n1;
                            n1--;
                        }
                        Console.WriteLine("El factorial es: " + factorial);
                        break;
                    case 2:
                        Console.Write("Ingrese el primer número:  ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el segundo número:  ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        SUMATORIA = n1 + n2;
                        Console.WriteLine("La sumatoria es: " + SUMATORIA);
                        break;
                    case 3:
                        Console.WriteLine("Gracias por su visita");
                        break;
                    default:
                        Console.WriteLine("No es una opción");
                        break;
                }
            } while (option != 3);
            Console.ReadKey();
        }
    }
}
