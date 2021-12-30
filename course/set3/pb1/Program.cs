using System;
using System.Security;

namespace pb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine($"introduceti numarul de pe pozitia {i}");
                vec[i] = int.Parse(Console.ReadLine());
            }
            //done
        int suma=0;
        for (int i = 0; i < vec.Length; i++)
        {
         suma+=vec[i];
        }
        Console.WriteLine($"suma este {suma}");
        }
    }
}
