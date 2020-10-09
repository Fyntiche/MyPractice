using System;
using System.Collections;
using System.Linq;

namespace _60_LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);

            var query = from int n in arrayList
                        select n * 2;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}