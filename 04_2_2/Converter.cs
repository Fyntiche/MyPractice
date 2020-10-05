using System;

namespace _04_2_2
{
    internal class Converter
    {
        private readonly double usd;
        private readonly double eur;
        private readonly double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void ConvertGrivToUSD(double griv)
        {
            Console.WriteLine(Math.Round(griv / usd, 0));
        }

        public void ConvertGrivToEur(double griv)
        {
            Console.WriteLine(Math.Round(griv / eur, 0));
        }

        public void ConvertGrivToRub(double griv)
        {
            Console.WriteLine(Math.Round(griv / rub, 0));
        }
    }
}