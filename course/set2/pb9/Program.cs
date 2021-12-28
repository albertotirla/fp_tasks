using System;

namespace pb9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea secventei, numar natural diferit de 0");
            int length = int.Parse(Console.ReadLine());
            System.Console.WriteLine("introduceti termenul 1");
int prev_num=int.Parse(Console.ReadLine());
                        System.Console.WriteLine("introduceti termenul 2");
                        int cur_num=int.Parse(Console.ReadLine());
            int pos = 2;
bool crescator=prev_num<cur_num, monoton=true;
prev_num=cur_num;
            while (pos < length)
            {
                Console.WriteLine($"introduceti termenul {pos + 1}");
                cur_num = int.Parse(Console.ReadLine());
                if(cur_num<prev_num&&crescator)
                {
                    monoton=false;
                }
                pos++;
            prev_num=cur_num;
            }
            if(monoton)
            {
                Console.WriteLine("secventa este monotona");
            }
        else
        {
            System.Console.WriteLine("secventa nu este monotona");
        }
        }
    }
}
