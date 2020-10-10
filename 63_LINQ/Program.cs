using System;
using System.Collections.Generic;
using System.Linq;

namespace _63_LINQ
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee{LastName = "Ivanov", FirstName = "Ivan"},
                new Employee{LastName = "Petrov", FirstName = "Petr"},
                new Employee{LastName = "Sidorov", FirstName = "Sidor"},
            };

            var query = from emp in employees
                        let fullname = emp.FirstName + " " + emp.LastName
                        orderby fullname
                        select fullname;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}