using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaConClase.clases
{
    class Cliente
    {
        public string mostrarCliente()
        {
            return Identificacion + Nombre + Direccion + Telefono.ToString();
        }
        public override string ToString()
        {
            return Identificacion + "\\\\" + Nombre + "\\\\" + Direccion + "\\\\" + Telefono.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        private String identificacion;

        public String Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private float telefono;

        public float Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
