using System.Text;

namespace SymbolCounter;

public class CharactersCounter
{
    private static readonly StringBuilder stringBuilder = new StringBuilder();
    private static int Counter = 1;
    private static char[]? charValues;

    public char[] CharBuilder(string? input)
    {
        stringBuilder.Append(input);
        var characters = stringBuilder.ToString().ToCharArray();
        charValues = characters;
        return charValues;
    }

    public int UnequalCharactersCounter()
    {
        int totalUnequalSymbols = 0;

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
                totalUnequalSymbols = Counter;
                Console.WriteLine($"{Counter}:  {charValues[i]}");
            }
            else
            {
                Console.WriteLine("Not counting Repeats");
            }

            if (charValues.Length - 1 == i)
            {
                Counter = 1;
            }
        }
        return totalUnequalSymbols;
    }

    public int EqualLettersCounter()
    {
        int totalEqualLetters = 0;

        for (int i = 0; i < charValues?.Length; i++)
        {
            if (i + 1 >= charValues.Length || charValues[i] != charValues[i + 1]
                || (!char.IsLetter(charValues[i])))
            {
                if (char.IsLetter(charValues[i]) && Counter != 1)
                {
                    totalEqualLetters += Counter;
                    Console.WriteLine($"{Counter}: {charValues[i]}");
                }
                Counter = 1;
            }
            else
            {
                Counter++;
            }
        }
        return totalEqualLetters;
    }

    public int EqualDigitsCounter()
    {
        int totalEqualDigits = 0;

        for (int i = 0; i < charValues?.Length; i++)
        {
            if (i + 1 >= charValues.Length || charValues[i] != charValues[i + 1]
                || (!char.IsDigit(charValues[i])))
            {
                if (char.IsDigit(charValues[i]) && Counter != 1)
                {
                    totalEqualDigits += Counter;
                    Console.WriteLine($"{Counter}: {charValues[i]}");
                }
                Counter = 1;
            }
            else
            {
                Counter++;
            }
        }
        return totalEqualDigits;
    }

    static void Main()
    {
        //CharactersCounter charactersCounter = new CharactersCounter();
        //Console.WriteLine("Enter characters");
        //var input = Console.ReadLine();
        //charactersCounter.CharBuilder(input);
        //charactersCounter.UnequalCharactersCounter();
        ////charactersCounter.EqualLettersCounter();
        ////charactersCounter.EqualDigitsCounter();
    }
}

