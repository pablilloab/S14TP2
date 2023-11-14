namespace S14TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clinica saludAr = new Clinica("SaludAr");

            //saludAr.mostrarMenuPrincipal();
            //int opcion = int.Parse(Console.ReadLine());

            int opcion;

            do
            {
                saludAr.mostrarMenuPrincipal();

                // Intenta convertir la entrada del usuario a un entero
                // Si no es válido, mostrará un mensaje de error y pedirá la entrada nuevamente.
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("Por favor, ingrese un entero válido entre 1 y 3.");
                }

            } while (opcion < 1 || opcion > 3);

            while ( opcion != 3 )
            {
                switch ( opcion )
                {
                    case 1:
                        saludAr.agregarServicio();
                    break;
                    case 2:
                        saludAr.mostrarDetalleServicio();
                    break;
                    default:
                        Console.WriteLine("Algo salio mal");
                    break;
                }

                saludAr.mostrarMenuPrincipal();
                opcion = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Monto total facturado: " + saludAr.montoTotalFacturado());
            Console.WriteLine("Cantidad Servicios Simples: " + saludAr.cantServiciosSimples());


        }
    }
}