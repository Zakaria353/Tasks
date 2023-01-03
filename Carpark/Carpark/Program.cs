using Carpark;

public class Program
{
    public static void Main()
    {
        PassengerCar passcar = new PassengerCar();
        Console.WriteLine("Passenger car Engine properties");
        passcar.ShowEngine();
        Console.WriteLine("\nPassenger car Transmission properties");
        passcar.ShowTransmission();
        Console.WriteLine("\nPassenger car Chassis properties");
        passcar.ShowChassis();

        Truck trcar = new Truck();
        Console.WriteLine(new string('*', 70) + "\nTruck Engine properties");
        trcar.ShowEngine();
        Console.WriteLine("\nTruck Transmission properties");
        trcar.ShowTransmission();
        Console.WriteLine("\nTruck Chassis properties");
        trcar.ShowChassis();

        Bus bcar = new Bus();
        Console.WriteLine(new string('*', 70) + "\nBus Engine properties");
        bcar.ShowEngine();
        Console.WriteLine("\nBus Transmission properties");
        bcar.ShowTransmission();
        Console.WriteLine("\nBus Chassis properties");
        bcar.ShowChassis();

        Scooter scar = new Scooter();
        Console.WriteLine(new string('*', 70) + "\nScooter Engine properties");
        scar.ShowEngine();
        Console.WriteLine("\nScooter Transmission properties");
        scar.ShowTransmission();
        Console.WriteLine("\nScooter Chassis properties");
        scar.ShowChassis();
    }
}
