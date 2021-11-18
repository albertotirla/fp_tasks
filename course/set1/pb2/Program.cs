using System;
using System.Security.Cryptography.X509Certificates;

namespace pb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("nu este o ecuatie de gradul 2");
                Environment.Exit(-1);
            }
            int delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1={x1}\nx2={x2}");
            }
            if (delta == 0)
            {
                int x = (-b) / (2 * a);
                Console.WriteLine($"x={x}");
            }
            else
            {
                //pentru simplitate, ne folosim de faptul ca cele doua radacini complexe ale ecuatiei sunt conjugate, le calculam partile o singura data.
                int re = (-b) / (2 * a);
                double im = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine($"x1={re}+i{im}");
                Console.WriteLine($"x2={re}-i{im}");
            }
        }
    }
}
