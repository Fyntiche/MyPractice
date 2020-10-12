using System;

namespace _10._0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Class test = MyClass<Class>.FactoryMethod();
            test.Name = "string";
            Console.WriteLine(test.Name);
            Console.ReadLine();
        }
    }
}