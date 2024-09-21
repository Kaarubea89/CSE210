using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("What is your First Name?");
        string  first_name = Console.ReadLine();

        Console.WriteLine("What is your Last Name?");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Hello {first_name} {last_name}!");

    }
}