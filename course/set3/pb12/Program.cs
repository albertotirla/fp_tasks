using System;

namespace pb12
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine($"introduceti numarul de pe pozitia {i}");
                vec[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vec.Length - 1; i++)
            {
                for (int j = i + 1; j < vec.Length; j++)
                {
                    if (vec[i] > vec[j])
                    {
                        swap(ref vec[i], ref vec[j]);
                    }
                }//for2
            }//for1
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            }
        }
    }
}
