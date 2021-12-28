//am decis sa rezolv aceasta problema intr-un mod diferit, cu ajutorul unei caracteristici noi din limbajul c#, top level statements
using System;
Console.WriteLine("introduceti lungimea secventei, numar natural diferit de 0");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("introduceti termenul 1");
int prev_num=int.Parse(Console.ReadLine());
bool crescator=true;//presupunem ca secventa este ordonata crescator
int pos = 1;//deja am citit un element cu variabila prev_num
while (pos < length)
{
    Console.WriteLine($"introduceti termenul {pos + 1}");
    int cur_num = int.Parse(Console.ReadLine());
    if(prev_num>cur_num)
    {
        crescator=false;
        }
    pos++;
prev_num=cur_num;
}

if(crescator)
{
    System.Console.WriteLine("secventa este ordonata crescator");
}
else
{
    System.Console.WriteLine("secventa nu este ordonata crescator");
}