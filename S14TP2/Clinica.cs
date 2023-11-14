using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14TP2
{
    internal class Clinica
    {
        private string nombre;
        List<IServicio> servicios;

        public Clinica (string nombre)
        {
            this.nombre = nombre;
            servicios = new List<IServicio> ();
        }

        public void mostrarMenuPrincipal()
        {
            Console.WriteLine("Bienvenidos a SaludAr - Menú Principal");
            Console.WriteLine("Ingrese su opción");
            Console.WriteLine("1 - Agregar nuevo servicio");
            Console.WriteLine("2 - Mostrar detalles de los servicios");
            Console.WriteLine("3 - Salir del Programa");
        }

        public void agregarServicio()
        {
            string servicio = "";
            Console.Write("Que tipo de Servicio desea agregar? ");

            //servicio = Console.ReadLine();

            do
            {
                Console.WriteLine("Por favor, ingrese 'laboratorio', 'medicamento' o 'internacion':");
                servicio = Console.ReadLine().ToLower();

            } while (servicio != "laboratorio" && servicio != "medicamento" && servicio != "internacion");

            switch (servicio.ToLower())
            {
                case "medicamento":
                    Console.WriteLine("Ingrese el nombre del medicamento");
                    string nombreMedicamento = Console.ReadLine();

                    Console.WriteLine("Ingrese la ganancia");
                    decimal ganancia = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el precio de Lista");
                    decimal precioLista = decimal.Parse(Console.ReadLine());

                    Medicamento medicamento = new Medicamento(nombreMedicamento, ganancia, precioLista);

                    servicios.Add(medicamento);

                    Console.WriteLine("Servicio agregado exitosamente");
                    break;

                case "laboratorio":
                    Console.WriteLine("Ingrese el nombre del servicio del Laboratorio");
                    string nombreLaboratorio = Console.ReadLine();

                    Console.WriteLine("Ingrese la cantidad de días");
                    int cantidadDias = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el nivel de complejidad (1-5)");

                    //int complejidad = int.Parse(Console.ReadLine());
                    int complejidad;

                    do
                    {
                        // Intenta convertir la entrada del usuario a un entero
                        // Si no es válido, mostrará un mensaje de error y pedirá la entrada nuevamente.
                        while (!int.TryParse(Console.ReadLine(), out complejidad) || complejidad < 1 || complejidad > 5)
                        {
                            Console.WriteLine("Por favor, ingrese un entero válido entre 1 y 5.");
                        }

                    } while (complejidad < 1 || complejidad > 5);

                    Laboratorio laboratorio = new Laboratorio(nombreLaboratorio, cantidadDias, complejidad);

                    servicios.Add(laboratorio);

                    Console.WriteLine("Servicio agregado exitosamente");
                    break;

                case "internacion":
                    Console.WriteLine("Ingrese el nombre de la especialidad");
                    string nombreEspecialidad = Console.ReadLine();

                    Console.WriteLine("Ingrese la cantidad de dias de internación");
                    int dias = int.Parse(Console.ReadLine());

                    Internacion internacion = new Internacion(nombreEspecialidad, dias);

                    servicios.Add(internacion);

                    Console.WriteLine("Servicio agregado exitosamente");
                    break;

                default:
                    Console.WriteLine("Servicio incorecto");
                    break;
            }
        }

        public void mostrarDetalleServicio()
        {
            foreach (IServicio servicio in  servicios)
            {
                servicio.mostrarDetalle();
            }
        }

        public decimal montoTotalFacturado()
        {
            decimal totalFacturado = 0;
            foreach(IServicio servicio in servicios)
            {
                totalFacturado += servicio.calcularPrecio();
            }

            return totalFacturado;
        }

        public int cantServiciosSimples()
        {
            int cantidadServiciosSimples = 0;

            foreach(IServicio servicio in servicios)
            {
                if (servicio is Laboratorio)
                {
                    Laboratorio lab = (Laboratorio)servicio;
                    if(lab.Complejidad < 3)
                    {
                        cantidadServiciosSimples++;
                    }
                }
            }

            return cantidadServiciosSimples;
        }
    }
}
