// C# file generated automatically
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [,] arr = new int [2,2];
        
        Console.WriteLine("Enter array element:");
        
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        Console.WriteLine("Matrix array element:");
        
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}