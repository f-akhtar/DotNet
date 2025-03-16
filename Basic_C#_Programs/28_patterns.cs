// C# file generated automatically
using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}