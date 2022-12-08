using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

using Carpark;

internal class PassengerCar
{

    public void showEngine()
    {

        Engine[] engines = { new Engine(160, 2.0m, "Gas", "PP61B564D64") };
        foreach (Engine engine in engines)
        {
            Console.WriteLine(engine);
        }

    }

    public void showTransmission()
    {
        Transmission[] transmissions = { new Transmission("Manual", 5, "Axle.inc") };
        foreach (Transmission trans in transmissions)
        {
            Console.WriteLine(trans);
        }
    }

    public void showChassis()
    {
        Chassis[] chassis = { new Chassis("624550/R17 85H", 17, "1135 lbs") };
        foreach(Chassis chassy in chassis)
        {
            Console.WriteLine(chassy);
        }
    }
    
}

    

    

