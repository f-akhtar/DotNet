// C# file generated automatically
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int marks = 98;
        
        if (marks >= 80 && marks <= 100)
        {
            Console.WriteLine("Topper!");
        }
        else if (marks >= 60 && marks < 80)
        {
            Console.WriteLine("First!");
        }
        else if (marks >= 33 && marks < 60)
        {
            Console.WriteLine("Pass!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }
    }
}