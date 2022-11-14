namespace Converter;

public class Numberconversion
{
    public static void ConvertToBinary()
    {
    
    Binarycontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {
                int remainder = convert % 2;
                convert /= 2;

                sb.Append(remainder);
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Binary values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }
        }
        catch(FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Binarycontrol;
        } 

    }

    public static void ConvertToTernary()
    {
    
    Ternarycontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {

                int remainder = convert % 3;
                convert /= 3;

                sb.Append(remainder);
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Ternary values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Ternarycontrol;
        }

    }

    public static void ConvertToQuaternary()
    {
        Quaternarycontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {

                int remainder = convert % 4;
                convert /= 4;

                sb.Append(remainder);
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Quaternary values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Quaternarycontrol;
        }

    }

    public static void ConvertToQuinary()
    {
        Quinarycontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {

                int remainder = convert % 5;
                convert /= 5;

                sb.Append(remainder);
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Quinary values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Quinarycontrol;
        }

    }

    public static void ConvertToSenary()
    {
        Senarycontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {
                int remainder = convert % 6;
                convert /= 6;

                sb.Append(remainder);
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Senary values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Senarycontrol;
        }

    }

    public static void ConvertToSeptenary()
    {
        Septenarycontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {
                int remainder = convert % 7;
                convert /= 7;

                sb.Append(remainder);
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Septenary values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Septenarycontrol;
        }
    }

    public static void ConvertToOctal()
    {
        Octalcontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {
                int remainder = convert % 8;
                convert /= 8;

                sb.Append(remainder);
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Octal values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Octalcontrol;
        }
    }

    public static void ConvertToNonary()
    {
        Nonarycontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {
                int remainder = convert % 9;
                convert /= 9;

                sb.Append(remainder);
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Nonary values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Nonarycontrol;
        }

    }

    public static void ConvertToUndecimal()
    {
        Undecimalcontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {
                int remainder = convert % 11;
                convert /= 11;
                if (remainder == 10)
                {
                    sb.Append('A');
                }
                else
                {
                    sb.Append(remainder);
                }

                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Undecimal values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Undecimalcontrol;
        }
    }

    public static void ConvertToDuodecimal()
    {
        Duodecimalcontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {

                int remainder = convert % 12;
                convert /= 12;
                if (remainder == 10)
                {
                    sb.Append('A');
                }
                else if (remainder == 11)
                {
                    sb.Append('B');
                }
                else
                {
                    sb.Append(remainder);
                }

                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Duodecimal values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Duodecimalcontrol;
        }

    }

    public static void ConvertToHexadecimal()
    {
        Hexadecimalcontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            bool loop = true;
            while (loop)
            {
                int remainder = convert % 16;
                convert /= 16;
                if (remainder == 10)
                {
                    sb.Append('A');
                }
                else if (remainder == 11)
                {
                    sb.Append('B');
                }
                else if (remainder == 12)
                {
                    sb.Append('C');
                }
                else if (remainder == 13)
                {
                    sb.Append('D');
                }
                else if (remainder == 14)
                {
                    sb.Append('E');
                }
                else if (remainder == 15)
                {
                    sb.Append('F');
                }
                else
                {
                    sb.Append(remainder);

                }
                if (convert == 0)
                {
                    loop = false;
                }

            }
            var values = sb.ToString().Reverse();
            Console.Write($"Hexadecimal values are: ");
            foreach (var item in values)
            {
                Console.Write(item);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Hexadecimalcontrol;
        }
    }

    public static void ConvertToVigesimal()
    {
        Vigesimalcontrol:
        try
        {
            Console.Write("Enter decimal number: ");
            string? str = Console.ReadLine();
            var convert = Convert.ToInt32(str);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            Dictionary<string, int> base20 = new Dictionary<string, int>();
            {
                base20.Add("A", 10);
                base20.Add("B", 11);
                base20.Add("C", 12);
                base20.Add("D", 13);
                base20.Add("E", 14);
                base20.Add("F", 15);
                base20.Add("G", 16);
                base20.Add("H", 17);
                base20.Add("I", 18);
                base20.Add("J", 19);
            }

            bool loop = true;
            while (loop)
            {

                int remainder = convert % 20;
                convert /= 20;

                if (remainder >= 10 && remainder <= 19)
                {
                    for (int index = 0; index < base20.Count; index++)
                    {
                        var item = base20.ElementAt(index);
                        var itemKey = item.Key;
                        var itemValue = item.Value;
                        if (remainder == itemValue)
                        {
                            sb.Append(itemKey);
                        };
                    }
                }
                else
                {
                    sb.Append(remainder);
                }

                if (convert == 0)
                {
                    loop = false;
                }

                var values = sb.ToString().Reverse();
                Console.Write($"Vigesimal values are: ");
                foreach (var item in values)
                {
                    Console.Write(item);
                }
            }
        
        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid or no input was detected, only decimals are allowed");
            goto Vigesimalcontrol;
        }
    }

    static public void Main()
    {
        Console.Write("Choose a respective number system to convert to," +
        " 2 for binary, 3 for ternary, etc." + "\nValid values are 2 to 9, 11 to 12, 16, 20" +
        "\nPress \"q\" to quit. \nEnter number system: ");
        
        var endapp = false;
        while (!endapp)
        {
            var input = Console.ReadLine();
            if (input == "q")
            {
                endapp = true;
            }
            if (input == "2")
            {
                ConvertToBinary();
                endapp = true;
            }
            else if(input == "3")
            {
                ConvertToTernary();
                endapp = true;
            }
            else if(input == "4") 
            {
                ConvertToQuaternary();
                endapp = true;
            }
            else if (input == "5")
            {
                ConvertToQuinary();
                endapp = true;
            }
            else if (input == "6")
            {
                ConvertToSenary();
                endapp = true;
            }
            else if (input == "7")
            {
                ConvertToSeptenary();
                endapp = true;
            }
            else if (input == "8")
            {
                ConvertToOctal();
                endapp = true;
            }
            else if (input == "9")
            {
                ConvertToNonary();
                endapp = true;
            }
            else if (input == "11")
            {
                ConvertToUndecimal();
                endapp = true;
            }
            else if (input == "12")
            {
                ConvertToDuodecimal();
                endapp = true;
            }
            else if (input == "16")
            {
                ConvertToHexadecimal();
                endapp = true;
            }
            else if (input == "20")
            {
                ConvertToVigesimal();
                endapp = true;
            }
            else
            {   
                if(input != "q")
                {   
                    Console.Write("Invalid input try again.\nValid values are 2 to 9, 11 to 12, 16, 20" +
                    "\nEnter number system: ");
                }

            }
        }

    }
}