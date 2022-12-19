namespace Interfaces_Abstraction;

interface IFlyable
{
    double FlyTo();
    double GetFlyTime();
}


public struct Coords
{
    public Coords(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }

    public override string ToString()
    {
        return $"X:{X} Y:{Y} Z:{Z}";
    }
}

public class Program
{
    public static void Main()
    {
        Coords c = new Coords();
        Console.WriteLine("Default coords: " + c);

        Bird bird = new Bird();
        Console.WriteLine("\nBird coords: " + bird.Current_position);
        Console.WriteLine("Bird traveled distance: " + bird.FlyTo() + "km");

        Drone drone = new Drone();
        Console.WriteLine("\nDrone coords: " + drone.Current_position);
        Console.WriteLine("Drone flight time: " + drone.GetFlyTime() + "min");
        Console.WriteLine("Drone hover time: " + drone.HoverTime() + "min");
        Console.WriteLine("Drone speed: " + Drone.flyspeed + "km/h");
        Console.WriteLine("Distance covered by the drone: " + drone.FlyTo() + "km");

        Airplane airplane = new Airplane();
        Console.WriteLine("\nAirplane coords: " + airplane.Current_position);
        Console.WriteLine("Airplane flight time: " + airplane.GetFlyTime() + "hours");
        Console.WriteLine("Airplane Speed: " + airplane.AirPlaneSpeed() + "km/h");
        Console.WriteLine("Airplane flight distance: " + airplane.FlyTo() + "km");
    }
}