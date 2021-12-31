using System;

namespace pb10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            Console.WriteLine("k=");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine($"introduceti numarul de pe pozitia {i}");
                vec[i] = int.Parse(Console.ReadLine());
            }
            int inceput = 0, sfarsit = vec.Length - 1;
            int mijloc;
            int pozitie = -1;
            while (inceput <= sfarsit)
            {
                mijloc = (inceput + sfarsit) / 2;
                if (k == vec[mijloc])
                {
                    pozitie = mijloc;
                    break;
                }
                else if (k < vec[mijloc])
                {
                    sfarsit = mijloc - 1;
                }
                else
                {
                    inceput = mijloc + 1;
                }
            }
            Console.WriteLine($"elementul {k} a fost gasit pe pozitia {pozitie}");
        }
    }
}
