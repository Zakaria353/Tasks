using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;

namespace Carpark;

internal class Scooter 
{        

    public void showEngine()
    {
        Engine[] engines = { new Engine(80, 1.0m, "Electric", "SS5B0112FDV") };
        foreach (Engine engine in engines)
        {   

            Console.WriteLine(engine);
        }

    }
    
    public void showTransmission()
    {
        Transmission[] transmissions = { new Transmission("Automatic", 3, "SCT.inc") };
        foreach (Transmission trans in transmissions)
        {
            Console.WriteLine(trans);
        }

    }

    public void showChassis()
    {
        Chassis[] chassis = { new Chassis("120/70 – 12 51 S", 12m, "430 lbs") };
        foreach (Chassis chassy in chassis)
        {
            Console.WriteLine(chassy);
        }

    }

}
