using System;

namespace _03_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.age = 18;
            user.login = "login";
            user.name = "name";
            user.surname = "surname";
            Console.WriteLine(user);
            Console.ReadKey();
        }
    }
}
