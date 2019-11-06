using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaconClases.clases
{
    class Factura
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private List<ProductoporFactura> listaProductoporFactura;

        public List<ProductoporFactura> ListaProductoporFactura
        {
            get { return listaProductoporFactura; }
            set { listaProductoporFactura = value; }
        }
        private int descuentoIngresado;

        public int Descuentoingresado
        {
            get { return descuentoIngresado; }
            set { descuentoIngresado = value; }
        }
        private float subtotal;

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private float descuento;

        public float Descuento
        {
            get { return ((Subtotal * Descuentoingresado) / 100); }

        }
        private float subtotalconDescuento;

        public float SubtotalconDescuento
        {
            get { return (Subtotal - Descuento); }

        }
        private float iva;

        public float Iva
        {
            get { return ((SubtotalconDescuento * 12) / 100); }

        }
        private float total;

        public float Total
        {
            get { return SubtotalconDescuento + Iva; }

        }

    }
}
    

