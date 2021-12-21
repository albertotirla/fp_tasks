using System;

namespace pb6
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaram variabilele
            Console.WriteLine("introduceti valori pentru verificare");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (
                a + b > c &&
                a + c > b &&
                b + c > a
        )
            {
                Console.WriteLine($"{a}, {b} si {c} pot forma un triunghi");
            }
            else
            {
                Console.WriteLine($"{a}, {b} si {c} nu pot forma un triunghi");
            }
        }
    }
}
