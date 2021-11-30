using System;

namespace pb37
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("input the length of the fibonacci sequence you want to generate");
            //since we know fibonacci terms can't be constructed with negative numbers, all values will be  uint, unsigned integer.
            uint n = uint.Parse(Console.ReadLine());
            uint term; //the current term
            //we initialise and display the first two known terms
            uint prev1 = 0;//the previous term in the sequence
            uint prev2 = 1;// two positions to the left of the current term
            for (int i = 3; i <= n + 1; i++)
            {
                //this can overflow quite easily, so we check for it
                try
                {
                    checked { term = prev1 + prev2; }
                    Console.WriteLine(term);
                    prev2 = prev1;
                    prev1 = term;
                }

                catch (OverflowException)
                {
                    Console.WriteLine($"error while computing Fibonacci sequence. The operation caused an overflow at the term numbered {i}");
                    Environment.Exit(-1);
                }
            }
        }
    }
}
