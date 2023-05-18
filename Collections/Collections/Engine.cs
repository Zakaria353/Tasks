namespace Collections;

public class Engine : Transmission
{
    public decimal Power { get; set; }
    public decimal Volume { get; set; }
    public string? Type { get; set; }
    public string? SerialNumber { get; set; }

    public Engine() { }

    public Engine(decimal power, decimal volume, string? type, string? serialNumber)
    {
        Power = power;
        Volume = volume;
        Type = type;
        SerialNumber = serialNumber;
    }

    public override string ToString() => $"Power:{Power}|| Volume:{Volume}|| Type:{Type} ||SerialNumber{SerialNumber}";
}