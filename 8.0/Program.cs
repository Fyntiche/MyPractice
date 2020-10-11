using System;

namespace _8._0
{
    internal class Program
    {
        private delegate void Sum(int a, int b, int c);

        private static void Main(string[] args)
        {
            Sum srt = null;
            srt += Add;
            srt += (a, b, c) => Console.WriteLine(a + b + c);
            srt(1, 2, 3);
            Console.ReadKey();
        }

        private static void Add(int a, int b, int c)
        {
            Console.WriteLine((a + b + c) / 3);
        }
    }
}