public class SimuladorTarifa
{
    public static void Main(string [] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("Simulador de Tarifa - InDrive");
        Console.WriteLine("================================");

        //Ingreso de datos
        Console.WriteLine("Nombre del Pasajero:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese distancia en km:");
        double distancia = double.Parse(Console.ReadLine());

        Console.WriteLine("Hora de salida (0 hrs - 23 hrs):");
        int hora = int.Parse(Console.ReadLine());

        string tipoVehiculo = Console.ReadLine();

        Console.WriteLine("\nTipo de Vehículo: ");
        Console.WriteLine("1. Económico");
        Console.WriteLine("2. Confort");
        Console.WriteLine("3. Premium");
        Console.WriteLine("4. Moto");
        Console.WriteLine("Seleccione el tipo de vehículo (1-4):");
        int tipoVehiculo = int.Parse(Console.ReadLine());

        //Proceso

    }
}