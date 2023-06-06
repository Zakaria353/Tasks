namespace Interfaces.Abstraction;

public class Airplane : IFlyable
{
    public Coords currentPosition = new Coords(115, 145, 185);
    //Constants storing values that should not be changed;
    public const  double initialSpeed = 200; 
    public const  double maxSpeed = 1040;    
    public const  double maxDistance = 5600.52;
    //storing random values in variables;
    public static double flightTime = RandomTime(); 
    public static double variableDistance = VariableDistance();

    //Randomly generating flight time
    public static int RandomTime() 
    {
        var randomTime = new Random();
        return randomTime.Next(0, 6);
    }

    //Randomly generating variable distance
    public static int VariableDistance() 
    {
        var randomDistance = new Random();
        return randomDistance.Next(100, 933);
    }

    //calculating speed based on the distance travelled
    public double AirPlaneSpeed() 
    {
        //Calculating distance travelled by the plane based on random values
        double randomDistance = flightTime * variableDistance;
        double currentSpeed = 0;

        //iterating over the total distance value but then limiting the speed
        for (double i = 0; i <= randomDistance; i+=10)  
        {
            //Limiting speed to 1040; +10km/h every 10km;
            if (currentSpeed < maxSpeed & flightTime != 0) 
            {
                currentSpeed = initialSpeed + i; 
            }
        }

        //throwing if plane speed goes below minimum speed
        if (currentSpeed < initialSpeed & flightTime != 0)  
        {
            throw new Exception("Flight speed cannot go below 200km/h ");
        }

        //throwing if plane speed goes above maximum speed
        if (currentSpeed > maxSpeed)  
        {
            throw new Exception("This plane cannot go beyond 1040km/h ");
        }

        return currentSpeed;
    }

    //This method and its memebers is not involved elsewhere, it just returns total distance travelled
    public double FlyTo()  
    {
        //calculating total distance covered by the plane and throws exception if it goes beyond max distance
        double distance = flightTime * variableDistance;
        if (distance > maxDistance)                
        {
            throw new Exception("Airplanes cannot fly over 5600km ");
        }

        return distance;
    }

    //This method and its memebers is not involved elsewhere, it just returns total flight time
    public double GetFlyTime() 
    {
        //returning flight time
        return flightTime; 
    }
}