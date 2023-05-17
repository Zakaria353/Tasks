using Carpark;

internal class PassengerCar
{   
    public const int passengerField = 6;

    public void ShowEngine()
    {
        Engine[] engines = { new Engine(160, 2.0m, "Gasoline", "PP61B564D64") };
        foreach (Engine engine in engines)
        {
            Console.WriteLine(engine);
        }
    }

    public void ShowTransmission()
    {
        Transmission[] transmissions = { new Transmission("Manual", 5, "Axle.inc") };
        foreach (Transmission trans in transmissions)
        {
            Console.WriteLine(trans);
        }
    }

    public void ShowChassis()
    {
        Chassis[] chassis = { new Chassis("624550/R17 85H", 17, "1135 lbs") };
        foreach (Chassis chassy in chassis)
        {
            Console.WriteLine(chassy);
        }
    }
}
