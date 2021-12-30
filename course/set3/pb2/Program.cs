using System;

namespace pb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea vectorului");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti valoarea cautata");
            int k = int.Parse(Console.ReadLine());
            int pos_elem = -1;//pozitia elementului unde valoarea a fost gasita
            int[] vec = new int[n];
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine($"introduceti numarul de pe pozitia {i}");
                vec[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] == k)
                {
                    pos_elem = i;
                }
            }
            Console.WriteLine($"pozitia pe care s-a gasit elementul {k} este {pos_elem}");
        }
    }
}
