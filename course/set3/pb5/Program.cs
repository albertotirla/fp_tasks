using System;

Console.WriteLine("introduceti lungimea vectorului");
int n = int.Parse(Console.ReadLine());
int[] vec = new int[n + 1];//alocam spatiu pentru elementul inserat
Console.WriteLine("e=");
int e = int.Parse(Console.ReadLine());
Console.WriteLine("k=");
int k = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"introduceti numarul de pe pozitia {i}");
    vec[i] = int.Parse(Console.ReadLine());
}
if (k < vec.Length && k >= 0)
{

    for (int i = vec.Length - 1; i > k; i--)
    {
        vec[i] = vec[i - 1];
    }
    vec[k] = e;
}
else
{
    Console.WriteLine("pozitie invalida");
}
for (int i = 0; i < vec.Length; i++)
{
    Console.WriteLine(vec[i]);
}