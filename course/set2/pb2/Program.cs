using System;

namespace pb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea secventei, numar natural diferit de 0");
            int length = int.Parse(Console.ReadLine());
            int pos = 0;
            int cur_num;
            int n_neg=0, n_zero=0, n_poz=0;
            while (pos < length)
            {
                Console.WriteLine($"introduceti termenul {pos + 1}");
                cur_num = int.Parse(Console.ReadLine());
                if(cur_num<0)
                {
                    n_neg++;
                }
                else if(cur_num==0)
                {
                    n_zero++;
                }
                else
                {
                    n_poz++;
                }
                pos++;
            }
            Console.WriteLine($"avem {n_neg} numere negative, {n_zero} zero-uri si {n_poz} numere pozitive");
        }
    }
}
