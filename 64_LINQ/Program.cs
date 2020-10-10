using System;
using System.Linq;

namespace _64_LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var query = from num in numbers
                        group num by num % 3 into partion
                        where partion.Count() > 2
                        select new { Key = partion.Key, Count = partion.Count(), Group = partion };
            foreach (var item in query)
            {
                Console.WriteLine(item.Key + " " + item.Count);
                foreach (var group in item.Group)
                {
                    Console.Write(group + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}