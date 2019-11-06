using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3.clases
{
    class Producto
    {
        public string mostrarProducto()
        {
            return Codigo.ToString() + Descripcion + Precio.ToString();
        }
        public override string ToString()
        {
            return "Code-->" + Codigo.ToString() + "<----->" + Descripcion + "<----->" + Precio.ToString() + "$";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
