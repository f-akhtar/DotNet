// C# file generated automatically
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        string result = (num % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine(result);
    }
}