// See https://aka.ms/new-console-template for more information

using Laboratorio_1C;


Automovil automovil = new Automovil("Toyota","QR3",2002,"10kh");


Camion camion = new Camion("Samsung","APD43",2002,29.7);


List<Vehiculo> vehiculos = new List<Vehiculo>
{
    automovil, camion
};

Flota flota = new Flota(vehiculos);




while (true)
{
    Console.WriteLine("1. Mostrar inforamción de Vehiculos");
    Console.WriteLine("2. Calculo de Viaje");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");

    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        flota.MostrarFlota();
    }
    else if (opcion == "2")
    {
        Console.WriteLine("Costo de viaje de 100000000K soles");
    }
    else if (opcion == "3")
    {
        Console.WriteLine("Saliendo del programa...");
        break;
    }
    else
    {
        Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
    }

    Console.WriteLine();
}