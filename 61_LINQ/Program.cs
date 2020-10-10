using System;
using System.Collections.Generic;
using System.Linq;

namespace _61_LINQ
{
    internal class Employee
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }

    internal class EmployeNationality
    {
        public string Id { get; set; }

        public string Nationality { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var employee = new List<Employee>
            {
                new Employee {Id = "1", Name = "Ivan"},
                new Employee {Id = "2", Name = "Petya"},
                new Employee {Id = "3", Name = "Vasya"}
            };

            var enployeNat = new List<EmployeNationality>
            {
                new EmployeNationality {Id="1", Nationality ="Russian"},
                new EmployeNationality {Id="2", Nationality = "England"}
            };

            var query = from emp in employee
                        join empNat in enployeNat
                        on emp.Id equals empNat.Id
                        orderby empNat.Nationality descending
                        select new
                        {
                            emp.Id,
                            emp.Name,
                            empNat.Nationality
                        };
            foreach (var emp in query)
            {
                Console.WriteLine("Id ={0}, Name = {1}, Nationality = \t{2}", emp.Id, emp.Name, emp.Nationality);
            }
            Console.ReadKey();
        }
    }
}