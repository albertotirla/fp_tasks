using System;

namespace pb10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea secventei, numar natural diferit de 0");
            int length = int.Parse(Console.ReadLine());
            System.Console.WriteLine("introduceti termenul 1");
            int prev_num = int.Parse(Console.ReadLine());
            int pos = 1;
            int cur_num;
            int lung = default;//lungimea unei astfel de subsecvente ca in cerinta, se va reseta la primul element care nu indeplineste conditia
            int max_lung = default;//lungimea maxima
            while (pos < length)
            {
                Console.WriteLine($"introduceti termenul {pos + 1}");
                cur_num = int.Parse(Console.ReadLine());
                if (prev_num == cur_num)
                {
                    lung++;
                }
                if (lung > max_lung)
                {
                    max_lung = lung;
                }
                pos++;
                prev_num = cur_num;
            }
            System.Console.WriteLine($"numarul maxim de numere egale din secventa este {max_lung}");
        }
    }
}
