using System;

namespace _54_Anonymous
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var instance = new { Name = "Ivan", Age = 25 };
            Console.WriteLine("Name = {0}, age = {1}", instance.Name, instance.Age);

            Type type = instance.GetType();
            Console.WriteLine(type);

            Console.ReadLine();
        }
    }
}