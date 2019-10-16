using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las horas trabajadas:  ");
            int horas = Convert.ToInt16(Console.ReadLine());

            if (horas <= 35)
            {
                int salarionormal = horas * 15;
                Console.WriteLine("Su salario es:  $" + salarionormal);
                Console.ReadKey();
            }
            else
            {
                int horasextras = horas - 35;
                int aumento = horasextras * 22;
                int salariototal = 525 + aumento;
                Console.WriteLine("Su salario con horas extras aplicadas es:   $" + salariototal);

            }
            int opcion;
            do
            {
                Console.WriteLine("¿Desea calcular otro sueldo?");
                Console.WriteLine("1. SI");
                Console.WriteLine("2.NO");
                Console.WriteLine("Escoja una opción");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese las horas trabajadas:  ");
                        horas = Convert.ToInt16(Console.ReadLine());

                        if (horas <= 35)
                        {
                            int salarionormal = horas * 15;
                            Console.WriteLine("Su salario es:  $" + salarionormal);
                            Console.ReadKey();
                        }
                        else
                        {
                            int horasextras = horas - 35;
                            int aumento = horasextras * 22;
                            int salariototal = 525 + aumento;
                            Console.WriteLine("Su salario con horas extras aplicadas es:   $" + salariototal);

                        }
                        break;
                    case 2:
                        Console.WriteLine("Muchas gracias");
                        break;
                    default:
                        break;

                }

            } while (opcion != 2);
            Console.ReadKey();

        }
    }
}
