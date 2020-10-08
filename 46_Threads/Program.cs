using System;
using System.Threading;

namespace _46_Threads
{
    internal class Program
    {
        private static void WriteSecond()
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.Name == null ? "sec" : thread.Name);
            Console.WriteLine(thread.ManagedThreadId);
            Console.WriteLine(thread.CurrentCulture);
            Console.WriteLine(thread.ExecutionContext);
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine(thread.IsBackground);
            Console.WriteLine(thread.IsThreadPoolThread);
            Console.WriteLine(thread.ManagedThreadId);
            Console.WriteLine(thread.Priority);
            Console.WriteLine(thread.ThreadState);

            int count = 0;
            while (count < 1)
            {
                count++;
                Console.WriteLine("Thread id = {0} count = {1}", Thread.CurrentThread.GetHashCode(), count);
            }
        }

        private static void Main(string[] args)
        {
            Thread writeSecond = new Thread(WriteSecond);
            writeSecond.Start();
            Thread primariThread = Thread.CurrentThread;
            primariThread.Name = "pri";
            int count = 0;
            Console.WriteLine(primariThread.Name == null ? "sec" : primariThread.Name);

            while (count < 1)
            {
                count++;
                Console.WriteLine("Thread id = {0} count = {1}", primariThread.GetHashCode(), count);
            }
            Console.ReadKey();
        }
    }
}