public interface ICommand
{
    void Execute();
}

public sealed class StartStop : ICommand
{
    private StartStop() { }

    private static StartStop? _instance;
    private static readonly object _instanceLock = new object();

    public static ReceiveInput? _receiver;
    private static string? _exit;

    public static StartStop GetInstance(ReceiveInput receiver, string exit)
    {
        if (_instance == null)
        {
            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new StartStop();
                    _receiver = receiver;
                    _exit = exit;
                }
            }
        }
        return _instance;
    }

    public void Execute()
    {
        Console.WriteLine("Press Enter to start program\n" +
        "Type \"exit\" to quit the program\n");
        ReceiveInput.StartProgram();
        Console.WriteLine($"\n{_exit} Command was entered");
    }
}

public class BrandCounter : ICommand
{
    public ReceiveInput _receiver;
    private string _count;

    public BrandCounter(ReceiveInput receiver, string count)
    {
        _receiver = receiver;
        _count = count;
    }

    public void Execute()
    {
        Console.WriteLine("Counting number of car " + _count);
        _receiver.CountBrands(_count);
    }
}

public class CarCounter : ICommand
{
    private ReceiveInput _receiver;
    private string _count;

    public CarCounter(ReceiveInput receiver, string count)
    {
        _receiver = receiver;
        _count = count;
    }

    public void Execute()
    {
        Console.WriteLine("Countnig car " + _count);
        _receiver.QuantityCounter(_count);
    }
}

public class AverageCostCounter : ICommand
{
    private ReceiveInput _receiver;
    private string _count;

    public AverageCostCounter(ReceiveInput receiver, string count)
    {
        _receiver = receiver;
        _count = count;
    }

    public void Execute()
    {
        Console.WriteLine($"Countnig {_count} cost of cars");
        _receiver.AverageCostCounter(_count);
    }
}

public class AverageCostPerBrand : ICommand
{
    private ReceiveInput _receiver;
    private string _count;

    public AverageCostPerBrand(ReceiveInput receiver, string count)
    {
        _receiver = receiver;
        _count = count;
    }

    public void Execute()
    {
        Console.WriteLine($"Countnig {_count} cost per brand");
        _receiver.AverageCostPerBrand(_count);
    }
}

public class ReceiveInput
{
    public static bool _endApp = false;
    public static string? brandInput;

    public static List<string>? brandList = new List<string>();

    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Quantity { get; set; }
    public decimal Cost { get; set; }

    private static List<ReceiveInput> data = new List<ReceiveInput>();

    public static List<ReceiveInput> BuildList(string brand, string model, int quantity, decimal cost)
    {
        data.Add(new ReceiveInput { Brand = brand, Model = model, Quantity = quantity, Cost = cost });
        return data;
    }

    public static void InputLogic()
    {
        int quantityInput;
        decimal costInput;

    LoopControl:
        try
        {
            while (!_endApp)
            {
                Console.WriteLine("Enter the brand name ");
                brandInput = Console.ReadLine();
                brandList.Add(brandInput);

                Console.WriteLine("Enter the model name ");
                string? modelInput = Console.ReadLine();

                Console.WriteLine("Enter the quantity ");
                quantityInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the cost ");
                costInput = Convert.ToDecimal(Console.ReadLine());

                BuildList(brandInput, modelInput, quantityInput, costInput);

                Console.WriteLine("To continue adding data press any key" +
                    "\nTo choose commands type \"commands\"");
                var askUserToContinue = Console.ReadLine()?.ToLower();

                if (askUserToContinue == "commands")
                {
                    CommandInput commands = new CommandInput();
                    commands.InputCommand();
                    break;
                }
            }
            //foreach (var car in data)
            //{
            //    Console.WriteLine($"Brand:{car.Brand} Model:{car.Model} Quantity:{car.Quantity} Cost:{car.Cost}");
            //}
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input, enter integers for quantity and" +
                " decimals for cost\n");
            data.Clear();
            goto LoopControl;
        }
    }

    public void CountBrands(string count)
    {
        var totalAmountOfBrands =
            from brand in data
            where !string.IsNullOrEmpty(brand.Brand)
            group brand by brand.Brand into brandGroup
            select brandGroup;

        var brandCounter = totalAmountOfBrands.Count();
        Console.WriteLine("\nNumber of car brands: " + brandCounter);
    }

    public void QuantityCounter(string count)
    {
        var totalAmountOfCars =
                from car in data
                where car.Model != null
                select car.Quantity;

        int quantityCounter = 0;
        foreach (var item in totalAmountOfCars)
        {
            quantityCounter += item;
        }
        Console.WriteLine("\nTotal number of cars: " + quantityCounter);
    }

    public void AverageCostCounter(string count)
    {
        var averageCost =
                from model in data
                group model by model.Cost into modelGroup
                select modelGroup;

        int keyCount = averageCost.Count();
        decimal Sum = 0;
        foreach (var v in averageCost)
        {
            // Console.WriteLine("Key " + v.Key);
            Sum += v.Key;
        }
        //Console.WriteLine(keyCount);
        if (keyCount != 0)
        {
            Console.WriteLine($"\nAverage cost of the car:  {Sum / keyCount:0.##}");
        }
    }

    public void AverageCostPerBrand(string count)
    {
        string? _userCommand = CommandInput.userCommand;

        var averageOfBrand =
            from brand in data
            group brand by brand.Brand into brandGroup
            where brandGroup.Key == _userCommand
            select brandGroup;

        decimal amountOfCarsPerModel = 0;
        decimal totalCostPerModel = 0;
        decimal totalCost = 0;
        foreach (var v in averageOfBrand)
        {
            //Console.WriteLine(v.Key);
            foreach (var t in v)
            {
                amountOfCarsPerModel += t.Quantity;
                totalCostPerModel = t.Cost * t.Quantity;
                totalCost += totalCostPerModel;
            }
        }
        if (amountOfCarsPerModel != 0)
        {
            decimal average = totalCost / amountOfCarsPerModel;
            Console.WriteLine($"\nAverage cost of {_userCommand} is {average:0.##}");
        }
    }

    public static void StartProgram()
    {
        while (!_endApp)
        {
            var input = Console.ReadLine();
            if (input != "exit")
            {
                InputLogic();
            }
            else
            {
                _endApp = true;
            }
        }
    }
}

public class CommandInput
{
    public static string? userCommand;
    ReceiveInput receiver = new ReceiveInput();

    public void InputCommand()
    {
        bool loop = true;
        while (loop)
        {
        LoopControl:
            Console.WriteLine("Choose a command to execute: ");
            Console.WriteLine("\"brands\", \"quantity\", \"average\", enterBrand, \"exit\"");
            userCommand = Console.ReadLine();

            if (userCommand == "exit")
            {
                loop = false;
                ReceiveInput._endApp = true;
            }
            else if (userCommand == "brands")
            {
                receiver.CountBrands(userCommand);
            }
            else if (userCommand == "quantity")
            {
                receiver.QuantityCounter(userCommand);
            }
            else if (userCommand == "average")
            {
                receiver.AverageCostCounter(userCommand);
            }
            else if (ReceiveInput.brandList.Contains(userCommand))
            {
                receiver.AverageCostPerBrand(userCommand);
            }
            else
            {
                Console.WriteLine("Wrong command!\n");
                goto LoopControl;
            }
        }
    }
}

public class Invoker
{
    private ICommand? _Exit;
    private ICommand? _BrandCount;
    private ICommand? _CarCount;
    private ICommand? _AverageCost;
    private ICommand? _AverageCostPerBrand;

    public void GetExit(ICommand command)
    {
        _Exit = command;
    }

    public void GetBrandCount(ICommand command)
    {
        _BrandCount = command;
    }

    public void GetCarCount(ICommand command)
    {
        _CarCount = command;
    }

    public void GetAverageCost(ICommand command)
    {
        _AverageCost = command;
    }

    public void GetAverageCostPerBrand(ICommand command)
    {
        _AverageCostPerBrand = command;
    }

    public void ExecuteCommands()
    {
        if (_Exit is ICommand)
        {
            _Exit.Execute();
        }

        if (_BrandCount is ICommand)
        {
            _BrandCount.Execute();
        }

        if (_CarCount is ICommand)
        {
            _CarCount.Execute();
        }

        if (_AverageCost is ICommand)
        {
            _AverageCost.Execute();
        }

        if (_AverageCostPerBrand is ICommand)
        {
            _AverageCostPerBrand.Execute();
        }
    }

    public static void Main()
    {
        ReceiveInput receiver = new ReceiveInput();
        Invoker invoker = new Invoker();
        StartStop startStop = StartStop.GetInstance(receiver, "exit");
        startStop.Execute();
        invoker.GetExit(StartStop.GetInstance(receiver, "exit"));
        invoker.GetBrandCount(new BrandCounter(receiver, "brands"));
        invoker.GetCarCount(new CarCounter(receiver, "quantity"));
        invoker.GetAverageCost(new AverageCostCounter(receiver, "average"));
        invoker.GetAverageCostPerBrand(new AverageCostPerBrand(receiver, "AVERAGE"));
        invoker.ExecuteCommands();
    }
}