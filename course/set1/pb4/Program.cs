using System;

namespace pb4
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            //pentru ca anul y sa fie un an bisect, trebuie sa fie multiplu de 4. Pentru a preveni exceptii precum 100, y trebuie sa fie multiplu de 4 si nu de 100, sau de 400.
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            {
                Console.WriteLine("da");
            }
            else
            {
                Console.WriteLine("nu");
            }
        }
    }
}
