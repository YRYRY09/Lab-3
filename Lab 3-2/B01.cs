using Lab_3_2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    class B01 : B
    {
        public B01(string country, string city, DateTime cityTime) : base(country, city, cityTime)
        {
        }
        public override void LongDate()
        {
            Console.WriteLine($"{city}: {cityTime.ToUniversalTime()}");
            Debug.WriteLine($"{country}, {city}, {cityTime}\n");
        }
    }
}