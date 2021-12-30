using System;

namespace pb7
{
    class Program
    {
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
            
            int inceput = 0;
            int sfarsit = vec.Length - 1;
            while (inceput < sfarsit)
            {
                vec[inceput] ^= vec[sfarsit];
                vec[sfarsit] ^= vec[inceput];
                vec[inceput] ^= vec[sfarsit];
                inceput++;
                sfarsit--;
            }
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            }
        }
    }
}
