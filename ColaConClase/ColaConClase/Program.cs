using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColaConClase.clases;
namespace ColaConClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Cliente> ColadeClientes = new Queue<Cliente>();
            ColadeClientes.Enqueue(new Cliente()
            {
                Identificacion = "131269945",
                Nombre = "Lucas Beltran",
                Direccion = "Calle Chile y Calle Espana",
                Telefono = 098895463
            });
            ColadeClientes.Enqueue(new Cliente()
            {
                Identificacion = "130245876",
                Nombre = "Pepe Cadena",
                Direccion = "Av. Francisco de Orellana y Juan montalvo",
                Telefono = 2564876
            });
            ColadeClientes.Enqueue(new Cliente()
            {
                Identificacion = "125469752",
                Nombre = "Carlos Orlando",
                Direccion = "Calle 45 y Calle 60",
                Telefono = 098756421
            });
            ColadeClientes.Enqueue(new Cliente()
            {
                Identificacion = "64663279",
                Nombre = "Amparo Velez",
                Direccion = "Vicente Rocafuerte y Espejo",
                Telefono = 2353246
            });
            ColadeClientes.Enqueue(new Cliente()
            {
                Identificacion = "132479654",
                Nombre = "Milton Jimenez",
                Direccion = "Av. Universitario y Bolivar",
                Telefono = 098654231
            });
            ColadeClientes.Dequeue();
            foreach (Cliente item in ColadeClientes)
            {
                Console.WriteLine(item.mostrarCliente());
            }
            Console.ReadKey();
        }
    }
}
