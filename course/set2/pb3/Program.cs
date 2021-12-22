using System;

namespace pb3
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("n=");
int n=int.Parse(Console.ReadLine());
            int s=0;//suma
            int p=1;//produs
            for(int i=1;i<=n;i++)
            {
                s+=i;
                p*=i;
            }
            Console.WriteLine($"suma este {s}, produsul este {p}");
            //end
        }
    }
}
