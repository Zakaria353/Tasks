namespace Interfaces.Abstraction;

internal class Drone : IFlyable
{
    public Coords currentPosition = new Coords(40, 60, 95);
    public const  double distance1K = 1000; //storing value that should not be changed;
    public static double flightTime = RandomTime(); //storing random values in variables
    public static double flySpeed = RandomSpeed(); //for later operations;

    static int RandomTime() //randomly generating drone fly time. max 30min
    {
        var rnd = new Random();
        return rnd.Next(0, 31);
    }

    static int RandomSpeed() //randomly generating drone speed. max 33kmh
    {
        var rnd = new Random();
        return rnd.Next(0, 34);
    }

    public double HoverTime() //calculating hovering time in 30mins,
    {                         //max amount of hovers 3,
        double hover = 0;     //max 3 mins of hovering;
        double flytime = Math.Floor(flightTime / 10);

        if (flytime != 0)
        {
            hover += flytime;
        }

        return hover;
    }

    public double FlyTo() //calculating total flight distance 
    {
        double distance = flySpeed * flightTime; //if distance exceeds threshold

        if (distance > distance1K)               //exception occurs
        {
            throw new Exception("Drones cannot fly over 1000km ");
        };

        return distance;
    }

    public double GetFlyTime() //returning drone fly time
    {
        return flightTime;
    }
}
