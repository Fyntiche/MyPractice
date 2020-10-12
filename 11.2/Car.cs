using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _11._2
{
    public class Car
    {
        private string Name { get; set; }

        private int Year { get; set; }

        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return Name + " " + Year;
        }
    }
}