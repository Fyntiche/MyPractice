using System;

namespace _04_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(1.1, 1.2, 1.3);
            converter.ConvertGrivToEur(5);
            converter.ConvertGrivToRub(10);
            converter.ConvertGrivToUSD(45);
            Console.ReadKey();
        }
    }
}
