using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaconClases.clases
{
    class ProductoporFactura
    {
        public ProductoporFactura(int cantidad, float precio, Factura factura, List<Producto> listaProducto)
        {
            Cantidad = cantidad;
            Precio = precio;
            Factura = factura;
            ListaProducto = listaProducto;
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }
        private List<Producto> listaProducto;

        public List<Producto> ListaProducto
        {
            get { return listaProducto; }
            set { listaProducto = value; }
        }
        private float subtotalporProducto;



        public float Subtotalporproducto
        {
            get { return cantidad * precio; }

        }
    }
}

    