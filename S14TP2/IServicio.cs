using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace S14TP2
{
    internal interface IServicio
    {
        string Nombre { get; set; }
        decimal calcularPrecio();
        void mostrarDetalle();
        string mostrarMenuServicio();

    }
}
