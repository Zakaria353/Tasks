using System;
using System.Collections.Generic;

public class Task1
{
    public static void Read(string input)
    {
        List<char> uniqueChars = new List<char>();

        foreach (char c in input)
        {
            if (!uniqueChars.Contains(c))
            {
                uniqueChars.Add(c);
            }
        }

        foreach (char v in uniqueChars)
        {
            Console.Write(v);
        }
    }

    public static void Main()
    {
        Console.Write("Input values:");
        string input = Console.ReadLine();
        Read(input);
    }
}