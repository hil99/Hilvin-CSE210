using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is yout first name? ");
        string first = Console.ReadLine();

        Console.Write("What is yout last name? ");
        string last = Console.ReadLine();
    
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}