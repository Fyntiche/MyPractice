using System;
using System.Threading;

namespace _13._0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Print();
        }
    }

    internal class MyClass
    {
        public void Print()
        {
            Console.WriteLine(Thread.CurrentThread.GetHashCode());
            new Thread(Print).Start();
        }
    }
}