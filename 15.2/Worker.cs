using System;
using System.Collections.Generic;
using System.Text;

namespace _15._2
{
    internal struct Worker
    {
        private string FullName;
        private string Prof;
        private int Year;

        public Worker(string fullName, string prof, int year)
        {
            FullName = fullName;
            Prof = prof;
            Year = year;
        }

        public override string ToString()
        {
            return FullName + " " + Prof + " " + Year;
        }
    }
}