using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número:  ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int line = 0; line <= num; line++)
            {
                for (int espc = 0; espc < num - line; espc++)
                {
                    Console.Write(" ");
                }
                for (int astersc = 0; astersc < (line * 2) - 1; astersc++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
