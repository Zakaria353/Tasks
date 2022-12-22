namespace Carpark;

public class Chassis
{
    public string? WheelsNumber { get; set; }
    public decimal Number { get; set; }
    public string? PermissibleLoad { get; set; }

    public Chassis(string wheelsnumber, decimal number, string permissibleLoad)
    {
        WheelsNumber = wheelsnumber;
        Number = number;
        PermissibleLoad = permissibleLoad;
    }

    public override string ToString() => $"WheelsNumber:{WheelsNumber}|| Number:{Number}|| Permissibleload:{PermissibleLoad}";
}
