using System;
using System.Threading;

namespace _47_Threads
{
    internal class Program
    {
        private static void WriteSecond(object argument)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(argument);
                Thread.Sleep(500);
            }
        }

        private static void Main(string[] args)
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start("hello");
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("Ivan");
                //Thread.Sleep(10000);
            }
            //WriteSecond("Ivan");
            //Thread.Sleep(500);
            Console.ReadKey();
        }
    }
}