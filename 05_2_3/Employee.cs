using System;

namespace _05_2_3
{
    internal class Employee
    {
        private readonly string name;

        private readonly string surname;
        public int staj = 1;

        public int oklad = 500;

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
            Console.WriteLine(name + " " + surname + " " + staj + " " + oklad * staj);
        }
    }
}