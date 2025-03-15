// C# file generated automatically
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i = 1;
        
        go:
        if (i <= 10)
        {
            Console.Write(i + " ");
            i++;
            goto go;
        }
    }
}