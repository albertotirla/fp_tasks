using System;

namespace pb3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("da");
            }
            else
            {
                Console.WriteLine("nu");
            }
        }
    }
}
