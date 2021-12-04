using System;

namespace pb3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for sorting, the best way is to make use of the tools provided by the programming language/environment the program is written in, so I am going to use that.
            //read the size and elements of an array from stdin
            Console.WriteLine("how large should the array be? ");
            int size = int.Parse(Console.ReadLine());
            int[] vec = new int[size];
            for (int i = vec.GetLowerBound(0); i <= vec.GetUpperBound(0); i++)
            {
                Console.WriteLine($"enter element at index {i}");
                vec[i] = int.Parse(Console.ReadLine());
            }
            //calculate the middle of the array first
            int mid = vec.Length / 2;
            //instantiate the comparer class
            var cmp = new DescendingComparer();
            
            //sort the first half in ascending order, therefore use the default comparer
            Array.Sort(vec, 0, mid + 1);
            //the other half is sorted in descending order, so using the custom comparer
            Array.Sort(vec, mid , vec.Length - mid , cmp);
            //print the elements of the resulting array
            foreach (int i in vec)
            {
                Console.WriteLine(i);
            }
        }
    }
}
