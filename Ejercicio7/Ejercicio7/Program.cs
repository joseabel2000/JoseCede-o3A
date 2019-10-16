using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0, d = 101;
            do
            {
                c++;
                d--;
                Console.WriteLine(" {0} {1} ", c, d);
            } while (c < 101 && d > 1);
            Console.ReadKey();
        }
    }
}
