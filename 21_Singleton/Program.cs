using System;

namespace _21_Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance();
            Singleton singleton1 = Singleton.Instance();

            if (singleton1 == singleton)
                Console.WriteLine("True");

            Console.ReadLine();
        }
    }
}