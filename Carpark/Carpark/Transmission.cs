using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpark;

public class Transmission

{
    public string? TransmissionType { get; set; }
    public int NumberOfGears { get; set; }
    public string? Manufacturer { get; set; }

    public Transmission(string? transmissionType, int numberOfGears, string? manufacturer)
    {
        TransmissionType = transmissionType;
        NumberOfGears = numberOfGears;
        Manufacturer = manufacturer;
    }
    public override string ToString() => $"Type:{TransmissionType}|| NumberOfGears:{NumberOfGears}|| Manufacturer:{Manufacturer}";
}