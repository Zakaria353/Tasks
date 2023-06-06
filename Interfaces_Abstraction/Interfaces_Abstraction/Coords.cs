namespace Interfaces.Abstraction;

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