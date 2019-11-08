using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGasolinera.clases
{
    class Gasolina
    {
        private String tipo;
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private float cantidad;
        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private double costo;
        public double Costo
        {
            get {
                if (this.Tipo == "EXTRA")
                {
                    costo = 1.5;
                }
                else
                {
                    if (this.Tipo == "SUPER")
                    {
                        costo = 2;
                    }
                }
                return costo;
            }
        }
        private double preciodeventa;
        public double PreciodeVenta
        {
            get
            { 
                preciodeventa=Cantidad*Costo;
                return preciodeventa;
            }
        }
        private double iva;

        public double Iva
        {
            get {
                iva = (PreciodeVenta * 12) / 100;
                return iva;
            }
        }
        private double totalconiva;
        public double TotalconIva
        {
            get {
                totalconiva = PreciodeVenta + Iva;
                return totalconiva;
            }
        }
        public void imprimir()
        {
            Console.WriteLine("Tipo de gasolina: \t\t\t" +Tipo);
            Console.WriteLine("Cantidad de galones: \t\t\t\t" + Cantidad);
            Console.WriteLine("Costo: \t\t\t\t" + Costo);
            Console.WriteLine("Precio de venta: \t\t\t" + PreciodeVenta);
            Console.WriteLine("Iva 12%: \t\t\t" + Iva);
            Console.WriteLine("Total Final: \t\t\t\t" + TotalconIva);
        }
    }
}

