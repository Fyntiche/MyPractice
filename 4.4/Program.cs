using System;
using System.Runtime.CompilerServices;

namespace _4._4
{
    internal static class Extenshial
    {
        public static void SortArray(this int[] array)
        {
            Console.WriteLine("array sorting...");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arrays = { 1, 2, 3, 4, 5, 6 };
            arrays.SortArray();
            Console.ReadLine();
        }
    }
}