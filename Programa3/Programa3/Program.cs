using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa3.clases;
namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Producto> PiladeProductos = new Stack<Producto>();
            PiladeProductos.Push(new Producto()
            {
                Codigo=00004,
                Descripcion="Soda Coca Cola",
                Precio=3
            });
            PiladeProductos.Push(new Producto()
            {
                Codigo = 00005,
                Descripcion = "Aji Pica Pica",
                Precio = 1
            });
            PiladeProductos.Push(new Producto()
            {
                Codigo = 00006,
                Descripcion = "Arroz flor",
                Precio = 40
            });
            PiladeProductos.Push(new Producto() 
            { 
                 Codigo=000007,
                 Descripcion="Atun Isabel",
                 Precio=2
            });
            PiladeProductos.Push(new Producto()
            {
                Codigo = 00008,
                Descripcion = "Mayonesa Maggi",
                Precio = 4
            });
            foreach (Producto item in PiladeProductos)
            {
                Console.WriteLine(item.mostrarProducto());
            }
            Console.ReadKey();
           
            
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



