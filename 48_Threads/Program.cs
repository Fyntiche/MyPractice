using System;
using System.Threading;

namespace _48_Threads
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = 0;
            Thread thread = new Thread(() => { Console.WriteLine("1"); count++; });
            thread.Start();

            Thread.Sleep(100);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}