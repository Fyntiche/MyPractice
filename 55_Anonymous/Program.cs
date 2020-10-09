using System;

namespace _55_Anonymous
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var instance = new { Name = "Ivan", Age = 25, Id = new { Number = 123 } };

            Console.WriteLine("Name = {0}, Age = {1}, Id = {2}", instance.Name, instance.Age, instance.Id.Number);
            Console.ReadLine();
        }
    }
}