using System;
using System.Linq;

namespace pb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type the length of the array");
            int length = int.Parse(Console.ReadLine());
            int[] s1 = new int[length];
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine($"enter term number {i}");
                s1[i] = int.Parse(Console.ReadLine());
            }
            int[] s2 = new int[length];
            Array.Copy(s1, s2, s1.Length);
            //another way to sort in descending order
            Array.Sort(s2);
            Array.Reverse(s2);
            int count = 0; //how many terms are at the same position in both arrays
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
