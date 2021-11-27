using System;

namespace pb4
{
    class Program
    {
        static int sum_div(int n)
        {
            int s=0;
            for(int i=1;i<=n/2;i++)
            {
                if(n%i==0) s+=i;
            }
        return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("type a number");
            int n=int.Parse(Console.ReadLine());
            if(sum_div(n)==n)
            {
                Console.WriteLine("yes");
            }
        else
        {
            Console.WriteLine("no");
        }
        }
    }
}
