using System;
using System.Collections.Generic;
using System.Text;

namespace _15._2
{
    internal class WorkerCollection
    {
        public Worker[] workers = new Worker[5];

        public void Run()
        {
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Write fam");
                string fam = Console.ReadLine();
                Console.WriteLine("Write prof");
                string prof = Console.ReadLine();
                Console.WriteLine("Write fam");
                int.TryParse(Console.ReadLine(), out int year);
                workers[i] = new Worker(fam, prof, year);
            }

            foreach (Worker item in workers)
            {
                Console.WriteLine(item);
            }
        }
    }
}