using System;

namespace pb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea secventei, numar natural diferit de 0");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti numarul cautat");
            int a=int.Parse(Console.ReadLine());
            int num_in_sec=-1;//pozitia numarului in secventa
            int pos = 0;
            int cur_num;
            while (pos < length)
            {
                Console.WriteLine($"introduceti termenul {pos + 1}");
                cur_num = int.Parse(Console.ReadLine());
                if(cur_num==a)
                {
                    num_in_sec=pos;
                    break;
                }
                pos++;
            }
            Console.WriteLine($"am gasit numarul {a} pe pozitia {num_in_sec}");
        }
    }
}
