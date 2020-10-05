using System;

namespace _02_Association
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Factory factory = new Factory();
            Product product = factory.FactoryMethod();
            Console.ReadKey();
        }
    }
}