using System;

namespace pb10
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            for (uint i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} nu este prim");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine($"{n} este prim");
        }
    }
}
