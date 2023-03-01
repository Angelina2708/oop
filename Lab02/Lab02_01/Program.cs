using System;

namespace DuplicateArrayElements
{
    static class ArrayExtensions
    {
        public static int[] DuplicateElements(this int[] source)
        {
            int[] destination = new int[source.Length * 2];
            for (int i = 0; i < source.Length; i++)
            {
                destination[2 * i] = source[i];
                destination[2 * i + 1] = source[i];
            }
            return destination;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] destination = source.DuplicateElements();
            Console.WriteLine("Source array: [{0}]", string.Join(", ", source));
            Console.WriteLine("Destination array: [{0}]", string.Join(", ", destination));
        }
    }
}