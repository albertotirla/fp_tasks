using System;
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
for (int i = k; i < vec.Length - 1; i++)
{
    vec[i] = vec[i + 1];
}
//pentru ca incerc sa nu folosesc metode specifice .net, ultimul element va fi ascuns de la afisare, marimea vectorului nu va fi modificata
n--;
for (int i = 0; i < n; i++)
{
    Console.WriteLine(vec[i]);
}