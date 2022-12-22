namespace Interfaces.Abstraction;

internal class Airplane : IFlyable
{
    public Coords currentPosition = new Coords(115, 145, 185);
    public const  double initialSpeed = 200; //Constants
    public const  double maxSpeed = 1040;    //storing values that 
    public const  double maxDistance = 5600.52; //should not be changed;
    public static double flightTime = RandomTime();  //storing random values
    public static double variableDistance = VariableDistance();  //in variables;

    public static int RandomTime() //Randomly generating flight time
    {
        var rnd = new Random();
        return rnd.Next(0, 6);
    }

    public static int VariableDistance() //Randomly generating variable distance
    {
        var rnd = new Random();
        return rnd.Next(100, 933);
    }

    public double AirPlaneSpeed() //calculating speed based on the distance travelled
    {
        double randomDistance = flightTime * variableDistance; //Calculating distance travelled by the plane based on random values
        double currentSpeed = 0;

        for (double i = 0; i <= randomDistance; i+=10)  //iterating over the total distance value but then limiting the speed
        {
            if (currentSpeed < maxSpeed & flightTime != 0) //Limiting speed to 1040;
            {
                currentSpeed = initialSpeed + i; //+10km/h every 10km;
            }
        }

        if (currentSpeed < initialSpeed & flightTime != 0)  //throwing if plane speed goes below minimum speed
        {
            throw new Exception("Flight speed cannot go below 200km/h ");
        }

        if (currentSpeed > maxSpeed)  //throwing if plane speed goes above maximum speed
        {
            throw new Exception("This plane cannot go beyond 1046km/h ");
        }

        return currentSpeed;
    }

    public double FlyTo()  //This method and its memebers is not involved elsewhere, it just returns total distance travelled
    {
        double distance = flightTime * variableDistance; //calculating total distance covered by the plane
        if (distance > maxDistance)                // and throws exception if it goes beyond max distance
        {
            throw new Exception("Airplanes cannot fly over 5600km ");
        }

        return distance;
    }

    public double GetFlyTime() //This method and its memebers is not involved elsewhere, it just returns total flight time
    {
        return flightTime; //returning flight time
    }
}
