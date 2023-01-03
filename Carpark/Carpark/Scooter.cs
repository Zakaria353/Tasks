namespace Carpark;

internal class Scooter
{
    public void ShowEngine()
    {
        Engine[] engines = { new Engine(80, 1.0m, "Electric", "SS5B0112FDV") };
        foreach (Engine engine in engines)
        {

            Console.WriteLine(engine);
        }
    }

    public void ShowTransmission()
    {
        Transmission[] transmissions = { new Transmission("Automatic", 3, "SCT.inc") };
        foreach (Transmission trans in transmissions)
        {
            Console.WriteLine(trans);
        }
    }

    public void ShowChassis()
    {
        Chassis[] chassis = { new Chassis("120/70 – 12 51 S", 12m, "430 lbs") };
        foreach (Chassis chassy in chassis)
        {
            Console.WriteLine(chassy);
        }
    }
}
