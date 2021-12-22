using System;

namespace pb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea secventei, numar natural diferit de 0");
            int length = int.Parse(Console.ReadLine());
            int pos = 0;
            int cur_num;
            int n_pare=0;
            while (pos < length)
            {
                Console.WriteLine($"introduceti termenul {pos + 1}");
                cur_num = int.Parse(Console.ReadLine());
                if(cur_num%2==0)
                {
                    n_pare++;
                }
                pos++;
            }
        if(n_pare!=0)
        {
            Console.WriteLine($"am gasit {n_pare} numere pare in secventa");
                }
else
{
    Console.WriteLine("nu am gasit numere pare");
}
        }
    }
}
