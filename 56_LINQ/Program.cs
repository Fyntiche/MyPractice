using System;
using System.Collections.Generic;
using System.Linq;

namespace _56_LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 900,
                    StartDate = DateTime.Parse("1/1/1989")
                },
                new Employee
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 1100,
                    StartDate = DateTime.Parse("2/2/1989")
                },
                new Employee
                {
                    FirstName = "Sidor",
                    LastName = "Sidorov",
                    Salary = 750,
                    StartDate = DateTime.Parse("3/3/1989")
                },
                new Employee
                {
                    FirstName = "Gohcn",
                    LastName = "Gohcnov",
                    Salary = 600,
                    StartDate = DateTime.Parse("4/4/1989")
                },
            };

            var query = from employee in employees
                        where employee.Salary > 800
                        orderby employee.FirstName, employee.LastName
                        select new
                        {
                            employee.LastName,
                            employee.FirstName,
                            employee.StartDate
                        };

            foreach (var item in query)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.StartDate);
            }
            Console.ReadLine();
        }
    }
}