using System;

namespace pb9
{
    class Program
    {
        static void RotireLaStanga(int[] array)
        {
            //codul din aceasta functie este o copie aproximativa a problemei anterioare
            int x = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = x;
        }

        static void Main(string[] args)
        {
            //in main
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
            for (int i = 0; i < k; i++)
            {
                //o modalitate de a roti un vector cu k pozitii spre dreapta poate fi sa aplicam operatia de rotire cu o singura pozitie, intr-o bucla care se executa de k ori. In continuare, ma voi folosi de solutia anterioara
                RotireLaStanga(vec);
            }
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            }
        }
    }
}

