using System;
using System.Collections;

namespace _53_Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Exception exception = new Exception("My exception");
            exception.Data.Add("para", "erroes");

            try
            {
                throw exception;
                //throw new Exception("Exeptions 2");
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