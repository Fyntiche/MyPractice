using System;

namespace _31_Delegates
{
    public delegate void MySum(ref int a, ref int b, out int summa);

    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 5, b = 6, summa;
            MySum mySum = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b; };
            mySum(ref a, ref b, out summa);
            Console.WriteLine(summa);
        }
    }
}