using System.Reflection.Metadata.Ecma335;

namespace Interfaces_Abstraction;

internal class Airplane : IFlyable
{
    public Coords Current_position = new Coords(115, 145, 185);
    public const double initial_speed = 200; //Constants
    public const double max_speed = 1046;    //storing values that 
    public const double maxDistance = 5600.52; //should not be changed;
    public static double flightTime = RandomTime();  //storing random values
    public static double varDistance = VariableDistance();  //in variables;

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
        double varDist = flightTime * varDistance; //Calculating distance travelled by the plane based on random values
        double currentSpeed = 0;                    
        for(double i = 0; i <= varDist; i++)  //iterating over the total distance value but then limiting the speed
        {   
            if(currentSpeed < max_speed & flightTime != 0) //Limiting speed to 1046;
            {
                currentSpeed = initial_speed + i; //+1km/h speed per minute ;
            }
        }
        if (currentSpeed < initial_speed & flightTime != 0)  //throwing if plane speed goes below minimum speed
        {
            throw new Exception("Flight speed cannot go below 200km/h ");
        }
        if (currentSpeed > max_speed)  //throwing if plane speed goes above maximum speed
        {
            throw new Exception("This plane cannot go beyond 1046km/h ");
        }
        return currentSpeed;
    }

    public double FlyTo()  //This method and its memebers is not involved elsewhere, it just returns total distance travelled
    {   
        double distance = flightTime * varDistance; //calculating total distance covered by the plane
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
