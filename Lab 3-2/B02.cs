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
    class B02 : B
    {
        public B02(string country, string city, DateTime cityTime) : base(country, city, cityTime)
        {
        }
        public override void ShortDate()
        {
            Console.WriteLine($"{city}: {cityTime.ToLongDateString()}");
            Debug.WriteLine($"{country}, {city}, {cityTime}\n");
        }
    }
}
