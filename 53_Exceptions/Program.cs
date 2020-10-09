using System;
using System.Collections;

namespace _53_Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Exception exception = new Exception("My exception");
            exception.Data.Add("para", "errors");

            try
            {
                throw exception;
                //throw new Exception("Exceptions 2");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                foreach (DictionaryEntry item in e.Data)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
            Console.ReadLine();
        }
    }
}