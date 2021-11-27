using System;

namespace pb2
{
    enum Operations
    {
        add = 1,
        subtract = 2,
        multiply = 3,
        divide = 4,
        sqrt = 5,
        abs = 6,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operations ops;
            Console.WriteLine("choose an operation\n1=add, 2=subtract, 3=multiply, 4=devide, 5=sqrt, 6=abs");
            ops = Enum.Parse<Operations>(Console.ReadLine(), true); //again, omitting error checking
            int a, b; //the two numbers for the calculator
            Console.WriteLine("pick a number, any number");
            a = int.Parse(Console.ReadLine());
            //we read b only if we need it
            switch (ops)
            {
                case Operations.add:
                    Console.WriteLine("type the second number");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + b);
                    break;
                case Operations.subtract:
                    Console.WriteLine("type the second number");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a - b);
                    break;
                case Operations.multiply:
                    Console.WriteLine("type the second number");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a * b);
                    break;
                case Operations.sqrt:
                    Console.WriteLine(Math.Sqrt(a));
                    break;
                case Operations.abs:
                    Console.WriteLine(Math.Abs(a));
                    break;
            }
        }
    }
}
