using System;
using System.Threading;

namespace _50_Threads
{
    internal class Program
    {
        private static object locker = new object();

        private static void Print()
        {
            for (int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("second");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
        }

        private static void Main(string[] args)
        {
            new Thread(Print).Start();
            for (int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string('_', 50) + "primary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
            Console.ReadLine();
        }
    }
}