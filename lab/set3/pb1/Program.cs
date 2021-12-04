using System;

namespace pb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type sequence length");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"type term {i}");
                v[i] = int.Parse(Console.ReadLine());
            }
            //in order to do the task, a sort is required
            Array.Sort(v);
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (v[i] == v[j] + v[k]) Console.WriteLine(v[i]);
                    }
                }
            }
        }
    }
}
