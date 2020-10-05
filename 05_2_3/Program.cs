using System;

namespace _05_2_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee employee = new Employee("ivan", "eremov");
            Console.WriteLine("Введите стаж");
            int.TryParse(Console.ReadLine(), out int result);
            employee.Staj = result;
            employee.Oklad();
            Console.ReadKey();
        }
    }
}