using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14TP2
{
    internal class Medicamento : IServicio
    {
        public string Nombre { get; set; }
        public decimal Ganancia { get; set; }
        public decimal PrecioLista { get; set; }


        public Medicamento(string nombre, decimal ganancia, decimal precioLista)
        {
            Nombre = nombre;
            Ganancia = ganancia;
            PrecioLista = precioLista;
        }
        public decimal calcularPrecio()
        {
            decimal ganancia = PrecioLista * Ganancia;
            return ((ganancia + PrecioLista) * 1.21m);
        }

        public void mostrarDetalle()
        {
            Console.WriteLine("Detalle del medicamento: " + Nombre);
            Console.WriteLine("Ganancia: " + Ganancia);
            Console.WriteLine("PrecioLista: " + PrecioLista);
            Console.WriteLine("Precio: " + this.calcularPrecio());
        }

        public string mostrarMenuServicio()
        {
            throw new NotImplementedException();
        }
    }
}
