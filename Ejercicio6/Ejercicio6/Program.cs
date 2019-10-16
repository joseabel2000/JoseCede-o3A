using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el número para generar el rombo:   ");
            int Num = Convert.ToInt16(Console.ReadLine());
            for (int Line = 0; Line <= Num; Line++)
            {
                for (int Esp = 0; Esp < Num - Line; Esp++)
                {
                    Console.Write(" ");
                }
                for (int Astersc = 0; Astersc < (Line * 2) - 1; Astersc++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int Line = Num - 2; Line >= 0; Line--)
            {
                for (int Esp = 1; Esp < Num - Line; Esp++)
                {
                    Console.Write(" ");
                }
                for (int Astersc = 0; Astersc <= (Line * 2); Astersc++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
