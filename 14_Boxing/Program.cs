using System;

namespace _14_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 25;

            object o = a;

            short b = (short)o;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
