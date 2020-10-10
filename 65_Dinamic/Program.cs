using System;

namespace _65_Dinamic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            dynamic dynamic = 1;
            Console.WriteLine(dynamic.GetType());

            dynamic = "12";
            Console.WriteLine(dynamic);

            Console.ReadLine();
        }
    }
}