using System;

namespace _02_Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Product product = factory.FactoryMethod();
            Console.ReadKey();
        }
    }
}
