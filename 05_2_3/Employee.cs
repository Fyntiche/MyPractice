using System;
using System.Collections.Generic;
using System.Text;

namespace _05_2_3
{
    class Employee
    {
        readonly string name;

        readonly string surname;
        public int staj=1;

        public int oklad=500;

        public int Staj
        {
            get => staj;
            set
            {
                if (value < 0) Console.WriteLine("Стаж должен быть положительным");
                else staj = value;
            }
        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Oklad()
        {
            Console.WriteLine(name + " " + surname + " "+staj + " " + oklad*staj);
        }


    }
}
