using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14TP2
{
    internal class Laboratorio : IServicio
    {
        public string Nombre { get; set; }
        public int CantidadDias { get; set; }
        public int Complejidad { get; set; }

        private const int valorEstudio = 10000;

        public Laboratorio(string nombre, int cantidadDias, int complejidad)
        {
            Nombre = nombre;
            CantidadDias = cantidadDias;
            Complejidad = complejidad;
        }

        public decimal calcularPrecio()
        {
            decimal iva = (CantidadDias * valorEstudio) * 0.21m / 2;
            if (Complejidad > 3)
            {
                return ((CantidadDias * valorEstudio) + iva) * 1.25m;
            }
            return (CantidadDias * valorEstudio) + iva;
        }

        public void mostrarDetalle()
        {
            Console.WriteLine("Detalle del Laboratorio: " + Nombre);
            Console.WriteLine("Cantidad de días: " + CantidadDias);
            Console.WriteLine("Complejidad: " + Complejidad);
            Console.WriteLine("Valor diaria de estudio: " + valorEstudio);
            Console.WriteLine("Precio: " + this.calcularPrecio()) ;

        }

        public string mostrarMenuServicio()
        {
            throw new NotImplementedException();
        }
    }
}
