using System;

namespace pb7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti numerele care sa fie inversate");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"inainte de swap: a={a}, b={b}");
        a=a^b;
        b=b^a;
        a=a^b;
        Console.WriteLine($"dupa swap: a={a}, b={b}");
        }
    }
}
