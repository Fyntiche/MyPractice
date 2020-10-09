using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace _59_LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var query = from x in Enumerable.Range(0, 9)
                        from y in Enumerable.Range(0, 9)
                        select new
                        {
                            X = x,
                            Y = y,
                            Product = x * y
                        };
            foreach (var item in query)
            {
                Console.WriteLine("x={0} y={1} product={2}", item.X, item.Y, item.Product);
            }
            Console.ReadLine();
        }
    }
}