using System;
using System.Collections.Generic;

namespace Generic_Collection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region employeesArray

            Employee[] employeesArray =
                {
                    new Employee {Name = "Ivan"},
                    new Employee {Name = "Andrew"}
                };
            foreach (Employee item in employeesArray)
            {
                Console.WriteLine(item.Name);
            }
            Array.Resize(ref employeesArray, 3);
            employeesArray[2] = new Employee { Name = "Petya" };
            for (int i = 0; i < employeesArray.Length; i++)
            {
                Console.WriteLine(employeesArray[i].Name);
            }

            #endregion employeesArray

            #region employeesList

            Console.WriteLine(new string('_', 50));

            List<Employee> employeesList = new List<Employee>()
            {
                new Employee {Name = "Ivan"},
                new Employee {Name = "Andrew"}
            };
            foreach (var item in employeesList)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            employeesList.Add(new Employee { Name = "Evgeni" });
            foreach (var item in employeesList)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(employeesList.Capacity);

            #endregion employeesList

            Console.ReadLine();
        }
    }
}