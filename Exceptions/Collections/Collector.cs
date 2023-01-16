using System.Text;

namespace Exceptions;

public class Collector
{
    public string? CarModel { get; set; }
    public string? Manufacturer { get; set; }

    public static List<Collector> CarModels()
    {
        return new List<Collector>()
        { new Collector() { Manufacturer = "Ford", CarModel = "F-150" } ,
        { new Collector() { Manufacturer = "Ford", CarModel = "GT" } },
        { new Collector() { Manufacturer = "Ford", CarModel = "Mustang" } }
        };
    }

    public static string IterateThruCarModels()
    {
        List<Collector> items = CarModels();
        var values = new StringBuilder();
        foreach (var t in items)
        {
            values.Append(t.Manufacturer + " ");
            values.Append(t.CarModel + " ");
        }
        return values.ToString();
    }
}