// C# file generated automatically
using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str1 = "Farhan";
        string str2 = "Akhtar";
        string reverse = new string(str1.Reverse().ToArray());
        
        Console.WriteLine(str1.Equals(str2));
        
        Console.WriteLine(str1.Length);
        Console.WriteLine(str2[2]);
        
        Console.WriteLine(reverse);
        
        Console.WriteLine(str1 + " " + str2);
        Console.WriteLine(String.Concat(str1,str2));
        
        Console.WriteLine(str1.ToUpper());
        Console.WriteLine(str1.ToLower());
    }
}