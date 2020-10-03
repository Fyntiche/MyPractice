using System;
using System.Runtime.CompilerServices;

namespace _30_Delegates
{
    public delegate int Sum(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 6;
            Sum sum = delegate (int a, int b) { return a + b; };
            int sum1 = sum(a, b);
            Console.WriteLine(sum1);

            Console.ReadLine();
        }
    }
}
