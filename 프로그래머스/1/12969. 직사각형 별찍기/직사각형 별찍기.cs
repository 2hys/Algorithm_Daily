using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);
        int j = 0;
        for (int i = 0; i < b; i++)
        {
            while (j < a)
            {
                Console.Write('*');
                j++;
            }
            Console.WriteLine();
            j = 0;
        }
    }
}