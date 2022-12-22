namespace Interfaces.Abstraction;

internal class Bird : IFlyable
{
    public Coords currentPosition = new Coords(22, 33, 45);
    public double flySpeed = RandomSpeed(); //storing random values in variables
    public double flyTime = RandomTime();   //for later operations;
    public const double maxDistance = 11000; //storing value that should not be changed

    static int RandomSpeed() //randomly generating speex. max 0-20km/h 
    {
        var rnd = new Random();
        return rnd.Next(0, 21);
    }

    static int RandomTime() //randomly generating fly times in hours. max 5hr
    {
        var rnd = new Random();
        return rnd.Next(0, 6);
    }

    public double FlyTo()  //calculating distance and returning its value
    {                      //if distance exceeds 11000km throwing exception
        double distance = 0;

        if (flySpeed != 0 && flyTime != 0)
        {
            Console.WriteLine($"Bird speed: {flySpeed}km/h \nBird flyTime: {flyTime}min");
            distance = flySpeed * flyTime;
        }
        else  //if flySpeed or flyTime is 0 then both of these variables should 0;
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

    public double GetFlyTime()  //returning amount of time bird flew
    {
        return flyTime;
    }
}
