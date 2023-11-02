namespace S14TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clinica saludAr = new Clinica("SaludAr");

            saludAr.mostrarMenuPrincipal();
            int opcion = int.Parse(Console.ReadLine());

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