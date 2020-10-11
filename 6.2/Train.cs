using System;

namespace _6._2
{
    internal struct Train
    {
        public readonly string From { get; }

        public readonly int Number { get; }

        public readonly DateTime Time { get; }

        public Train(string from, int number, DateTime time)
        {
            From = from;
            Number = number;
            Time = time;
        }

        public void Show()
        {
            Console.WriteLine("From = {0}, number = {1}, Time = {2}", From, Number, Time);
        }
    }
}