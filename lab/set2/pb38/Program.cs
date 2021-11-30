using System;

namespace pb38
{
    class Program
    {
        //just for fun, this one will be done recursively
        //since we know factorial of [x where x<0] doesn't make sense, we use the type system to inforce that for us, all parameters are unsigned integers
        static uint factorial(uint n)
        {
            if (n <= 1) return 1;
            else return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
            //we know factorial(3)=6, so we test it here, as not to introduce extraneous boilerplate
            if (factorial(3) == 6)
            {
                Console.WriteLine("everything works right");
            }
            else
            {
                Console.WriteLine("something is definitely wrong");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
