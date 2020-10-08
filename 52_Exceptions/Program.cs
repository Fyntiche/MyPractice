using System;
using System.Text;

namespace _52_Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 1, n = 2;
            try
            {
                a = a / (2 - n);
            }
            catch (Exception e)
            {
                Console.WriteLine("деление на ноль");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}