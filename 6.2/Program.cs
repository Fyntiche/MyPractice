using System;

namespace _6._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TrainStation station = new TrainStation(new Train("Minsk", 1, DateTime.Now));
            station[1] = new Train("Minsk2", 2, DateTime.Now);
            station[2] = new Train("Minsk3", 3, DateTime.Now);
            station[3] = new Train("Minss4", 4, DateTime.Now);
            station[4] = new Train("Minsk5", 5, DateTime.Now);
            station.Show();
            Console.WriteLine("write number train");
            int number = int.Parse(Console.ReadLine());
            station.Search(number);
            Console.ReadLine();
        }
    }
}