using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño de la serie de números:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[n];
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Ingrese dato " + (i + 1) + ":  ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int mayor;
            mayor = Array[0];
            for (int j = 0; j < Array.Length; j++)
            {
                if (Array[j] > mayor)
                {
                    mayor = Array[j];
                }
            }
            Console.WriteLine("El número mayor es:   " + mayor);
            Console.ReadKey();
        }
    }
}
