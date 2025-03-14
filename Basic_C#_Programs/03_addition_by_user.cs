// C# file generated automatically
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
    }
}