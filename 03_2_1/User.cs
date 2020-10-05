using System;

namespace _03_2_1
{
    internal class User
    {
        public string login;

        public string name;

        public string surname;

        public int age;

        private readonly DateTime date;

        public User()
        {
            date = DateTime.Now;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + age + " " + login + " " + date;
        }
    }
}