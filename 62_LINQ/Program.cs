using System;
using System.Dynamic;
using System.Linq;

namespace _62_LINQ
{
    public class Result
    {
        public int Input { get; set; }

        public int Output { get; set; }

        public Result(int input, int output)
        {
            Input = input;
            Output = output;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var query = from num in numbers
                        select new Result(num, num * 2);

            numbers[0] = 10;
            foreach (var item in query)
            {
                Console.WriteLine("input = {0}, output = {1}", item.Input, item.Output);
            }
            Console.ReadKey();
        }
    }
}