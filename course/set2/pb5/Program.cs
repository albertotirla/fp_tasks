using System;

namespace pb5
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("introduceti lungimea secventei, numar natural diferit de 0");
            int length = int.Parse(Console.ReadLine());
            int pos = 0;
            int cur_num;
            int counter=0; //acumulator pentru toate elementele ce indeplinesc conditia
            while (pos < length)
            {
                Console.WriteLine($"introduceti termenul {pos + 1}");
                cur_num = int.Parse(Console.ReadLine());
                if(cur_num==pos)
                {
                    counter++;
                }
                pos++;
            }
Console.WriteLine($"numarul de elemente egale cu pozitia lor in secventa este {counter}");
        }
    }
}
