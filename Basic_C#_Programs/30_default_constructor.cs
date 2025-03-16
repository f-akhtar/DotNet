// C# file generated automatically

// default constructor
using System;

class A
{
    public int num;
    
    public A()
    {
        num = 100;
    }
    
    public void show()
    {
        Console.WriteLine(num);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        A va = new A();
        va.show();
    }
}