using System;

namespace pb8
{
    class Program
    {
            public static int fib(int n)
    {
        if (n <= 1) {
            return n;
        }
        int previousFib = 0, currentFib = 1;
        for (int i = 0; i < n - 1; i++)
        {
            int newFib = previousFib + currentFib;
            previousFib = currentFib;
            currentFib = newFib;
        }
        return currentFib;
    }
        static void Main(string[] args)
        {
            System.Console.WriteLine("n=");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine($"termenul {n} din sirul lui Fibonacci este {fib(n)}");
        }
    }
}
