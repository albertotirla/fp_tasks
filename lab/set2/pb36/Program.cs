using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace pb36
{
    class Program
    {
        static void cif_and_sum(int x)
        {
            int sum=0;
            int cif=0;
            //for optimisation and because of the way we need to display the final output, I chose the StringBuilder type
            var sb=new StringBuilder();
            sb.Append("cifrele numarului sunt: ");
        while(x!=0)
        {
cif=x%10;
x/=10;
sb.Append($"{cif}, ");
        sum+=cif;
        }
        sb.Append("\n");
        sb.Append($"suma cifrelor este: {sum}");
        Console.WriteLine(sb.ToString()); //display what we did
        }
        static void Main(string[] args)
        {
            Console.WriteLine("type a number, then press enter");
            int number=int.Parse(Console.ReadLine());
        cif_and_sum(number);
        }
    }
}
