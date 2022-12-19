namespace Interfaces_Abstraction;

internal class Bird : IFlyable
{

    public Coords Current_position = new Coords(22, 33, 45);
    public double flyspeed = RandomSpeed(); //storing random values in variables
    public double flytime = RandomTime();   //for later operations;
    public const double max_Distance = 11000; //storing value that should not be changed

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
        if(flyspeed != 0 && flytime != 0)
        {
            Console.WriteLine($"Bird speed: {flyspeed}km/h \nBird flytime: {flytime}min");
            distance = flyspeed * flytime;
        }
        else  //if flyspeed or flytime is 0 then both of these variables should 0;
        {               
            flyspeed = 0;
            flytime = 0;
            Console.WriteLine($"Bird speed: {flyspeed}km/h \nBird flytime: {flytime}min");
        }
        if(distance > max_Distance)  
        {
            throw new Exception("Birds cannot fly over 11000km");
        }
        return distance;
    }

    public double GetFlyTime()  //returning amount of time bird flew
    {
        return flytime;
    }

}
