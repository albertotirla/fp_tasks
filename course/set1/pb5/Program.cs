using System;

namespace pb5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int counter = 0;
            int cifra = 0;
            int temp = n;
            while (temp != 0)
            {
                cifra = temp % 10;
                counter++;
                if (counter == k)
                {
                    Console.WriteLine(cifra);
                    Environment.Exit(0);
                }
                temp /= 10;
            }
            Console.WriteLine($"nu s-a gasit cifra a {k}-a in numarul {n}");
        }
    }
}
