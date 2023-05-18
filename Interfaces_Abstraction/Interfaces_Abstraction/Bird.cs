namespace Interfaces.Abstraction;

internal class Bird : IFlyable
{
    public Coords currentPosition = new Coords(22, 33, 45);
    //storing random values in variables for later operations;
    public double flySpeed = RandomSpeed(); 
    public double flyTime = RandomTime();   
    public const double maxDistance = 11000;

    //randomly generating speex. max 0-20km/h 
    static int RandomSpeed() 
    {
        var rnd = new Random();
        return rnd.Next(0, 21);
    }

    //randomly generating fly times in hours. max 5hr
    static int RandomTime() 
    {
        var rnd = new Random();
        return rnd.Next(0, 6);
    }

    //calculating distance and returning its value
    //if distance exceeds 11000km throwing exception
    public double FlyTo()  
    {                      
        double distance = 0;

        if (flySpeed != 0 && flyTime != 0)
        {
            Console.WriteLine($"Bird speed: {flySpeed}km/h \nBird flyTime: {flyTime}min");
            distance = flySpeed * flyTime;
        }
        //if flySpeed or flyTime is 0 then both of these variables should be 0;
        else
        {
            flySpeed = 0;
            flyTime = 0;
            Console.WriteLine($"Bird speed: {flySpeed}km/h \nBird flyTime: {flyTime}min");
        }

        if (distance > maxDistance)
        {
            throw new Exception("Birds cannot fly over 11000km");
        }

        return distance;
    }

    //returning amount of time bird flew
    public double GetFlyTime()  
    {
        return flyTime;
    }
}
