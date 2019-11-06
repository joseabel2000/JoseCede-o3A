using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaconClases.clases;
namespace FacturaconClases
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> ListadeClientes = new List<Cliente>();
            ListadeClientes.Add(new Cliente()
            {
                Nombre = "Milton Jimenez",
                Identificacion = "12326896",
                Direccion = "calle 7 y calle 8",
                Telefono=06658755
            });
        }
    }
}
