using System;
Console.WriteLine("introduceti lungimea vectorului");
int n = int.Parse(Console.ReadLine());
int[] vec = new int[n];
for (int i = 0; i < vec.Length; i++)
{
    Console.WriteLine($"introduceti numarul de pe pozitia {i}");
    vec[i] = int.Parse(Console.ReadLine());
}
int x = vec[vec.Length - 1];
for (int i = vec.Length - 1; i > 0; i--)
{
    vec[i] = vec[i - 1];
}
vec[0] = x;
for (int i = 0; i < vec.Length; i++)
{
    Console.WriteLine(vec[i]);
}