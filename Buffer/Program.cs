using System;

namespace Buffer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var buffer = new Buffer<double>();
            buffer.Write(0.12);
            buffer.Write(0.12);
            buffer.Write(0.12);
            buffer.Write(0.12);

            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }
        }
    }
}