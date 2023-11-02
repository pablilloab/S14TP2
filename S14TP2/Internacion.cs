using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14TP2
{
    internal class Internacion : IServicio
    {
        public string Nombre { get; set; }
        public int CantidadDiasInternacion { get; set; }

        private const int valorInternacion = 20000;

        public Internacion(string nombre, int cantidadDias) 
        {
            Nombre = nombre;
            CantidadDiasInternacion = cantidadDias;
        }

        public decimal calcularPrecio()
        {
            decimal iva = ((CantidadDiasInternacion * valorInternacion)) * 0.21m / 2;
            return CantidadDiasInternacion * valorInternacion + iva;
        }

        public void mostrarDetalle()
        {
            Console.WriteLine("Detalle para el servicio de Internación: " + Nombre);
            Console.WriteLine("Cantidad de días: " + CantidadDiasInternacion);
            Console.WriteLine("Valor Internación por día: " + valorInternacion);
            Console.WriteLine("Precio: " + this.calcularPrecio());
        }

        public string mostrarMenuServicio()
        {
            throw new NotImplementedException();
        }
    }
}
