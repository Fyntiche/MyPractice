using System;
using System.Linq;

namespace _6._2
{
    internal class TrainStation
    {
        private Train[] Trains = new Train[10];

        public Train this[int index]
        {
            get
            {
                return Trains[index];
            }
            set
            {
                Trains[index] = value;
            }
        }

        public TrainStation(Train train)
        {
            Trains.Append(train);
        }

        public void Show()
        {
            var query = from train in Trains
                        orderby train.Number
                        select new
                        {
                            train.From,
                            train.Number,
                            train.Time
                        };
            foreach (var train in query)
            {
                Console.WriteLine("From = {0}, number = {1}, Time = {2}", train.From, train.Number, train.Time);
            }
        }

        public void Search(int number)
        {
            bool key = true;
            foreach (var train in Trains)
            {
                if (train.Number == number)
                {
                    train.Show();
                    key = false;
                }
            }
            if (key) Console.WriteLine("dosn`t have this train");
        }
    }
}