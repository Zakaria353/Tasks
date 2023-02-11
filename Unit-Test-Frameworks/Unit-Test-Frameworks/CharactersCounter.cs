using System.Text;

namespace CharactersCounter;

public class CharactersCounter
{
    private static readonly StringBuilder stringBuilder = new StringBuilder();
    private static int Counter = 1;
    private static char[]? charValues;

    public static char[] CharBuilder(string? input)
    {
        stringBuilder.Append(input);
        var characters = stringBuilder.ToString().ToCharArray();
        charValues = characters;
        return charValues;
    }

    //UnequalCharactersCounter_ReturnsNumberOf_ConsecutiveUnqualCharacters
    public static int UnequalCharactersCounter()
    {
        if (charValues is not null && !charValues[0].Equals(charValues[1]))
        {
            Console.WriteLine($"\n1:  {charValues[0]}");
        }
        else if (charValues is not null && charValues[0].Equals(charValues[1]))
        {
            Console.WriteLine($"\n1:  {charValues[0]}");
        }

        for (int i = 1; i < charValues?.Length; i++)
        {
            if (!charValues[i].Equals(charValues[i - 1]))
            {
                ++Counter;
                Console.WriteLine($"{Counter}:  {charValues[i]}");
            }
            else
            {
                Console.WriteLine("Not counting Repeats");
            }
            //if methods are called in chain this will reset counter
            //for the next functions to count properly
            if (charValues.Length - 1 == i)
            {
                Counter = 1;
            }
        }
        return Counter;
    }

    //EqualLettersCounter_ReturnsNumberOf_ConsecutiveEqualLetters
    public static int EqualLettersCounter()
    {
        for (int i = 0; i < charValues?.Length; i++)
        {
            if (i + 1 >= charValues.Length || charValues[i] != charValues[i + 1]
                || (!char.IsLetter(charValues[i])))
            {
                if (char.IsLetter(charValues[i]) && Counter != 1)
                {
                    Console.WriteLine($"{Counter}: {charValues[i]}");
                }
                Counter = 1;
            }
            else
            {
                Counter++;
            }
        }
        return Counter;
    }

    //EqualDigitsCounter_ReturnsNumberOf_ConsecutiveEqualDigits
    public static int EqualDigitsCounter()
    {
        for (int i = 0; i < charValues?.Length; i++)
        {
            if (i + 1 >= charValues.Length || charValues[i] != charValues[i + 1]
                || (!char.IsDigit(charValues[i])))
            {
                if (char.IsDigit(charValues[i]) && Counter != 1)
                {
                    Console.WriteLine($"{Counter}: {charValues[i]}");
                }
                Counter = 1;
            }
            else
            {
                Counter++;
            }
        }
        return Counter;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter characters");
        var input = Console.ReadLine();
        CharBuilder(input);
        //UnequalCharactersCounter();
        EqualLettersCounter();
        //EqualDigitsCounter();
    }
}