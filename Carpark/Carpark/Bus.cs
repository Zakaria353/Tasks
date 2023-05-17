namespace Carpark;

internal class Bus
{
    public readonly string busField = "Transport is a school bus and its yellow";

    public void ShowEngine()
    {
        Engine[] engines = { new Engine(300, 6.7m, "Diesel", "BB1B59FD74O") };
        foreach (Engine engine in engines)
        {
            Console.WriteLine(engine);
        }
    }

    public void ShowTransmission()
    {
        Transmission[] transmissions = { new Transmission("Manual", 4, "BeP.inc") };
        foreach (Transmission trans in transmissions)
        {
            Console.WriteLine(trans);
        }
    }

    public void ShowChassis()
    {
        Chassis[] chassis = { new Chassis("315/80R22.5", 22.5m, "992 lbs") };
        foreach (Chassis chassy in chassis)
        {
            Console.WriteLine(chassy);
        }
    }
}
