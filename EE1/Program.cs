using System;

namespace EE1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Human human = new Human() { Name = "Ivan" };
            human.MyMethod();
            Console.ReadLine();
        }
    }

    internal class Human
    {
        public string Name { get; set; }

        public void MyMethod()
        {
            Console.WriteLine(Name);
        }
    }
}