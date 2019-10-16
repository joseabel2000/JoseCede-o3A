using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantidad, precio, total;
            Console.WriteLine("Ingrese la cantidad:  ");
            cantidad = Convert.ToDouble(Console.ReadLine());
            if (cantidad != 0)
            {
                Console.WriteLine("Ingrese el precio:  ");
                precio = Convert.ToDouble(Console.ReadLine());
                total = Convert.ToDouble(cantidad * precio);
                Console.WriteLine("El total a pagar:  " + total);
            }
            else
            {
                Console.WriteLine("Gracias por su visita");
            }
            Console.ReadKey();
        }
    }
}
