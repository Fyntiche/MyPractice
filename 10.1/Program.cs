using System;
using System.Security.Cryptography;

namespace _10._1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            Console.WriteLine(myList.Count);
            myList.Add(23424);
            myList.Add(56756);
            Console.WriteLine(myList.Contains(1));
            Console.WriteLine(myList.Count);
            Console.WriteLine(myList.Count);
            Console.WriteLine(new string('_', 50));
            var temp = myList.GetArray();
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
            Console.ReadKey();
        }
    }
}