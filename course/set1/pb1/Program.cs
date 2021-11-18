using System;

namespace pb1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            /*
                pentru ecuatia de gradul 1(ax+b=0), se aplica rationamentul:
                ax=-b ->
                x=-b/a.
        */
            //cazuri particulare: cand a=0, ecuatia nu are sens. Cand b=0, rezultatul este 0.
            if (a == 0)
            {
                Console.WriteLine("invalid equation");
                Environment.Exit(-1);
            }
            if (b == 0)
            {
                Console.WriteLine("0");
            }
            //rezolvarea ecuatiei fara cazurile particulare
            int x = -b / a;
            Console.WriteLine(x);
        }
    }
}
