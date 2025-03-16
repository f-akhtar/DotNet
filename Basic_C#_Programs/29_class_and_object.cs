// C# file generated automatically
using System;

class Mobile
{
    public int price; // access_modifier : public
    public string storage;
    public string color;
    
    public void calling()
    {
        Console.WriteLine("Voice Msg");
    }
    
    public void chatting()
    {
        Console.WriteLine("Text Msg");
    }
    
    public void music()
    {
        Console.WriteLine("Song...");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Mobile m = new Mobile();
        m.price = 10000;
        m.storage = "8 GB RAM";
        m.color = "Black";
        
        Console.WriteLine(m.price);
        Console.WriteLine(m.storage);
        Console.WriteLine(m.color);
        
        m.calling();
        m.chatting();
        m.music();
    }
}