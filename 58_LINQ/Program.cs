using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _58_LINQ
{
    public static class MySet
    {
        public static IEnumerable<TResult> Where<TResult>(this IEnumerable<TResult> source, Func<TResult, bool> predicate)
        {
            Console.WriteLine("new realization");
            return System.Linq.Enumerable.Where(source, predicate);
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            Console.WriteLine("new realization");
            return System.Linq.Enumerable.Select(source, selector);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var query = from num in numbers
                        where num % 2 == 0
                        select num * 2;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}