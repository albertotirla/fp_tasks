using System;

namespace pb9
{
    class Program
    {
        static void Main(string[] args)
        {
            //presupunem ca numarul este pozitiv, asa ca punem restrictii asupra datelor citite
            uint n = uint.Parse(Console.ReadLine());
            //se vor determina toti divizorii proprii ai numarului
            for (uint i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
