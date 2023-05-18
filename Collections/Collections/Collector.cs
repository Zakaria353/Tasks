using System.Text;
using System.Xml.Linq;

namespace Collections;

public class Collector : Engine
{
    public string? TranportType { get; set; }

    private static List<Collector> BuildList()
    {
        return new List<Collector>()
        {
            { new Collector() { TranportType = "Bus", Power = 300, Volume = 6.7m, Type = "Diesel", SerialNumber = "BB1B59FD74O",
            TransmissionType = "Manual", NumberOfGears = 4, Manufacturer = "BeP.inc",
            WheelsNumber = "315/80R22.5", Number = 22.5m, PermissibleLoad = "992 lbs"}},

            { new Collector { TranportType = "Passengercar", Power = 160, Volume = 2.0m, Type = "Gasoline", SerialNumber = "PP61B564D64",
            TransmissionType = "Manual", NumberOfGears = 5, Manufacturer = "Axle.inc",
            WheelsNumber = "624550/R17 85H", Number = 17, PermissibleLoad = "1135 lbs"}},

            { new Collector { TranportType= "Scooter", Power = 80, Volume = 1.0m, Type = "Electric", SerialNumber = "SS5B0112FDV",
            TransmissionType = "Automatic", NumberOfGears = 3, Manufacturer = "SCT.inc",
            WheelsNumber = "120/70 – 12 51 S", Number = 12m, PermissibleLoad = "430 lbs"}},

            { new Collector { TranportType = "Truck", Power = 560, Volume = 14.8m, Type = "Diesel", SerialNumber = "TT371B56FD64U",
            TransmissionType = "G-Tronic", NumberOfGears = 9, Manufacturer = "eZx.inc",
            WheelsNumber = "P215/65R20 98H", Number = 20, PermissibleLoad = "1653 lbs"}}
        };
    }

    public static string VolumeToXML()
    {
        List<Collector> items = BuildList();

        var itemsquery =
        from item in items
        where item.Volume > 1.5m
        group item by item.TranportType;

        var XMLtoString = new StringBuilder();

        foreach (var v in itemsquery)
        {
            foreach (var t in v)
            {
                XElement format =
                new XElement(v.Key,
                    new XElement("Power", t.Power),
                    new XElement("Volume", t.Volume),
                    new XElement("Type", t.Type),
                    new XElement("Serialnumber", t.SerialNumber),
                    new XElement("TransmissionType", t.TransmissionType),
                    new XElement("NumberOfGears", t.NumberOfGears),
                    new XElement("Manufacturer", t.Manufacturer),
                    new XElement("WheelsNumber", t.WheelsNumber),
                    new XElement("Number", t.Number),
                    new XElement("PermissibleLoad", t.PermissibleLoad)
                    );
                XMLtoString.Append(format);
                XMLtoString.Append('\n');
            }
        }
        return XMLtoString.ToString();
    }

    public static string BusesAndTrucksToXML()
    {
        List<Collector> items = BuildList();

        var itemsquery =
        from item in items
        where item.TranportType == "Bus" || item.TranportType == "Truck"
        group item by item.TranportType;

        var XMLtoString = new StringBuilder();

        foreach (var v in itemsquery)
        {
            ; foreach (var t in v)
            {
                XElement format =
                new XElement(v.Key,
                    new XElement("Type", t.Type),
                    new XElement("Serialnumber", t.SerialNumber),
                    new XElement("Power", t.Power)
                    );
                XMLtoString.Append(format);
                XMLtoString.Append('\n');
            }
        }
        return XMLtoString.ToString();
    }

    public static string TransmissionTypesToXML()
    {
        List<Collector> items = BuildList();

        var itemsquery =
        from item in items
        group item by item.TransmissionType;

        var XMLtoString = new StringBuilder();

        foreach (var v in itemsquery)
        {
            foreach (var t in v)
            {
                XElement format =
                new XElement(v.Key,
                    new XElement("Power", t.Power),
                    new XElement("Volume", t.Volume),
                    new XElement("Type", t.Type),
                    new XElement("Serialnumber", t.SerialNumber),
                    new XElement("NumberOfGears", t.NumberOfGears),
                    new XElement("Manufacturer", t.Manufacturer),
                    new XElement("WheelsNumber", t.WheelsNumber),
                    new XElement("Number", t.Number),
                    new XElement("PermissibleLoad", t.PermissibleLoad)
                    );
                XMLtoString.Append(format);
                XMLtoString.Append('\n');
            }
        }
        return XMLtoString.ToString();
    }
}
