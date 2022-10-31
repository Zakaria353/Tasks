using System;


public class Task1
{
    public static void Read(string input, int len)
    {

        char characters;
        char[] charArray = input.ToCharArray();
        string s = new string(charArray);
        //return s;
        int count = 0;
        for(int i = 1; i < s.Length; i++)
        {
            count += 1;
            if (!s[i - 1].Equals(charArray[i]))
                Console.WriteLine($"{s[i]} {count + 1}");
            else
            {
                Console.WriteLine("~");
            } 
            
        }
        
    }
    public static void Main()
    {
        Console.WriteLine("repeated values will be replaced by \"~\"");
        String str = Console.ReadLine();
        int n = str.Length;
        Console.WriteLine("\ninput results: ");
        Console.WriteLine($"{str[0]} 1");
        Read(str, n);
    }
}