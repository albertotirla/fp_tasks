using System;

namespace pb3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            // suppose the division reminder between ij and k means i*j%k. If i=2, j=3, k=6, the program will print 0
            Console.WriteLine((i * j) % k);
        }
    }
}
