using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para generar el cuadrado de asteriscos:  ");
            int numero = Convert.ToInt32(Console.ReadLine());
            //Linea superior
            for (int i = 0; i < numero; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            //centro del cuadrado
            for (int i = 0; i < numero - 2; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < numero - 2; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("* ");
            }
            //linea inferior 
            for (int i = 0; i < numero; i++)
            {
                Console.Write("* ");
            }
            Console.ReadKey();

        }
    }
}
