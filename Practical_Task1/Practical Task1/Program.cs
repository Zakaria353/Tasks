using System;

public class Task1
{
    public static void Read(string input)
    {
        char[] charArray = input.ToCharArray();
        string charToString = new string(charArray);
        int count = 0;

        for (int i = 1; i < charToString.Length; i++)
        {
            count += 1;
            if (!charToString[i - 1].Equals(charArray[i]))
                Console.WriteLine($"{charToString[i]} {count + 1}");
            else
            {
                Console.WriteLine("~");
            }
        }
    }

    public static void Main()
    {
        Console.WriteLine("repeated values will be replaced by \"~\"");
        String inputString = Console.ReadLine();
        Console.WriteLine("\ninput results: ");
        Console.WriteLine($"{inputString[0]} 1");
        Read(inputString);
    }
}