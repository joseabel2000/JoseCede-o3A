using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaconClases.clases
{
    class Cliente
    {
        public string mostrarCliente()
        {
            return Identificacion + Nombre + Direccion + Telefono.ToString();
        }
        public override string ToString()
        {
            return Identificacion.ToString() + " - " + Nombre + " - " + Direccion + "-" + Telefono.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
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
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private List<Factura> listaFactura;
        public List<Factura> Listafactura
        {
            get { return listaFactura; }
            set { listaFactura = value; }
        }

    }
}

 