public class SimuladorTarifa
{
    public static void Main(string [] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("Simulador de Tarifa - InDrive");
        Console.WriteLine("================================");

        //Ingreso de datos
        //Declaración de variables
        string nombre, nombreVehiculo;
        double distancia, tarifaBase, costoKm, subtotal, tarifaFinal, descuento = 0.00;
        int hora, tipoVehiculo;
        bool esHoraPico = false;

        Console.WriteLine("Nombre del Pasajero:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese distancia en km:");
        distancia = double.Parse(Console.ReadLine());

        Console.WriteLine("Hora de salida (0 hrs - 23 hrs):");
        hora = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTipo de Vehículo: ");
        Console.WriteLine("1. Económico");
        Console.WriteLine("2. Confort");
        Console.WriteLine("3. Premium");
        Console.WriteLine("4. Moto");
        Console.WriteLine("Seleccione el tipo de vehículo (1-4):");
        tipoVehiculo = int.Parse(Console.ReadLine());

        //Proceso

        switch (tipoVehiculo)
        {
            case 1: // Económico
                nombreVehiculo = "Económico";
                tarifaBase = 2.0;
                costoKm = 1.5;
                break;
            case 2:// Confort
                nombreVehiculo = "Confort";
                tarifaBase = 3.0;
                costoKm = 2.0;
                break;
            case 3:// Premium
                nombreVehiculo = "Premium";
                tarifaBase = 5.0;
                costoKm = 3.0;
                break;
            case 4:// Moto
                nombreVehiculo = "Moto";
                tarifaBase = 1.5;
                costoKm = 1.0;
                break;
            default:
                Console.WriteLine("\nOpción no válida. Finalizando simulación.");
                return;
        }

        // Cálculo de Subtotal Base
        subtotal = tarifaBase + (costoKm * distancia);
        // Condicional de Recargo Hora Pico
        if((hora >=7 && hora <=9) || (hora >=17 && hora <=20))
        {
            esHoraPico = true;
            subtotal = subtotal * 1.30; // Recargo del 30%
        }

        //Descuento por distancia larga (5%)
        if(distancia > 15)
        {
            descuento = subtotal * 0.05;
            subtotal = subtotal - descuento;
        }

        // Tarifa mínima y redondeo
        tarifaFinal = Math.Max(subtotal, 5.00);
        tarifaFinal = Math.Round(tarifaFinal, 2);

        //Salida - Resumen de viaje
        Console.WriteLine("\n================================");
        Console.WriteLine("Resumen de la Simulación:");
        Console.WriteLine("================================");
        Console.WriteLine("Pasajero: " + nombre);
        Console.WriteLine("Vehículo: " + nombreVehiculo);
        Console.WriteLine("Distancia: " + distancia + " km");
        Console.WriteLine("Hora Pico: " + (esHoraPico ? "Sí (+30%)" : "No"));
        if(descuento > 0)
        {
            Console.WriteLine("Descuento: S/ " + Math.Round(descuento, 2));
        }else
        {
            Console.WriteLine("Descuento: No aplica");
        }

        Console.WriteLine("================================");
        Console.WriteLine("Tarifa Final: S/ " + tarifaFinal);
    }
}