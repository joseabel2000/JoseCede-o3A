using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PilaConClase.clases;
namespace PilaConClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack < Producto >PiladeProductos= new Stack<Producto>();
            PiladeProductos.Push(new Producto()
            {
                Codigo = 00004,
                Descripcion = "Soda Coca Cola",
                Precio = 3
            });
            PiladeProductos.Push(new Producto()
            {
                Codigo = 000005,
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
                Codigo = 00007,
                Descripcion="Atun Isabel",
                Precio=2
            });
            PiladeProductos.Push(new Producto()
            {
                Codigo = 00008,
                Descripcion = "Mayonesa Maggi",
                Precio = 4
            });
            PiladeProductos.Pop();
            PiladeProductos.Peek();
            foreach (Producto item in PiladeProductos )
            {
                Console.WriteLine(item.mostrarProducto());
            }
            Console.ReadKey();
        }
    }
}
