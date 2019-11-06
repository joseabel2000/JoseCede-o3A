using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaconClases.clases
{
    class Producto
    {
        private String codigo;
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private String descripion;
        public String Descripcion
        {
            get { return descripion; }
            set { descripion = value; }
        }
        private float precio;
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private List<ProductoporFactura> listaProductoporFactura;

        public List<ProductoporFactura> ListaProductoporFactura
        {
            get { return listaProductoporFactura; }
            set { listaProductoporFactura = value; }
        }

    }
}
    

