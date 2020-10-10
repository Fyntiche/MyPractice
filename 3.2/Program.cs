using System;

namespace _3._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write name documents");
            string FileName = Console.ReadLine();
            Redactor redactor = new Redactor();
            redactor.ChoiseDocument(FileName);
            redactor.Create();
            redactor.Change();
            redactor.Open();
            redactor.Save();
            Console.ReadKey();
        }
    }
}