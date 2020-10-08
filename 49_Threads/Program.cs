using System;
using System.Text;
using System.Threading;

namespace _49_Threads
{
    internal class Program
    {
        private static object block = new object();

        private static void Print()
        {
            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("поток = {0}, i= {1} ", Thread.CurrentThread.GetHashCode(), i);
                    Thread.Sleep(300);
                }
                Console.WriteLine(new string('_', 50));
            }
        }

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 4; i++)
            {
                new Thread(Print).Start();
            }
            Console.ReadLine();
        }
    }
}