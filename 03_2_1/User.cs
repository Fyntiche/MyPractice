using System;
using System.Collections.Generic;
using System.Text;

namespace _03_2_1
{
    class User
    {
        public string login;

        public string name;

        public string surname;

        public int age;

        readonly DateTime date;

        public User()
        {
            date = DateTime.Now;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + age + " " + login + " "+ date;
        }
    }
}
