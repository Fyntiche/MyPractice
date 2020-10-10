using System;

namespace _3._3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable playPlayes = player;
            playPlayes.Play();
            playPlayes.Pause();
            playPlayes.Stop();

            IRecodable recordPlayes = player;
            recordPlayes.Record();
            recordPlayes.Pause();
            recordPlayes.Stop();

            Console.Read();
        }
    }
}