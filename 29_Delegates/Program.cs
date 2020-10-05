using System;

namespace _29_Delegates
{
    public delegate void MyDelegate();

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate { Console.WriteLine("MyDelegate"); };
            myDelegate();
            Console.ReadLine();
        }
    }
}