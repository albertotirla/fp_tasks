using System;

namespace pb8
{
    class Program
    {
        static void Main(string[] args)
        {
            //pentru ca in problema anterioara nu am folosit alte variabile suplimentare, solutia pentru aceasta va fi asemanatoare, numai ca voi folosi adunari si scaderi in loc de xor
            //varianta aceasta este vulnerabila la rezultate gresite din cauza depasirii, pentru ca adunarea a doua numere int nu este garantat ca nu depaseste marimea unui int.
            Console.WriteLine("introduceti numerele care sa fie inversate");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"inainte de swap: a={a}, b={b}");
            a = a + b;
            b = a-b;
            a = a - b;
            Console.WriteLine($"dupa swap: a={a}, b={b}");

        }
    }
}
