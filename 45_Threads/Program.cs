using System;
using System.Threading;

namespace _45_Threads
{
    internal class Program
    {
        private static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine("WriteSecond");
            }
        }

        private static void WriteSecond2()
        {
            while (true)
            {
                Console.WriteLine("                DoblSecond________________________");
            }
        }

        private static void Main(string[] args)
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            ThreadStart doblSecond = new ThreadStart(WriteSecond2);
            Thread thread = new Thread(writeSecond);
            Thread thread1 = new Thread(doblSecond);
            thread.Start();
            thread1.Start();
            while (true)
            {
                Console.WriteLine("Main");
            }
            Console.ReadLine();
        }
    }
}