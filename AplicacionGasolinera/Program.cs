using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionGasolinera.clases;
namespace AplicacionGasolinera
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese los nombres del cliente:    ");
            cliente.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese los apellidos del cliente:   ");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de cedula del cliente:   ");
            cliente.Cedula = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion del domicilio del cliente:   ");
            cliente.Direccion = Console.ReadLine();



            Gasolina gasolina = new Gasolina();
            Console.WriteLine("Ingrese el tipo de gasolina:   ");
            gasolina.Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de galones a comprar:   ");
            gasolina.Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n\t\t\t *****Datos de la factura*****\n\n");
            cliente.imprimir();
            gasolina.imprimir();
            Console.ReadKey();

        }
    }
}
