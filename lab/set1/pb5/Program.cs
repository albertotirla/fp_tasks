using System;

namespace pb5
{
    class Program
    {
        static bool perfect(int n)
        {
            int s = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0) s += i;
            }
            if (n == s)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (perfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
