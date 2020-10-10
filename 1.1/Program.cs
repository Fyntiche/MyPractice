using System;
using System.Text;

namespace _1._1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            User user = new User("fynt", null, "Eryomov", 25);
            Console.WriteLine(user);
            Console.ReadLine();
        }
    }
}