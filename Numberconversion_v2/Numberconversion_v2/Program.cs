namespace Converter;

public class Numberconversion
{
    public static void NumberConverter(string numberSystemInt, string numberToConvertInt)
    {
        int numberSystem = default; 
        int numberToConvert = default;
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        try
        {
            numberSystem = Convert.ToInt32(numberSystemInt);
            numberToConvert = Convert.ToInt32(numberToConvertInt);

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid value, only integers are allowed");
        }

        if (numberSystem == 2)
        {
            while (true)
            {
                int remainder = numberToConvert % 2;
                numberToConvert /= 2;

                sb.Append(remainder);
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var binaryValues = sb.ToString().Reverse();
            Console.Write($"Binary values are: ");
            foreach (var item in binaryValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 3)
        {
            while (true)
            {
                int remainder = numberToConvert % 3;
                numberToConvert /= 3;

                sb.Append(remainder);
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var ternaryValues = sb.ToString().Reverse();
            Console.Write($"Ternary values are: ");
            foreach (var item in ternaryValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 4)
        {
            while (true)
            {
                int remainder = numberToConvert % 4;
                numberToConvert /= 4;

                sb.Append(remainder);
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var QuaternaryValues = sb.ToString().Reverse();
            Console.Write($"Quaternary values are: ");
            foreach (var item in QuaternaryValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 5)
        {
            while (true)
            {
                int remainder = numberToConvert % 5;
                numberToConvert /= 5;

                sb.Append(remainder);
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var quinaryValues = sb.ToString().Reverse();
            Console.Write($"Quinary values are: ");
            foreach (var item in quinaryValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 6)
        {
            while (true)
            {
                int remainder = numberToConvert % 6;
                numberToConvert /= 6;

                sb.Append(remainder);
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var senaryValues = sb.ToString().Reverse();
            Console.Write($"Senary values are: ");
            foreach (var item in senaryValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 7)
        {
            while (true)
            {
                int remainder = numberToConvert % 7;
                numberToConvert /= 7;

                sb.Append(remainder);
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var septenaryValues = sb.ToString().Reverse();
            Console.Write($"Septenary values are: ");
            foreach (var item in septenaryValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 8)
        {
            while (true)
            {
                int remainder = numberToConvert % 8;
                numberToConvert /= 8;

                sb.Append(remainder);
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var octalValues = sb.ToString().Reverse();
            Console.Write($"Octal values are: ");
            foreach (var item in octalValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 9)
        {
            while (true)
            {
                int remainder = numberToConvert % 9;
                numberToConvert /= 9;

                sb.Append(remainder);
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var nonaryValues = sb.ToString().Reverse();
            Console.Write($"Nonary values are: ");
            foreach (var item in nonaryValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 11)
        {
            while (true)
            {
                int remainder = numberToConvert % 11;
                numberToConvert /= 11;
                if (remainder == 10)
                {
                    sb.Append('A');
                }
                else
                {
                    sb.Append(remainder);
                }

                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var undecimalValues = sb.ToString().Reverse();
            Console.Write($"Undecimal values are: ");
            foreach (var item in undecimalValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 12)
        {
            while (true)
            {
                int remainder = numberToConvert % 12;
                numberToConvert /= 12;
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

                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var duoDecimalValues = sb.ToString().Reverse();
            Console.Write($"Duodecimal values are: ");
            foreach (var item in duoDecimalValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 16)
        {
            while (true)
            {
                int remainder = numberToConvert % 16;
                numberToConvert /= 16;
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
                if (numberToConvert == 0)
                {
                    break;
                }
            }

            var hexaDecimalValues = sb.ToString().Reverse();
            Console.Write($"Hexadecimal values are: ");
            foreach (var item in hexaDecimalValues)
            {
                Console.Write(item);
            }
        }
        else if (numberSystem == 20)
        {
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

            while (true)
            {
                int remainder = numberToConvert % 20;
                numberToConvert /= 20;

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

                if (numberToConvert == 0)
                {
                    break;
                }

                var vigesimalValues = sb.ToString().Reverse();
                Console.Write($"Vigesimal values are: ");
                foreach (var item in vigesimalValues)
                {
                    Console.Write(item);
                }
            }
        }
        else
        {   
            List<int> digits = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 16, 20 };
            if (!digits.Contains(numberSystem))
            {
                Console.WriteLine("Invalid number system, try again!");
            }
        }
    }

    public static void Main()
    {
        Console.WriteLine("To quit press q");
        var endapp = false;
        while (!endapp)
        {   
            Console.Write("Enter number system: ");
            string? numberSystem = Console.ReadLine();
            if (numberSystem == "q")
            {
                break;
            }

            bool avoidRedundantError = Int32.TryParse(numberSystem, out _);
            if (avoidRedundantError == false)
            {
                Console.WriteLine("Invalid value, integers only");
                continue;
            }

            Console.Write("Enter decimal number: ");
            string? numberToConvert = Console.ReadLine();          
            if (numberToConvert == "q")
            {
                break;
            }

            NumberConverter(numberSystem, numberToConvert);
            Console.Write("\n");
        }
    }
}