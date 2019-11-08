using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGasolinera.clases
{
    class Cliente
    {
        private String cedula;

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private String nombres;

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public void imprimir()
        {
            Console.WriteLine("Cedula del cliente: \t\t\t" + Cedula);
            Console.WriteLine("Nombres del cliente: \t\t\t\t" + Nombres);
            Console.WriteLine("Apellidos del cliente: \t\t\t\t" + Apellidos);
            Console.WriteLine("Direccion del cliente: \t\t\t" + Direccion);
        }
    }
}