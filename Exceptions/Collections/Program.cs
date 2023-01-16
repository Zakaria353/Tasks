namespace Exceptions;

public class Program
{   
    //intentionally passing invalid arguments to test exceptions
    public static void Main()
    {
        InitializationException();
        //AddException(null!);
        //GetAutoByParameterException("Ford", "fGT");
        //UpdateAutoException("2456A", "");
        //RemoveAutoException("2456Cc");
    }

    static void InitializationException()
    {
        try
        {
            Collector? v = null;
            Console.WriteLine(v!.CarModel);
        }
        catch (Exception e)
        {
            Console.WriteLine("Impossible to initialize car model " + "\nReason: " + e.Message);
        }
    }

    static void AddException(string carModel)
    {
        string printArgument = carModel ?? throw new ArgumentException("Parameter cannot be null", nameof(carModel));
        Console.WriteLine(printArgument);
    }

    static void GetAutoByParameterException(string manufacturer, string carModel)
    {
        string values = Collector.IterateThruCarModels();
        try
        {
            if (!values.Contains(manufacturer) || !values.Contains(carModel))
            {
                throw new Exception();
            }
            Console.WriteLine(manufacturer + " " + carModel);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Error details: ");
            throw new ArgumentException();
        }
    }

    public static List<string> CarIDs = new List<string> { "2456A", "2456B", "2456C", "2456D" };

    static void UpdateAutoException(string replaceFrom, string replaceTo)
    {
        int valueToReplace = CarIDs.IndexOf(replaceFrom);
        string newValue = replaceTo;

        try
        {
            if (!string.IsNullOrEmpty(newValue))
            {
                CarIDs[valueToReplace] = newValue;
            }
            else
            {
                throw new ArgumentNullException();
            }

            foreach (var v in CarIDs)
            {
                Console.WriteLine(v);
            }
        }

        catch (ArgumentNullException ex)
        {
            Console.WriteLine("New value cannot be null or empty" + "\nType of exception: " + ex.GetType());
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid identifier to replace a car, old car ID must be valid \n" + ex.Message);
            Console.WriteLine("Current exception method source: " + ex.TargetSite);
        }
    }

    static void RemoveAutoException(string removeCarByID)
    {
        int valueToRemove = CarIDs.IndexOf(removeCarByID);

        try
        {
            if (removeCarByID != null)
            {
                CarIDs.RemoveAt(valueToRemove);
            }
            else
            {
                throw new ArgumentNullException();
            }
            foreach (var v in CarIDs)
            {
                Console.WriteLine(v);

            }
            Console.WriteLine($"Car with ID of {removeCarByID} was removed at index {valueToRemove}");
        }

        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Parameter value cannot be null" + "\nType of exception: " + ex.GetType().Name);
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid identifier to remove a car" + "\n" + ex.Message);
            Console.WriteLine("Specify ID from the CarIDs list to remove a car");
        }
    }
}