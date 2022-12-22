using Carpark;

public class Program
{
    public static void Main()
    {
        PassengerCar passcar = new PassengerCar();
        Console.WriteLine("Passenger car Engine properties");
        passcar.showEngine();
        Console.WriteLine("\nPassenger car Transmission properties");
        passcar.showTransmission();
        Console.WriteLine("\nPassenger car Chassis properties");
        passcar.showChassis();

        Truck trcar = new Truck();
        Console.WriteLine(new string('*', 70) + "\nTruck Engine properties");
        trcar.showEngine();
        Console.WriteLine("\nTruck Transmission properties");
        trcar.showTransmission();
        Console.WriteLine("\nTruck Chassis properties");
        trcar.showChassis();

        Bus bcar = new Bus();
        Console.WriteLine(new string('*', 70) + "\nBus Engine properties");
        bcar.showEngine();
        Console.WriteLine("\nBus Transmission properties");
        bcar.showTransmission();
        Console.WriteLine("\nBus Chassis properties");
        bcar.showChassis();

        Scooter scar = new Scooter();
        Console.WriteLine(new string('*', 70) + "\nScooter Engine properties");
        scar.showEngine();
        Console.WriteLine("\nScooter Transmission properties");
        scar.showTransmission();
        Console.WriteLine("\nScooter Chassis properties");
        scar.showChassis();
    }
}
