using System;

namespace pb7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea secventei, numar natural diferit de 0");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti termenul 1");
            int cur_num = int.Parse(Console.ReadLine());
            int pos = 1;//am citit deja un termen, folosit pentru initializarea minimului si a maximului cu prima valoare din sir
int minim=cur_num, maxim=cur_num;
            while (pos < length)
            {
                Console.WriteLine($"introduceti termenul {pos + 1}");
                cur_num = int.Parse(Console.ReadLine());
                if(cur_num<minim)
                {
                    minim=cur_num;
                }
                if(cur_num>maxim)
                {
                    maxim=cur_num;
                }
                pos++;
            }
            System.Console.WriteLine($"cel mai mic numar din secventa este {minim}, iar cel mai mare termen este {maxim}");
        }
    }
}
