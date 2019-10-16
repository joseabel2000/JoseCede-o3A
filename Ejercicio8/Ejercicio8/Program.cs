using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int colum1 = 0, colum2 = 0, colum3 = 0;
            Console.WriteLine("Ingrese el número que desea:  ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                while (colum1 < numero)
                {
                    colum1++;
                    if (colum1 <= numero)
                    {
                        Console.Write("   " + colum1 + "  ");
                    }
                    colum2 = colum2 + 2;
                    if (colum2 <= numero)
                    {
                        Console.Write("   " + colum2 + "  ");
                    }
                    colum3 = colum3 + 3;
                    if (colum3 <= numero)
                    {
                        Console.Write("   " + colum3 + "  ");
                    }
                    Console.WriteLine("  ");
                }
            }
            Console.ReadKey();
        }
    }
}
