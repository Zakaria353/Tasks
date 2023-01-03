namespace Carpark;

internal class Truck
{
    public void ShowEngine()
    {
        Engine[] engines = { new Engine(560, 14.8m, "Diesel", "TT371B56FD64U") };
        foreach (Engine engine in engines)
        {
            Console.WriteLine(engine);
        }
    }

    public void ShowTransmission()
    {
        Transmission[] transmissions = { new Transmission("9G-Tronic", 9, "eZx.inc") };
        foreach (Transmission trans in transmissions)
        {
            Console.WriteLine(trans);
        }
    }

    public void ShowChassis()
    {
        Chassis[] chassis = { new Chassis("P215/65R20 98H", 20, "1653 lbs") };
        foreach (Chassis chassy in chassis)
        {
            Console.WriteLine(chassy);
        }
    }
}
