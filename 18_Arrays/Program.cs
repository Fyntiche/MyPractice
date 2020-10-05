using System;

namespace _18_Arrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            array = new int[5];
            array = new int[] { 1, 2, 3, 4, 5 };
            array = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}