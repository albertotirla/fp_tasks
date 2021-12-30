using System;

namespace pb3
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
            int minim = vec[n - 1], maxim = vec[0];
            int poz_minim = -1, poz_maxim = -1;
            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] > maxim)
                {
                    maxim = vec[i];
                    poz_maxim = i;
                }
                if (vec[i] < minim)
                {
                    minim = vec[i];
                    poz_minim = i;
                }
            }
            Console.WriteLine($"pozitia celui mai mic element din vector este {poz_minim}\nPozitia celui mai mare element din vector este {poz_maxim}");
        }
    }
}
