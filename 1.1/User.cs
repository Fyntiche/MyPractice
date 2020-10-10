using System;

namespace _1._1
{
    internal class User
    {
        private string login;
        private string firstName;
        private string lastName;

        public string Login
        {
            get
            {
                if (login == null)
                    return "Поле не заполнено";
                return login;
            }
            set { login = value; }
        }

        public string FirstName
        {
            get
            {
                if (firstName == null)
                    return "Поле не заполнено";
                return firstName;
            }
            set { firstName = value; }
        }

        public string LastName
        {
            get
            {
                if (lastName == null)
                    return "Поле не заполнено";
                return lastName;
            }
            set { lastName = value; }
        }

        public int Age { get; set; }

        public DateTime Date { get; }

        public User()
        {
            Date = DateTime.Now;
        }

        public User(string login, string firstName, string lastName, int age)
            : this()
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("FirstName = {0}, LastName = {1}, Age = {2}, Date = {3}", FirstName, LastName, Age, Date);
        }
    }
}