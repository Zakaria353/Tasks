namespace Interfaces.Abstraction;

public class Drone : IFlyable
{
    public Coords currentPosition = new Coords(40, 60, 95);
    public const  double distance1K = 1000; 
    public static double flightTime = RandomTime(); 
    public static double flySpeed = RandomSpeed();

    //randomly generating drone fly time. max 30min
    static int RandomTime() 
    {
        var randomTime = new Random();
        return randomTime.Next(0, 31);
    }

    //randomly generating drone speed. max 33kmh
    static int RandomSpeed() 
    {
        var randomSpeed = new Random();
        return randomSpeed.Next(0, 34);
    }

    //calculating hovering time in 30mins, max amount of hovers 3, max 3 mins of hovering;
    public double HoverTime() 
    {                         
        double hover = 0;     
        double flytime = Math.Floor(flightTime / 10);

        if (flytime != 0)
        {
            hover += flytime;
        }

        return hover;
    }

    //calculating total flight distance 
    public double FlyTo() 
    {
        double distance = flySpeed * flightTime;
        //if distance exceeds threshold exception occurs
        if (distance > distance1K)               
        {
            throw new Exception("Drones cannot fly over 1000km ");
        };

        return distance;
    }

    //returning drone fly time
    public double GetFlyTime() 
    {
        return flightTime;
    }
}
