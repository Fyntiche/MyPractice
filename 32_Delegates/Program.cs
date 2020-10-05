using System;

namespace _32_Delegates
{
    public delegate int Sun(int x);

    internal class Program
    {
        private static void Main(string[] args)
        {
            Sun sun = (x) => { return x * 2; };
            Console.WriteLine(sun(2));
            Console.ReadLine();
        }
    }
}