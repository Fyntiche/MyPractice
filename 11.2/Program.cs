using System;

namespace _11._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarCollection carCollection = new CarCollection
            {
                { "bmv", DateTime.Now.Year },
                { "audi", DateTime.Now.Year },
                { "volvo", DateTime.Now.Year }
            };
            foreach (Car item in carCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}